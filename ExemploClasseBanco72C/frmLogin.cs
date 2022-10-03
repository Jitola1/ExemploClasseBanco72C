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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            // testes de consistencia se preencheu o usuario e senha

            //preparar um sql para pesquisar o usuario por e-mail

            // se encontrou o e-mail do usuario, verificar se a senha está correta

            // se senha correta - entrar na aplicação - chamar menu

            // senão mensagem de senha incorreta e voltar para redigitar
            string sql;
            try
            {
                sql = "select * from usuario";
                sql += " where email= @1";

                List<object> param = new List<object>();
                param.Add(txtemail.Text);

                NpgsqlDataReader dr = ConexaoBanco.selecionar(sql, param);
                if (dr.Read())
                {
                    if (dr["senha"].ToString() == txtsenha.Text)
                    {
                        string nomeUsuario = dr["nome"].ToString();
                        dr.Close();
                        frmPesquisaUsuario pesq = new frmPesquisaUsuario(nomeUsuario);
                        pesq.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Senha do usuario invalida");
                        txtsenha.Focus();
                    }
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("e-mail do usuario invalido");
                    txtemail.Focus();
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocoreu um erro ao verificar o e-mail/senha do usúario" +
                                ex.Message);
                btnentrar.Focus();
            }
        }
    }
}
