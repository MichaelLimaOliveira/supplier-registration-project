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
        public Form1()
        {
            InitializeComponent();
          
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            var provider = new Providers();

            if (txtProviderName.Text != string.Empty)
            {
                provider.ProvidersName = txtProviderName.Text;
            }

            if (txtAddres.Text != string.Empty)
            {
                provider.ProvidersAddres = txtAddres.Text;
            }

            if (txtProviderContactName.Text != string.Empty)
            {
                provider.ProvidersContactName = txtProviderContactName.Text;

            }

            if (txtProviderFoneNumber.Text != string.Empty)
            {
                provider.ProvidersFoneNumber = txtProviderFoneNumber.Text;
            }
            List<Providers> ProvidersList = new List<Providers>();
            ProvidersList.Add(provider);

            dgvProviders.DataSource = ProvidersList;

        }
    }
}
