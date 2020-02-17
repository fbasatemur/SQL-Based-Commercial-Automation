using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_Automation_System
{
    public partial class FrmNoteDetails : Form
    {
        public FrmNoteDetails()
        {
            InitializeComponent();
        }

        private string text;
        public string textGetSet
        {
            get { return text; }
            set { text = value; }
        }
        private void FrmNoteDetails_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = text;
        }
    }
}
