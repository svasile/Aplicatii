using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchimbaCuloarea
{
    public partial class Form1 : Form
    {
        Random r = new Random(200);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }
    }
}
