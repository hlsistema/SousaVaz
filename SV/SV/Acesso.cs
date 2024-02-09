using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SV
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void Btsairacesso_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {

            string connectionString = "server=grupoamaral.mysql.dbaas.com.br; Uid=grupoamaral; Pwd=Hl47076961; database=grupoamaral";
            string query = "SELECT * FROM USUARIO WHERE LOGIN=@LOGIN AND SENHA=@Senha";
            using (MySqlConnection conexao = new MySqlConnection(connectionString))

            {
                try
                {
                    conexao.Open();
                    MySqlCommand verifica = new MySqlCommand(query, conexao);

                    verifica.Parameters.AddWithValue("@LOGIN", txtUsuario.Text);
                    verifica.Parameters.AddWithValue("@SENHA", txtSenha.Text);
                    bool resultado = verifica.ExecuteReader().HasRows;


                    if (resultado)
                    {
                        conexao.Close();
                        Principal frm = new Principal();
                        frm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login / Senha inválido!");
                        txtUsuario.Text = "";
                        txtSenha.Text = "";
                        conexao.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão com o banco de dados: " + ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}