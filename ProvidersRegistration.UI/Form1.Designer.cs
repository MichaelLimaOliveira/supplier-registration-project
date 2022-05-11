namespace ProvidersRegistration.UI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProviderName = new System.Windows.Forms.Label();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.lblAddres = new System.Windows.Forms.Label();
            this.txtAddres = new System.Windows.Forms.TextBox();
            this.lblProviderContactName = new System.Windows.Forms.Label();
            this.txtProviderContactName = new System.Windows.Forms.TextBox();
            this.lblProviderFoneNumber = new System.Windows.Forms.Label();
            this.txtProviderFoneNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProviderName
            // 
            this.lblProviderName.AutoSize = true;
            this.lblProviderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProviderName.Location = new System.Drawing.Point(12, 9);
            this.lblProviderName.Name = "lblProviderName";
            this.lblProviderName.Size = new System.Drawing.Size(125, 13);
            this.lblProviderName.TabIndex = 0;
            this.lblProviderName.Text = "Nome do Fornecedor";
            // 
            // txtProviderName
            // 
            this.txtProviderName.Location = new System.Drawing.Point(15, 26);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(236, 20);
            this.txtProviderName.TabIndex = 1;
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddres.Location = new System.Drawing.Point(12, 59);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(61, 13);
            this.lblAddres.TabIndex = 0;
            this.lblAddres.Text = "Endereço";
            // 
            // txtAddres
            // 
            this.txtAddres.Location = new System.Drawing.Point(15, 76);
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(301, 20);
            this.txtAddres.TabIndex = 1;
            // 
            // lblProviderContactName
            // 
            this.lblProviderContactName.AutoSize = true;
            this.lblProviderContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProviderContactName.Location = new System.Drawing.Point(12, 109);
            this.lblProviderContactName.Name = "lblProviderContactName";
            this.lblProviderContactName.Size = new System.Drawing.Size(105, 13);
            this.lblProviderContactName.TabIndex = 0;
            this.lblProviderContactName.Text = "Nome do Contato";
            // 
            // txtProviderContactName
            // 
            this.txtProviderContactName.Location = new System.Drawing.Point(15, 126);
            this.txtProviderContactName.Name = "txtProviderContactName";
            this.txtProviderContactName.Size = new System.Drawing.Size(236, 20);
            this.txtProviderContactName.TabIndex = 1;
            // 
            // lblProviderFoneNumber
            // 
            this.lblProviderFoneNumber.AutoSize = true;
            this.lblProviderFoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProviderFoneNumber.Location = new System.Drawing.Point(12, 160);
            this.lblProviderFoneNumber.Name = "lblProviderFoneNumber";
            this.lblProviderFoneNumber.Size = new System.Drawing.Size(57, 13);
            this.lblProviderFoneNumber.TabIndex = 0;
            this.lblProviderFoneNumber.Text = "Telefone";
            // 
            // txtProviderFoneNumber
            // 
            this.txtProviderFoneNumber.Location = new System.Drawing.Point(15, 177);
            this.txtProviderFoneNumber.Name = "txtProviderFoneNumber";
            this.txtProviderFoneNumber.Size = new System.Drawing.Size(167, 20);
            this.txtProviderFoneNumber.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 68);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvProviders
            // 
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviders.Location = new System.Drawing.Point(15, 358);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.Size = new System.Drawing.Size(773, 289);
            this.dgvProviders.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.dgvProviders);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProviderFoneNumber);
            this.Controls.Add(this.txtProviderContactName);
            this.Controls.Add(this.txtAddres);
            this.Controls.Add(this.txtProviderName);
            this.Controls.Add(this.lblProviderFoneNumber);
            this.Controls.Add(this.lblProviderContactName);
            this.Controls.Add(this.lblAddres);
            this.Controls.Add(this.lblProviderName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Label lblAddres;
        private System.Windows.Forms.TextBox txtAddres;
        private System.Windows.Forms.Label lblProviderContactName;
        private System.Windows.Forms.TextBox txtProviderContactName;
        private System.Windows.Forms.Label lblProviderFoneNumber;
        private System.Windows.Forms.TextBox txtProviderFoneNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvProviders;
    }
}

