﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxSiRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked &&
                checkBox2.CheckState == CheckState.Checked &&
                checkBox3.CheckState == CheckState.Checked &&
                checkBox5.CheckState == CheckState.Checked &&
                checkBox4.CheckState == CheckState.Unchecked)
                MessageBox.Show("CORECT");
            else
                MessageBox.Show("Indicatie> Daca punem un sac in altul....");
            label1.Visible = false;
            radioButton1.Checked = false; radioButton2.Checked = false;
            radioButton1.Visible = false; radioButton2.Visible = false;
        }
    }
}
