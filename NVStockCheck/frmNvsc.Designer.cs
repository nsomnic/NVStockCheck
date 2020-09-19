namespace NVStockCheck
{
    partial class frmNvsc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNvsc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.pbThumbnailImage = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cbMuteStockAlert = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cbCustomInterval = new System.Windows.Forms.CheckBox();
            this.numRefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.cbAutoRefresh = new System.Windows.Forms.CheckBox();
            this.btnManualUpdate = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblTimeUpdated = new System.Windows.Forms.Label();
            this.tmrAutoRefresh = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnailImage)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshInterval)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRegion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "UK",
            "US",
            "NL"});
            this.cbRegion.Location = new System.Drawing.Point(397, 19);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(79, 21);
            this.cbRegion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(62, 19);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(328, 21);
            this.cbProducts.TabIndex = 0;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.pbThumbnailImage);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Information";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblProductId);
            this.groupBox7.Location = new System.Drawing.Point(137, 77);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(193, 45);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Digital River Product ID";
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(6, 20);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(55, 13);
            this.lblProductId.TabIndex = 2;
            this.lblProductId.Text = "[PRODID]";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductId.Visible = false;
            // 
            // pbThumbnailImage
            // 
            this.pbThumbnailImage.BackColor = System.Drawing.SystemColors.Control;
            this.pbThumbnailImage.Location = new System.Drawing.Point(16, 19);
            this.pbThumbnailImage.Name = "pbThumbnailImage";
            this.pbThumbnailImage.Size = new System.Drawing.Size(107, 103);
            this.pbThumbnailImage.TabIndex = 3;
            this.pbThumbnailImage.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblStockStatus);
            this.groupBox5.Location = new System.Drawing.Point(14, 128);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(447, 66);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Stock Status";
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockStatus.Location = new System.Drawing.Point(6, 27);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(289, 20);
            this.lblStockStatus.TabIndex = 0;
            this.lblStockStatus.Text = "[SELECT PRODUCT TO VIEW STOCK]";
            this.lblStockStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStockStatus.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPrice);
            this.groupBox4.Location = new System.Drawing.Point(336, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 45);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(6, 19);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "[PRICE]";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Location = new System.Drawing.Point(137, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 45);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Name";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "[NAME]";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox10);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Location = new System.Drawing.Point(12, 75);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(482, 121);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cbMuteStockAlert);
            this.groupBox10.Location = new System.Drawing.Point(248, 67);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(228, 48);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Misc";
            // 
            // cbMuteStockAlert
            // 
            this.cbMuteStockAlert.AutoSize = true;
            this.cbMuteStockAlert.Location = new System.Drawing.Point(12, 19);
            this.cbMuteStockAlert.Name = "cbMuteStockAlert";
            this.cbMuteStockAlert.Size = new System.Drawing.Size(105, 17);
            this.cbMuteStockAlert.TabIndex = 3;
            this.cbMuteStockAlert.Text = "Mute Stock Alert";
            this.cbMuteStockAlert.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cbCustomInterval);
            this.groupBox9.Controls.Add(this.numRefreshInterval);
            this.groupBox9.Controls.Add(this.cbAutoRefresh);
            this.groupBox9.Controls.Add(this.btnManualUpdate);
            this.groupBox9.Location = new System.Drawing.Point(6, 15);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(235, 100);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Stock Updates";
            // 
            // cbCustomInterval
            // 
            this.cbCustomInterval.AutoSize = true;
            this.cbCustomInterval.Location = new System.Drawing.Point(8, 41);
            this.cbCustomInterval.Name = "cbCustomInterval";
            this.cbCustomInterval.Size = new System.Drawing.Size(99, 17);
            this.cbCustomInterval.TabIndex = 3;
            this.cbCustomInterval.Text = "Custom Interval";
            this.cbCustomInterval.UseVisualStyleBackColor = true;
            this.cbCustomInterval.CheckedChanged += new System.EventHandler(this.cbCustomInterval_CheckedChanged);
            // 
            // numRefreshInterval
            // 
            this.numRefreshInterval.Enabled = false;
            this.numRefreshInterval.Location = new System.Drawing.Point(112, 39);
            this.numRefreshInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRefreshInterval.Name = "numRefreshInterval";
            this.numRefreshInterval.Size = new System.Drawing.Size(117, 20);
            this.numRefreshInterval.TabIndex = 2;
            this.numRefreshInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // cbAutoRefresh
            // 
            this.cbAutoRefresh.AutoSize = true;
            this.cbAutoRefresh.Location = new System.Drawing.Point(8, 19);
            this.cbAutoRefresh.Name = "cbAutoRefresh";
            this.cbAutoRefresh.Size = new System.Drawing.Size(88, 17);
            this.cbAutoRefresh.TabIndex = 1;
            this.cbAutoRefresh.Text = "Auto Refresh";
            this.cbAutoRefresh.UseVisualStyleBackColor = true;
            this.cbAutoRefresh.CheckedChanged += new System.EventHandler(this.cbAutoRefresh_CheckedChanged);
            // 
            // btnManualUpdate
            // 
            this.btnManualUpdate.Location = new System.Drawing.Point(6, 71);
            this.btnManualUpdate.Name = "btnManualUpdate";
            this.btnManualUpdate.Size = new System.Drawing.Size(223, 23);
            this.btnManualUpdate.TabIndex = 0;
            this.btnManualUpdate.Text = "Manual Update";
            this.btnManualUpdate.UseVisualStyleBackColor = true;
            this.btnManualUpdate.Click += new System.EventHandler(this.btnManualUpdate_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblTimeUpdated);
            this.groupBox8.Location = new System.Drawing.Point(247, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(229, 53);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Last Updated";
            // 
            // lblTimeUpdated
            // 
            this.lblTimeUpdated.AutoSize = true;
            this.lblTimeUpdated.Location = new System.Drawing.Point(10, 24);
            this.lblTimeUpdated.Name = "lblTimeUpdated";
            this.lblTimeUpdated.Size = new System.Drawing.Size(92, 13);
            this.lblTimeUpdated.TabIndex = 0;
            this.lblTimeUpdated.Text = "[LASTUPDATED]";
            this.lblTimeUpdated.Visible = false;
            // 
            // tmrAutoRefresh
            // 
            this.tmrAutoRefresh.Interval = 60000;
            this.tmrAutoRefresh.Tick += new System.EventHandler(this.tmrAutoRefresh_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(13, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nsomnic";
            // 
            // frmNvsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNvsc";
            this.Text = " NV Stock Check";
            this.Load += new System.EventHandler(this.frmNvsc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnailImage)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshInterval)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnManualUpdate;
        private System.Windows.Forms.PictureBox pbThumbnailImage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblTimeUpdated;
        private System.Windows.Forms.CheckBox cbAutoRefresh;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckBox cbMuteStockAlert;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox cbCustomInterval;
        private System.Windows.Forms.NumericUpDown numRefreshInterval;
        private System.Windows.Forms.Timer tmrAutoRefresh;
        private System.Windows.Forms.Label label2;
    }
}

