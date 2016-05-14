using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModificareProprietati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.Color = Color.IndianRed;
            fd.ShowApply = true;
            //fd.Apply += new EventHandler(ApplyFont);
            if (fd.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                this.richTextBox1.Font = fd.Font;
                this.richTextBox1.ForeColor = fd.Color;
            }
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = Color.DarkBlue;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.richTextBox1.ForeColor = cd.Color;
        }
    }
}
