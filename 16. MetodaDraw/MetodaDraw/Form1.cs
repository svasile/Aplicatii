using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodaDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphic = this.CreateGraphics();
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                imageList1.Draw(graphic, i * 120, 60, i);
            }
            graphic.Dispose();
        }
    }
}
