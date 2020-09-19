using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace NVStockCheck
{
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            Startup();
            frmNvsc nvsc = new frmNvsc();
            nvsc.Show();
        }

        static async Task Startup()
        {
            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/nsomnic/NVStockCheck/releases/latest"))
            {
                await mgr.Result.UpdateApp();
            }
        }
    }
}
