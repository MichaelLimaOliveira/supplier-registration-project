using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvidersRegistration.UI
{
    public partial class Form1 : Form
    {
        public List<Providers> ProvidersList;
        public Form1()
        {
            InitializeComponent();
            ProvidersList = new List<Providers>();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var provider = ReturnProvider();
                ProvidersList.Add(provider);
                DataTable table = ProvidersList.ToDataTable();
                dgvProviders.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Providers ReturnProvider()
        {
            var provider = new Providers();
            bool isEntradaInvalida = txtProviderName.Text == string.Empty ||
                                     txtAddres.Text == string.Empty ||
                                     txtProviderContactName.Text == string.Empty ||
                                     txtProviderFoneNumber.Text == string.Empty;

            if (isEntradaInvalida)
            {
                throw new Exception("Entrada inválida!");
            }

            provider.ProvidersName = txtProviderName.Text;
            provider.ProvidersAddres = txtAddres.Text;
            provider.ProvidersContactName = txtProviderContactName.Text;
            provider.ProvidersFoneNumber = txtProviderFoneNumber.Text;

            return provider;
        }
    }
}
