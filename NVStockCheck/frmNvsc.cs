using NVStockCheck.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Diagnostics;
using System.Media;

namespace NVStockCheck
{
    public partial class frmNvsc : Form
    {

        public frmNvsc()
        {
            InitializeComponent();

            AddVersionNumber();

           

        }

        private void AddVersionNumber()
        {
            //Get version number from assembly.
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            this.Text += $" v.{versionInfo.FileVersion}"; 
        }

       

        public Dictionary<string, string> productsList = new Dictionary<string, string>();

        public Dictionary<string, string> regionList = new Dictionary<string, string>()
        {
            {"UK", "en_gb/GBP/"},
            {"US", "en_us/USD/" },
            {"NL", "nl_nl/EUR/" }
        };

        private void frmNvsc_Load(object sender, EventArgs e)
        {
            loadProductsList();
            populateProductComboBox();
        }

        public void loadProductsList()
        {
            try
            {
                string filePath = Application.StartupPath + @"\products.csv";

                Debug.WriteLine(filePath);

                if(File.Exists(filePath))
                {
                    var lines = File.ReadLines(filePath);
                    productsList = lines.Select(line => line.Split(',')).ToDictionary(data => data[0], data => data[1]);
                }   
                else
                {
                    MessageBox.Show("No products file exists within program directory.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void populateProductComboBox()
        {
            try
            {
                if(productsList.Count > 0)
                {
                    foreach(KeyValuePair<string,string> product in productsList)
                    {
                        cbProducts.Items.Add(product.Key);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public Response getProductResponse (string product, string region)
        {
            string baseUrl = "https://in-and-ru-store-api.uk-e1.cloudhub.io/DR/products/";

            try
            {
                if(product != "")
                {
                    if(region !="")
                    {
                        string productUrl = baseUrl + region + product;

                        WebClient webClient = new WebClient();

                        string jsonString = webClient.DownloadString(productUrl);

                        if (jsonString != "")
                        {
                            Response response = JsonConvert.DeserializeObject<Response>(jsonString);

                            if(response.products.product.Count != 0)
                            {
                                return response;
                            }
                            else
                            {
                                MessageBox.Show("Unable to obtain product data. Please ensure IDs are correct in the product files.");
                                return null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unable to obtain product data. Please ensure IDs are correct in the product files.");
                            return null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: No Region Specified");
                        return null;
                    } 
                }
                else
                {
                    MessageBox.Show("Error: No product specified.");
                    return null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: Unable to contact API, Exception: " + ex.Message);
                return null;
            }
        }

        public void updateProductFields(Response productData)
        {
            try
            {
                //Notification sound when product is in stock
                SoundPlayer soundPlayer = new SoundPlayer(@"c:\Windows\Media\notify.wav");                

                if(productData != null)
                {

                    //Update 'Last updated' label
                    lblTimeUpdated.Text = "Updated at: " + DateTime.Now.ToString("hh:mm:ss");

                    //Make labels visible
                    lblTimeUpdated.Visible = true;
                    lblName.Visible = true;
                    lblProductId.Visible = true;
                    lblPrice.Visible = true;
                    lblStockStatus.Visible = true;

                    //Set Label values
                    lblName.Text = productData.products.product[0].displayName;
                    lblProductId.Text = productData.products.product[0].id;
                    lblPrice.Text = productData.products.product[0].pricing.listPrice.value.ToString();
                    lblStockStatus.Text = productData.products.product[0].inventoryStatus.status;
                    pbThumbnailImage.Load(productData.products.product[0].thumbnailImage);

                    //Update Stock label colour based on availbility
                    switch (lblStockStatus.Text)
                    {
                        case "PRODUCT_INVENTORY_OUT_OF_STOCK":
                            lblStockStatus.ForeColor = Color.Red;
                            break;
                        case "PRODUCT_INVENTORY_IN_STOCK":
                            lblStockStatus.ForeColor = Color.Green;

                            //Play alert sound if the 'mute alert' checkbox isn't ticked.
                            if(cbMuteStockAlert.Checked == false)
                            {
                                soundPlayer.Play();
                            }
                            break;
                        default:
                            lblStockStatus.ForeColor = Color.Black;
                            break;
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnManualUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbProducts.Text != "")
                {
                    if(cbRegion.Text !="")
                    {
                        Response response = getProductResponse(productsList[cbProducts.Text], regionList[cbRegion.Text]);
                        updateProductFields(response);
                    }  
                    else
                    {
                        MessageBox.Show("Please specify a product region.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to lookup.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbProducts.Text != "")
                {
                    if (cbRegion.Text != "")
                    {
                        if (cbAutoRefresh.Checked)
                        {
                            if (cbCustomInterval.Checked)
                            {
                                tmrAutoRefresh.Interval = Convert.ToInt32(numRefreshInterval.Value) * 1000;
                                tmrAutoRefresh.Start();
                                cbCustomInterval.Enabled = false;
                                numRefreshInterval.Enabled = false;   
                            }
                            else
                            {           
                                tmrAutoRefresh.Interval = 60000;
                                tmrAutoRefresh.Start();
                                cbCustomInterval.Enabled = false;
                                numRefreshInterval.Enabled = false;
                            }
                        }
                        else
                        {
                            tmrAutoRefresh.Stop();
                            cbCustomInterval.Enabled = true;
                            if(cbCustomInterval.Checked)
                            {
                                numRefreshInterval.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        
                        if(cbAutoRefresh.Checked)
                        {
                            MessageBox.Show("Please select a region before auto refreshing.");
                        }
                        cbAutoRefresh.Checked = false;
                    }
                }
                else
                {
                    
                    if (cbAutoRefresh.Checked)
                    {
                        MessageBox.Show("Please select a product before auto refreshing.");
                    }
                    cbAutoRefresh.Checked = false;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbCustomInterval_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAutoRefresh.Checked == false)
            {
                if(cbCustomInterval.Checked)
                {
                    numRefreshInterval.Enabled = true;
                }
                else
                {
                    numRefreshInterval.Enabled = false;
                }
            }
        }

        private void tmrAutoRefresh_Tick(object sender, EventArgs e)
        {
            if(cbProducts.Text != "" && cbRegion.Text !="")
            {
                Response response = getProductResponse(productsList[cbProducts.Text], regionList[cbRegion.Text]);
                updateProductFields(response);
            }
            else
            {
                MessageBox.Show("Unable to auto-refresh without a product or region.");
                cbAutoRefresh.Checked = false;
            }
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Disable timer if active
            if(cbAutoRefresh.Checked)
            {
                cbAutoRefresh.Checked = false;
            }
        }
    }
}
