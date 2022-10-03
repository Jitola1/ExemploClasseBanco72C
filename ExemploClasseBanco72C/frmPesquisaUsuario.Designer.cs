namespace ExemploClasseBanco72C
{
    partial class frmPesquisaUsuario
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
            this.dgvpesquisa = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpesquisa
            // 
            this.dgvpesquisa.AllowUserToAddRows = false;
            this.dgvpesquisa.AllowUserToDeleteRows = false;
            this.dgvpesquisa.AllowUserToResizeRows = false;
            this.dgvpesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpesquisa.Location = new System.Drawing.Point(61, 12);
            this.dgvpesquisa.Name = "dgvpesquisa";
            this.dgvpesquisa.Size = new System.Drawing.Size(676, 332);
            this.dgvpesquisa.TabIndex = 0;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(356, 396);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(137, 23);
            this.btnpesquisar.TabIndex = 1;
            this.btnpesquisar.Text = "pesquisar usuarios";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(12, 412);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(12, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = ".";
            // 
            // frmPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.dgvpesquisa);
            this.Name = "frmPesquisaUsuario";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpesquisa;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Label lblUsuario;
    }
}

