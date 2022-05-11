﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademidaDotNet_ProjetoExemplo.WindowsForms.UI
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

            if (txtContactName.Text != string.Empty)
            {
                provider.ProvidersContactName = txtContactName.Text;
            }

            if (txtFoneNumber.Text != string.Empty)
            {
                provider.ProvidersFone = txtFoneNumber.Text;
            }

            List<Providers> providersList = new List<Providers>();
            providersList.Add(provider);

            dgvProviders.DataSource = providersList;
        }
    }
}
