using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodwlwClearSiAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "Am selectat si am adaugat itemii: ";
            listBox1.Items.Clear();
            foreach (object c in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(c);
                s = s + c.ToString(); s = s + " ";
            }
            textBox1.Text = s;
        }
    }
}
