namespace AcademidaDotNet_ProjetoExemplo.WindowsForms.UI
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
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblFoneNumber = new System.Windows.Forms.Label();
            this.txtFoneNumber = new System.Windows.Forms.TextBox();
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
            this.txtProviderName.Location = new System.Drawing.Point(15, 25);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(261, 20);
            this.txtProviderName.TabIndex = 1;
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddres.Location = new System.Drawing.Point(12, 57);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(61, 13);
            this.lblAddres.TabIndex = 0;
            this.lblAddres.Text = "Endereço";
            // 
            // txtAddres
            // 
            this.txtAddres.Location = new System.Drawing.Point(15, 73);
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(389, 20);
            this.txtAddres.TabIndex = 1;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.Location = new System.Drawing.Point(12, 105);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(105, 13);
            this.lblContactName.TabIndex = 0;
            this.lblContactName.Text = "Nome do Contato";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(15, 121);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(261, 20);
            this.txtContactName.TabIndex = 1;
            // 
            // lblFoneNumber
            // 
            this.lblFoneNumber.AutoSize = true;
            this.lblFoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoneNumber.Location = new System.Drawing.Point(12, 153);
            this.lblFoneNumber.Name = "lblFoneNumber";
            this.lblFoneNumber.Size = new System.Drawing.Size(57, 13);
            this.lblFoneNumber.TabIndex = 0;
            this.lblFoneNumber.Text = "Telefone";
            // 
            // txtFoneNumber
            // 
            this.txtFoneNumber.Location = new System.Drawing.Point(15, 169);
            this.txtFoneNumber.Name = "txtFoneNumber";
            this.txtFoneNumber.Size = new System.Drawing.Size(148, 20);
            this.txtFoneNumber.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFoneNumber);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.txtAddres);
            this.Controls.Add(this.txtProviderName);
            this.Controls.Add(this.lblFoneNumber);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.lblAddres);
            this.Controls.Add(this.lblProviderName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Label lblAddres;
        private System.Windows.Forms.TextBox txtAddres;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label lblFoneNumber;
        private System.Windows.Forms.TextBox txtFoneNumber;
    }
}

