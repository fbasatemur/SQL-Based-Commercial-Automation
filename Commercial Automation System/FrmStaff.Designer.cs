namespace Commercial_Automation_System
{
    partial class FrmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaff));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.mskIdentityNo = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtBoxAddress = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClean = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.gridControl1.Location = new System.Drawing.Point(6, 7);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(774, 495);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // txtPosition
            // 
            this.txtPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPosition.Location = new System.Drawing.Point(158, 265);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(129, 22);
            this.txtPosition.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl6.Location = new System.Drawing.Point(82, 262);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 21);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Position :";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbDistrict.Location = new System.Drawing.Point(158, 233);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(128, 24);
            this.cmbDistrict.TabIndex = 8;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbCity.Location = new System.Drawing.Point(158, 203);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(128, 24);
            this.cmbCity.TabIndex = 7;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // txtMail
            // 
            this.txtMail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMail.Location = new System.Drawing.Point(157, 170);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(129, 22);
            this.txtMail.TabIndex = 6;
            // 
            // mskIdentityNo
            // 
            this.mskIdentityNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mskIdentityNo.Location = new System.Drawing.Point(157, 41);
            this.mskIdentityNo.Mask = "00000000000";
            this.mskIdentityNo.Name = "mskIdentityNo";
            this.mskIdentityNo.Size = new System.Drawing.Size(128, 23);
            this.mskIdentityNo.TabIndex = 1;
            this.mskIdentityNo.ValidatingType = typeof(int);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl11.Location = new System.Drawing.Point(105, 167);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 21);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Mail  :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl4.Location = new System.Drawing.Point(95, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 21);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Phone :";
            // 
            // mskPhone
            // 
            this.mskPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mskPhone.Location = new System.Drawing.Point(157, 138);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(128, 23);
            this.mskPhone.TabIndex = 4;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl10.Location = new System.Drawing.Point(63, 39);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(88, 21);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "Identity No:";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(147, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(147, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 45);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(6, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxAddress.Location = new System.Drawing.Point(6, 317);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(279, 78);
            this.txtBoxAddress.TabIndex = 10;
            this.txtBoxAddress.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl9.Location = new System.Drawing.Point(7, 290);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 21);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Address :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl8.Location = new System.Drawing.Point(86, 232);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 21);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "District :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl7.Location = new System.Drawing.Point(112, 202);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 21);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "City :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl3.Location = new System.Drawing.Point(75, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 21);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Surname :";
            // 
            // txtSurname
            // 
            this.txtSurname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSurname.Location = new System.Drawing.Point(157, 105);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(129, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl2.Location = new System.Drawing.Point(97, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 21);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtName.Location = new System.Drawing.Point(157, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 22);
            this.txtName.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl1.Location = new System.Drawing.Point(127, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 21);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtID.Location = new System.Drawing.Point(157, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 22);
            this.txtID.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClean);
            this.groupControl1.Controls.Add(this.txtPosition);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.cmbDistrict);
            this.groupControl1.Controls.Add(this.cmbCity);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.mskIdentityNo);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.mskPhone);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.txtBoxAddress);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSurname);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Location = new System.Drawing.Point(786, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(295, 502);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnClean
            // 
            this.btnClean.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.ImageOptions.Image")));
            this.btnClean.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClean.Location = new System.Drawing.Point(7, 450);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(135, 45);
            this.btnClean.TabIndex = 37;
            this.btnClean.Text = "CLEAN";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStaff";
            this.Text = "Staff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.ComboBox cmbCity;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private System.Windows.Forms.MaskedTextBox mskIdentityNo;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.RichTextBox txtBoxAddress;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClean;
    }
}