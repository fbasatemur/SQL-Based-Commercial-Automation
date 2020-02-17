namespace Commercial_Automation_System
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSystemPassw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSystemAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMessage = new System.Windows.Forms.RichTextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMailAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txtSystemPassw);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSystemAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBoxMessage);
            this.panel1.Controls.Add(this.txtSubject);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMailAddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 393);
            this.panel1.TabIndex = 6;
            // 
            // txtSystemPassw
            // 
            this.txtSystemPassw.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtSystemPassw.Location = new System.Drawing.Point(144, 105);
            this.txtSystemPassw.Name = "txtSystemPassw";
            this.txtSystemPassw.Size = new System.Drawing.Size(397, 24);
            this.txtSystemPassw.TabIndex = 19;
            this.txtSystemPassw.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(45, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password :";
            // 
            // txtSystemAddress
            // 
            this.txtSystemAddress.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtSystemAddress.Location = new System.Drawing.Point(144, 75);
            this.txtSystemAddress.Name = "txtSystemAddress";
            this.txtSystemAddress.Size = new System.Drawing.Size(397, 24);
            this.txtSystemAddress.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(3, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "System Address :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 69);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(18, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 57);
            this.label4.TabIndex = 0;
            this.label4.Text = "SEND MAIL";
            // 
            // btnSend
            // 
            this.btnSend.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSend.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnSend.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSend.Appearance.Options.UseBackColor = true;
            this.btnSend.Appearance.Options.UseForeColor = true;
            this.btnSend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.ImageOptions.Image")));
            this.btnSend.Location = new System.Drawing.Point(144, 335);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(397, 50);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "SEND";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(57, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Message :";
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtBoxMessage.Location = new System.Drawing.Point(144, 202);
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(397, 113);
            this.txtBoxMessage.TabIndex = 12;
            this.txtBoxMessage.Text = "";
            // 
            // txtSubject
            // 
            this.txtSubject.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtSubject.Location = new System.Drawing.Point(144, 169);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(397, 24);
            this.txtSubject.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(69, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subject :";
            // 
            // txtMailAddress
            // 
            this.txtMailAddress.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtMailAddress.Location = new System.Drawing.Point(144, 139);
            this.txtMailAddress.Name = "txtMailAddress";
            this.txtMailAddress.Size = new System.Drawing.Size(397, 24);
            this.txtMailAddress.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(28, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mail Address :";
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(564, 393);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtBoxMessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMailAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSystemAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSystemPassw;
        private System.Windows.Forms.Label label6;
    }
}