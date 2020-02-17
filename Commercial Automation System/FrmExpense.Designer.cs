namespace Commercial_Automation_System
{
    partial class FrmExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpense));
            this.btnClean = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSalary = new DevExpress.XtraEditors.TextEdit();
            this.txtInternet = new DevExpress.XtraEditors.TextEdit();
            this.txtWater = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtFuel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtBoxNote = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtElectric = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtExtra = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWater.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElectric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.ImageOptions.Image")));
            this.btnClean.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClean.Location = new System.Drawing.Point(7, 450);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(135, 45);
            this.btnClean.TabIndex = 11;
            this.btnClean.Text = "CLEAN";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateTimePicker1);
            this.groupControl1.Controls.Add(this.txtSalary);
            this.groupControl1.Controls.Add(this.txtInternet);
            this.groupControl1.Controls.Add(this.txtWater);
            this.groupControl1.Controls.Add(this.btnClean);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtFuel);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.txtBoxNote);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtElectric);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.txtExtra);
            this.groupControl1.Location = new System.Drawing.Point(784, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(295, 502);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "groupControl1";
            // 
            // txtSalary
            // 
            this.txtSalary.EditValue = "";
            this.txtSalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSalary.Location = new System.Drawing.Point(158, 233);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(129, 22);
            this.txtSalary.TabIndex = 6;
            // 
            // txtInternet
            // 
            this.txtInternet.EditValue = "";
            this.txtInternet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtInternet.Location = new System.Drawing.Point(157, 203);
            this.txtInternet.Name = "txtInternet";
            this.txtInternet.Size = new System.Drawing.Size(129, 22);
            this.txtInternet.TabIndex = 5;
            // 
            // txtWater
            // 
            this.txtWater.EditValue = "";
            this.txtWater.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtWater.Location = new System.Drawing.Point(157, 136);
            this.txtWater.Name = "txtWater";
            this.txtWater.Size = new System.Drawing.Size(129, 22);
            this.txtWater.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl6.Location = new System.Drawing.Point(82, 262);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 21);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Ekstra :";
            // 
            // txtFuel
            // 
            this.txtFuel.EditValue = "";
            this.txtFuel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFuel.Location = new System.Drawing.Point(157, 170);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(129, 22);
            this.txtFuel.TabIndex = 4;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl11.Location = new System.Drawing.Point(93, 167);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 21);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Fuel  :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl4.Location = new System.Drawing.Point(84, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 21);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Water :";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(147, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 45);
            this.btnDelete.TabIndex = 12;
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
            this.btnUpdate.TabIndex = 10;
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
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxNote.Location = new System.Drawing.Point(6, 317);
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(279, 78);
            this.txtBoxNote.TabIndex = 8;
            this.txtBoxNote.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl9.Location = new System.Drawing.Point(7, 290);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 21);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Note :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl8.Location = new System.Drawing.Point(84, 232);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 21);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Salary :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl7.Location = new System.Drawing.Point(64, 202);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(76, 21);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = " Internet :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl3.Location = new System.Drawing.Point(74, 102);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 21);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Electric :";
            // 
            // txtElectric
            // 
            this.txtElectric.EditValue = "";
            this.txtElectric.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtElectric.Location = new System.Drawing.Point(157, 105);
            this.txtElectric.Name = "txtElectric";
            this.txtElectric.Properties.Mask.EditMask = "d";
            this.txtElectric.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtElectric.Size = new System.Drawing.Size(129, 22);
            this.txtElectric.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl2.Location = new System.Drawing.Point(95, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 21);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Date :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelControl1.Location = new System.Drawing.Point(116, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 21);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtID.Location = new System.Drawing.Point(157, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtExtra
            // 
            this.txtExtra.EditValue = "";
            this.txtExtra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtExtra.Location = new System.Drawing.Point(158, 265);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(129, 22);
            this.txtExtra.TabIndex = 7;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(774, 495);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 328;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 23);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // FrmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 503);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmExpense";
            this.ShowIcon = false;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.FrmExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWater.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtElectric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClean;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtSalary;
        private DevExpress.XtraEditors.TextEdit txtInternet;
        private DevExpress.XtraEditors.TextEdit txtWater;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtFuel;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.RichTextBox txtBoxNote;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtElectric;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtExtra;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}