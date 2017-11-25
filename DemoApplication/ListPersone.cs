using System;
using System.Windows.Forms;

namespace DemoApplication
{
    public partial class ListPersone : Form
    {
        public ListPersone()
        {
            InitializeComponent();
        }

        private void ListPersone_Load(object sender, EventArgs e)
        {
            DemoApplication.Provider.PersonProvider provider = new Provider.PersonProvider();
            dataGridView1.DataSource = provider.GetLists();
        }
    }
}