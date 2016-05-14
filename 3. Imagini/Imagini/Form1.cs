using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\Master\\Sem 4\\Programare orientata pe componente\\Aplicatii\\ll.5.3-Imagini\\DA.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Image.FromFile("D:\\Master\\Sem 4\\Programare orientata pe componente\\Aplicatii\\ll.5.3-Imagini\\NU.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = true;
        }
    }
}
