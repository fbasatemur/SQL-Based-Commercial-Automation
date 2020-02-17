namespace Commercial_Automation_System
{
    partial class FrmBanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanks));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtAccountType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtBranch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.btnClean = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.mskDate = new System.Windows.Forms.MaskedTextBox();
            this.txtAuthorized = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.txtAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtIBAN = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorized.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 328;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(-1, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(784, 505);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(150, 314);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtAccountType.Properties.Appearance.Options.UseFont = true;
            this.txtAccountType.Size = new System.Drawing.Size(130, 24);
            this.txtAccountType.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(39, 316);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(101, 18);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Account Type :";
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(150, 174);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBranch.Properties.Appearance.Options.UseFont = true;
            this.txtBranch.Size = new System.Drawing.Size(130, 24);
            this.txtBranch.TabIndex = 6;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(85, 177);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(55, 18);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Branch :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(90, 234);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 18);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Phone :";
            // 
            // mskPhone
            // 
            this.mskPhone.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mskPhone.Location = new System.Drawing.Point(150, 230);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(130, 26);
            this.mskPhone.TabIndex = 8;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(47, 347);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(93, 18);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "Company ID :";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(150, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 45);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(150, 399);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 45);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(5, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 45);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(96, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 18);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "IBAN :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(119, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(150, 28);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(130, 24);
            this.txtID.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit);
            this.groupControl1.Controls.Add(this.btnClean);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.mskDate);
            this.groupControl1.Controls.Add(this.txtAuthorized);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.cmbDistrict);
            this.groupControl1.Controls.Add(this.cmbCity);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtBankName);
            this.groupControl1.Controls.Add(this.txtAccountNo);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtIBAN);
            this.groupControl1.Controls.Add(this.txtAccountType);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtBranch);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.mskPhone);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Location = new System.Drawing.Point(789, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(294, 505);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // lookUpEdit
            // 
            this.lookUpEdit.Location = new System.Drawing.Point(150, 344);
            this.lookUpEdit.Name = "lookUpEdit";
            this.lookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit.Size = new System.Drawing.Size(130, 24);
            this.lookUpEdit.TabIndex = 51;
            // 
            // btnClean
            // 
            this.btnClean.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.ImageOptions.Image")));
            this.btnClean.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClean.Location = new System.Drawing.Point(5, 450);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(135, 45);
            this.btnClean.TabIndex = 15;
            this.btnClean.Text = "CLEAN";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(99, 261);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(41, 18);
            this.labelControl14.TabIndex = 50;
            this.labelControl14.Text = "Date :";
            // 
            // mskDate
            // 
            this.mskDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mskDate.Location = new System.Drawing.Point(150, 257);
            this.mskDate.Mask = "00/00/0000";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(130, 26);
            this.mskDate.TabIndex = 9;
            this.mskDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtAuthorized
            // 
            this.txtAuthorized.Location = new System.Drawing.Point(150, 202);
            this.txtAuthorized.Name = "txtAuthorized";
            this.txtAuthorized.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtAuthorized.Properties.Appearance.Options.UseFont = true;
            this.txtAuthorized.Size = new System.Drawing.Size(130, 24);
            this.txtAuthorized.TabIndex = 7;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(62, 204);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(78, 18);
            this.labelControl13.TabIndex = 48;
            this.labelControl13.Text = "Authorized :";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Location = new System.Drawing.Point(150, 144);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(130, 26);
            this.cmbDistrict.TabIndex = 5;
            // 
            // cmbCity
            // 
            this.cmbCity.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(150, 112);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(130, 26);
            this.cmbCity.TabIndex = 4;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(87, 150);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(53, 18);
            this.labelControl8.TabIndex = 46;
            this.labelControl8.Text = "District :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(106, 118);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 18);
            this.labelControl7.TabIndex = 45;
            this.labelControl7.Text = "City :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(54, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 18);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "Bank Name :";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(150, 56);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBankName.Properties.Appearance.Options.UseFont = true;
            this.txtBankName.Size = new System.Drawing.Size(130, 24);
            this.txtBankName.TabIndex = 2;
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(150, 286);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtAccountNo.Properties.Appearance.Options.UseFont = true;
            this.txtAccountNo.Size = new System.Drawing.Size(130, 24);
            this.txtAccountNo.TabIndex = 10;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(55, 286);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(85, 18);
            this.labelControl12.TabIndex = 40;
            this.labelControl12.Text = "Account No :";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(150, 84);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtIBAN.Properties.Appearance.Options.UseFont = true;
            this.txtIBAN.Size = new System.Drawing.Size(130, 24);
            this.txtIBAN.TabIndex = 3;
            // 
            // FrmBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmBanks";
            this.Text = "Banks";
            this.Load += new System.EventHandler(this.FrmBanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorized.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtAccountType;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtBranch;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtAccountNo;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtIBAN;
        private DevExpress.XtraEditors.TextEdit txtAuthorized;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.ComboBox cmbCity;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.MaskedTextBox mskDate;
        private DevExpress.XtraEditors.SimpleButton btnClean;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit;
    }
}