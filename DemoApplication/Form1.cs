using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DemoApplication.Entity.Person item = new Entity.Person();
            item.Name = txtname.Text;
            item.Prenom = txtprenom.Text;
            item.Ville = listville.SelectedItem.ToString();

            DemoApplication.Provider.PersonProvider provider = new Provider.PersonProvider();
            provider.Add(item);
            MessageBox.Show("ce bon");

            txtname.Text = txtprenom.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListPersone list = new ListPersone();
            list.Show();
        }
    }
}