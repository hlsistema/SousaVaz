using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private MySqlConnection conexao;
        private DataSet conexaoDataSet;

        private void btEntrar_Click(object sender, EventArgs e)
        {

            conexaoDataSet = new DataSet();
            conexao = new MySqlConnection("server=grupoamaral.mysql.dbaas.com.br; Uid=grupoamaral; Pwd=Hl47076961; database=grupoamaral");
     
            try
            {
                conexao.Open();
                string query = "SELECT * FROM USUARIO WHERE SENHA=@Senha";
                MySqlCommand verifica = new MySqlCommand(query, conexao);
                verifica.Parameters.AddWithValue("@Senha", txtSenha.Text);

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
                    MessageBox.Show("Login inválido!");
                    txtSenha.Text = "";
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão com o banco de dados: " + ex.Message);
            }
            }

        private void Btsairacesso_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }





