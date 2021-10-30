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

        Conexao conexao = new Conexao(TipoConexao.Conexao.Classe);

        private void Bt_Aut_Entrar_click(object sender, EventArgs e)
        {
                string query = "SELECT * FROM USUARIO WHERE SENHA ='" + txb_senha_log1.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conexao.conn);
                cmd.CommandType = System.Data.CommandType.Text;

                if (conexao.OpenConexao() == false)
                {
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
    
