using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ExemploClasseBanco72C
{
    public partial class frmPesquisaUsuario : Form
    {
        public frmPesquisaUsuario(string nomeUsuario)
        {
            InitializeComponent();
            lblUsuario.Text = nomeUsuario;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string sql = "select * from usuario";
            sql += "  order by nome";

            dgvpesquisa.DataSource = ConexaoBanco.selecionarDataTable(sql);
        }
    }
}
