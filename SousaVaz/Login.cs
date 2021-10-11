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

namespace SousaVaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private MySqlConnection Conexao;
        

        private void Bt_Login_Entrar_click(object sender, EventArgs e)
        { 
           Conexao = new MySqlConnection("Server=https://phpmyadmin.locaweb.com.br; server=grupoamaral.mysql.dbaas.com.br; Username=grupoamaral; Password=Hl47076961; persistsecurityinfo=True; database=grupoamaral");
            //Conexao1 = new MySqlConnection("Server:Mysql@localhost:3306; Server=localhost; Userid=root; Password=132425; persistsecurityinfo=True; database=grupoamaral");
            //Conexao1 = new MySqlConnection("Server=localhost; Username=root; Password=984988; persistsecurityinfo=True; database=grupoamaral");
            try
            {

                Conexao.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM USUARIO WHERE NOME AND SENHA= '" + Tb_Login_Usuario.Text + Tb_Login_Senha.Text + "'", Conexao); ;
                MySqlCommand verifica = mySqlCommand;
                bool resultado = verifica.ExecuteReader().HasRows;

                if (resultado == true)
                {
                    Conexao.Close();
                    Principal principal = new Principal();
                    Principal frm = principal;
                    frm.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha inválido(s), por favor tente novamente!");
                    MessageBox.Show("Ou Ligue para o suporte: (21) 98448-7361");
                    Tb_Login_Usuario.Text = "";
                    Tb_Login_Senha.Text = "";
                    Conexao.Close();

                }

            }

            catch
            {
                MessageBox.Show("Erro de conexão com o banco de dados");
                Conexao.Close();
                this.Close();
            }
        }

        private void Bt_Login_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
