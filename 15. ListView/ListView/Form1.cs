using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SeteazaLista();
        }
        private void SeteazaLista()
        {
            listViewTest.Columns.Add("Nume", 200, HorizontalAlignment.Left);
            listViewTest.Columns.Add("Prenume", 200,
            HorizontalAlignment.Left);
            listViewTest.Columns.Add("Nota", 200, HorizontalAlignment.Left);
            listViewTest.View = View.Details;
            listViewTest.Sorting = SortOrder.Ascending;
            listViewTest.AllowColumnReorder = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listViewTest.BeginUpdate();
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;
            foreach (Elev elev in Elev.CitesteElevi())
            {
                lvi = new ListViewItem();
                lvi.Text = elev.Nume;
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = elev.Prenume;
                lvi.SubItems.Add(lvsi);
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = elev.Nota.ToString();
                lvi.SubItems.Add(lvsi);
                listViewTest.Items.Add(lvi);
            }
            this.listViewTest.EndUpdate();
        }
    }
}
