namespace ApplicationLayer
{
    partial class Form1
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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            btnDel = new DevExpress.XtraEditors.SimpleButton();
            btnUpd = new DevExpress.XtraEditors.SimpleButton();
            txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            cmbDistrict = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbProvince = new DevExpress.XtraEditors.ComboBoxEdit();
            richTaxOffice = new System.Windows.Forms.RichTextBox();
            richAddress = new System.Windows.Forms.RichTextBox();
            maskFax = new DevExpress.XtraEditors.TextEdit();
            txtMail = new DevExpress.XtraEditors.TextEdit();
            maskTel3 = new DevExpress.XtraEditors.TextEdit();
            maskTel2 = new DevExpress.XtraEditors.TextEdit();
            maskTel1 = new DevExpress.XtraEditors.TextEdit();
            txtAuthorizedStatus = new DevExpress.XtraEditors.TextEdit();
            txtAuthorizedName = new DevExpress.XtraEditors.TextEdit();
            txtId = new DevExpress.XtraEditors.TextEdit();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCompanyName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbDistrict.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbProvince.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maskFax.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maskTel3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maskTel2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maskTel1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAuthorizedStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAuthorizedName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridControl1.Location = new System.Drawing.Point(0, -1);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1466, 1012);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 404;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnAdd);
            groupControl1.Controls.Add(btnDel);
            groupControl1.Controls.Add(btnUpd);
            groupControl1.Controls.Add(txtCompanyName);
            groupControl1.Controls.Add(cmbDistrict);
            groupControl1.Controls.Add(cmbProvince);
            groupControl1.Controls.Add(richTaxOffice);
            groupControl1.Controls.Add(richAddress);
            groupControl1.Controls.Add(maskFax);
            groupControl1.Controls.Add(txtMail);
            groupControl1.Controls.Add(maskTel3);
            groupControl1.Controls.Add(maskTel2);
            groupControl1.Controls.Add(maskTel1);
            groupControl1.Controls.Add(txtAuthorizedStatus);
            groupControl1.Controls.Add(txtAuthorizedName);
            groupControl1.Controls.Add(txtId);
            groupControl1.Controls.Add(labelControl13);
            groupControl1.Controls.Add(labelControl9);
            groupControl1.Controls.Add(labelControl10);
            groupControl1.Controls.Add(labelControl11);
            groupControl1.Controls.Add(labelControl12);
            groupControl1.Controls.Add(labelControl5);
            groupControl1.Controls.Add(labelControl6);
            groupControl1.Controls.Add(labelControl7);
            groupControl1.Controls.Add(labelControl8);
            groupControl1.Controls.Add(labelControl4);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new System.Drawing.Point(1474, 12);
            groupControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(475, 985);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "Ýþlemler";
            // 
            // btnAdd
            // 
            btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Location = new System.Drawing.Point(11, 720);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(174, 54);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Kaydet";
            btnAdd.Click += btnadd_Click;
            // 
            // btnDel
            // 
            btnDel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnDel.Appearance.Options.UseFont = true;
            btnDel.Location = new System.Drawing.Point(124, 793);
            btnDel.Name = "btnDel";
            btnDel.Size = new System.Drawing.Size(174, 54);
            btnDel.TabIndex = 29;
            btnDel.Text = "Sil";
            btnDel.Click += btndelete_Click;
            // 
            // btnUpd
            // 
            btnUpd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            btnUpd.Appearance.Options.UseFont = true;
            btnUpd.Location = new System.Drawing.Point(244, 720);
            btnUpd.Name = "btnUpd";
            btnUpd.Size = new System.Drawing.Size(174, 54);
            btnUpd.TabIndex = 28;
            btnUpd.Text = "Güncelle";
            btnUpd.Click += btnupdate_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new System.Drawing.Point(165, 83);
            txtCompanyName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            txtCompanyName.Properties.Appearance.Options.UseFont = true;
            txtCompanyName.Size = new System.Drawing.Size(209, 26);
            txtCompanyName.TabIndex = 27;
            // 
            // cmbDistrict
            // 
            cmbDistrict.Location = new System.Drawing.Point(165, 499);
            cmbDistrict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbDistrict.Name = "cmbDistrict";
            cmbDistrict.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            cmbDistrict.Properties.Appearance.Options.UseFont = true;
            cmbDistrict.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbDistrict.Size = new System.Drawing.Size(209, 26);
            cmbDistrict.TabIndex = 26;
            // 
            // cmbProvince
            // 
            cmbProvince.Location = new System.Drawing.Point(165, 453);
            cmbProvince.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbProvince.Name = "cmbProvince";
            cmbProvince.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            cmbProvince.Properties.Appearance.Options.UseFont = true;
            cmbProvince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbProvince.Size = new System.Drawing.Size(209, 26);
            cmbProvince.TabIndex = 25;
            cmbProvince.SelectedIndexChanged += cmbProvince_SelectedIndexChanged;
            // 
            // richTaxOffice
            // 
            richTaxOffice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            richTaxOffice.Location = new System.Drawing.Point(165, 635);
            richTaxOffice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richTaxOffice.Name = "richTaxOffice";
            richTaxOffice.Size = new System.Drawing.Size(209, 65);
            richTaxOffice.TabIndex = 24;
            richTaxOffice.Text = "";
            // 
            // richAddress
            // 
            richAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            richAddress.Location = new System.Drawing.Point(165, 551);
            richAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richAddress.Name = "richAddress";
            richAddress.Size = new System.Drawing.Size(209, 65);
            richAddress.TabIndex = 23;
            richAddress.Text = "";
            // 
            // maskFax
            // 
            maskFax.Location = new System.Drawing.Point(165, 406);
            maskFax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            maskFax.Name = "maskFax";
            maskFax.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            maskFax.Properties.Appearance.Options.UseFont = true;
            maskFax.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            maskFax.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            maskFax.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            maskFax.Size = new System.Drawing.Size(209, 26);
            maskFax.TabIndex = 21;
            // 
            // txtMail
            // 
            txtMail.Location = new System.Drawing.Point(165, 360);
            txtMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMail.Name = "txtMail";
            txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            txtMail.Properties.Appearance.Options.UseFont = true;
            txtMail.Size = new System.Drawing.Size(209, 26);
            txtMail.TabIndex = 20;
            // 
            // maskTel3
            // 
            maskTel3.Location = new System.Drawing.Point(165, 314);
            maskTel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            maskTel3.Name = "maskTel3";
            maskTel3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            maskTel3.Properties.Appearance.Options.UseFont = true;
            maskTel3.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            maskTel3.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            maskTel3.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            maskTel3.Size = new System.Drawing.Size(209, 26);
            maskTel3.TabIndex = 19;
            // 
            // maskTel2
            // 
            maskTel2.Location = new System.Drawing.Point(165, 268);
            maskTel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            maskTel2.Name = "maskTel2";
            maskTel2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            maskTel2.Properties.Appearance.Options.UseFont = true;
            maskTel2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            maskTel2.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            maskTel2.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            maskTel2.Size = new System.Drawing.Size(209, 26);
            maskTel2.TabIndex = 18;
            // 
            // maskTel1
            // 
            maskTel1.Location = new System.Drawing.Point(165, 222);
            maskTel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            maskTel1.Name = "maskTel1";
            maskTel1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            maskTel1.Properties.Appearance.Options.UseFont = true;
            maskTel1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            maskTel1.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            maskTel1.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            maskTel1.Size = new System.Drawing.Size(209, 26);
            maskTel1.TabIndex = 17;
            // 
            // txtAuthorizedStatus
            // 
            txtAuthorizedStatus.Location = new System.Drawing.Point(165, 176);
            txtAuthorizedStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAuthorizedStatus.Name = "txtAuthorizedStatus";
            txtAuthorizedStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            txtAuthorizedStatus.Properties.Appearance.Options.UseFont = true;
            txtAuthorizedStatus.Size = new System.Drawing.Size(209, 26);
            txtAuthorizedStatus.TabIndex = 16;
            // 
            // txtAuthorizedName
            // 
            txtAuthorizedName.Location = new System.Drawing.Point(165, 130);
            txtAuthorizedName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAuthorizedName.Name = "txtAuthorizedName";
            txtAuthorizedName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            txtAuthorizedName.Properties.Appearance.Options.UseFont = true;
            txtAuthorizedName.Size = new System.Drawing.Size(209, 26);
            txtAuthorizedName.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(165, 37);
            txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Size = new System.Drawing.Size(209, 26);
            txtId.TabIndex = 13;
            // 
            // labelControl13
            // 
            labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl13.Appearance.Options.UseFont = true;
            labelControl13.Location = new System.Drawing.Point(19, 635);
            labelControl13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new System.Drawing.Size(101, 19);
            labelControl13.TabIndex = 12;
            labelControl13.Text = "Vergi Dairesi :";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl9.Appearance.Options.UseFont = true;
            labelControl9.Location = new System.Drawing.Point(68, 548);
            labelControl9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new System.Drawing.Size(52, 19);
            labelControl9.TabIndex = 11;
            labelControl9.Text = "Adres :";
            // 
            // labelControl10
            // 
            labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl10.Appearance.Options.UseFont = true;
            labelControl10.Location = new System.Drawing.Point(87, 502);
            labelControl10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new System.Drawing.Size(36, 19);
            labelControl10.TabIndex = 10;
            labelControl10.Text = "Ýlçe :";
            // 
            // labelControl11
            // 
            labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl11.Appearance.Options.UseFont = true;
            labelControl11.Location = new System.Drawing.Point(108, 456);
            labelControl11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new System.Drawing.Size(21, 19);
            labelControl11.TabIndex = 9;
            labelControl11.Text = "Ýl :";
            // 
            // labelControl12
            // 
            labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl12.Appearance.Options.UseFont = true;
            labelControl12.Location = new System.Drawing.Point(92, 410);
            labelControl12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new System.Drawing.Size(35, 19);
            labelControl12.TabIndex = 8;
            labelControl12.Text = "Fax :";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new System.Drawing.Point(92, 364);
            labelControl5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(39, 19);
            labelControl5.TabIndex = 7;
            labelControl5.Text = "Mail :";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new System.Drawing.Point(46, 318);
            labelControl6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new System.Drawing.Size(78, 19);
            labelControl6.TabIndex = 6;
            labelControl6.Text = "Telefon 3 :";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new System.Drawing.Point(46, 271);
            labelControl7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new System.Drawing.Size(78, 19);
            labelControl7.TabIndex = 5;
            labelControl7.Text = "Telefon 2 :";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new System.Drawing.Point(46, 225);
            labelControl8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new System.Drawing.Size(78, 19);
            labelControl8.TabIndex = 4;
            labelControl8.Text = "Telefon 1 :";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(11, 179);
            labelControl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(108, 19);
            labelControl4.TabIndex = 3;
            labelControl4.Text = "Yetkili Ünvaný :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(40, 133);
            labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(83, 19);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "Yetkili Adý :";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(44, 87);
            labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(80, 19);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "Firma Adý :";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(107, 41);
            labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(26, 19);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Id :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1904, 871);
            Controls.Add(groupControl1);
            Controls.Add(gridControl1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "SNR Otomasyon";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCompanyName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbDistrict.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbProvince.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)maskFax.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)maskTel3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)maskTel2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)maskTel1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAuthorizedStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAuthorizedName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit maskFax;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.TextEdit maskTel3;
        private DevExpress.XtraEditors.TextEdit maskTel2;
        private DevExpress.XtraEditors.TextEdit maskTel1;
        private DevExpress.XtraEditors.TextEdit txtAuthorizedStatus;
        private DevExpress.XtraEditors.TextEdit txtAuthorizedName;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDistrict;
        private DevExpress.XtraEditors.ComboBoxEdit cmbProvince;
        private System.Windows.Forms.RichTextBox richTaxOffice;
        private System.Windows.Forms.RichTextBox richAddress;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnUpd;
    }
}

