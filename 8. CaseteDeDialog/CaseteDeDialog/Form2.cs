using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseteDeDialog
{
    public partial class Form2 : Form
    {
        public string textBoxText;
        public Form2()
        {
            InitializeComponent();
        }
        public string TextBoxText
        {
            get { return (textBoxText); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxText = textBox1.Text; this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 v = new Form2(); v.ShowDialog();
            if (v.DialogResult != DialogResult.OK)
            { this.textBox1.Clear(); }
        }
    }
}