using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SousaVaz
{
    public partial class Aut : Form
    {
        public Aut()
        {
            InitializeComponent();
        }

        private MySqlConnection Conexao;
        

        private void Bt_Aut_Entrar_click(object sender, EventArgs e)
        {
            //Conexao = new MySqlConnection("Server=https://phpmyadmin.locaweb.com.br; server=grupoamaral.mysql.dbaas.com.br; Username=grupoamaral; Password=Hl47076961; persistsecurityinfo=True; database=grupoamaral");
            Conexao = new MySqlConnection("Server=grupoamaral.dyndns.info:3306; service=local@localhost; Username=root; Password=; persistsecurityinfo=False; Database=grupoamaral");
            try
            {

                Conexao.Open();
                //MySqlCommand verifica = new MySqlCommand("SELECT * FROM USUARIO WHERE SENHA ='" + txb_senha_log1.Text + "'", Conexao);
                MySqlCommand verifica = new MySqlCommand("SELECT * FROM FUNCIONARIO WHERE SENHA ='" + txb_senha_log1.Text + "'", Conexao);
                bool resultado = verifica.ExecuteReader().HasRows;
                
                if (resultado == true)
                {
                    Conexao.Close();
                    Principal frm = new Principal();
                    frm.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("Login inválido!");
                    MessageBox.Show("Digite a Senha Correta!");
                    MessageBox.Show("Ou Ligue para o suporte: (21) 98448-7361");
                    txb_senha_log1.Text = "";
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

        private void Aut_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Aut_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    
