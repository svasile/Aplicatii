using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fisiere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text Files (*.txt)|*.txt";
            of.Title = "Fisiere Text";
            if (of.ShowDialog() == DialogResult.Cancel) return;
            richTextBox1.Text = "";
            richTextBox1.Visible = true;
            FileStream strm;
            try
            {
                strm = new FileStream(of.FileName, FileMode.Open, FileAccess.Read);
                StreamReader rdr = new StreamReader(strm);
                while (rdr.Peek() >= 0)
                {
                    string str = rdr.ReadLine();
                    richTextBox1.Text = richTextBox1.Text + " " + str;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file", "File Error",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void închideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void ieşireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.Color = Color.Black;
            fd.ShowApply = true;
            if (fd.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                this.richTextBox1.Font = fd.Font;
                this.richTextBox1.ForeColor = fd.Color;
            }
        }

        private void culoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = Color.DarkBlue;
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.richTextBox1.ForeColor = cd.Color;
        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://msdn2.microsoft.com/en-us/default.aspx");
        }

        private void despreAplicaţieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Exemplul permite, prin intermediul unui meniu, scrierea unui fişier Notpad, afişarea continutului acestuia într - o casetă text, schimbarea fontului şi culorii de afişare, ştergerea conţinutului casetei, afişarea unor informaţii teoretice precum şi Help dinamic. Au fost definite chei de acces rapid pentru accesarea componentelor meniului.";
        }
    }
}
