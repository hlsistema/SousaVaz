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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        
        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void Bt_Usu_apagar_Click(object sender, EventArgs e)
        {
            txb_usu.Clear();
            txb_senha.Clear();
        }

        private void Bt_cad_us_Click(object sender, EventArgs e)
        {
            string Nome = txb_usu.Text;
            string Senha = txb_senha.Text;
            string Permissao = Combobox_Usu.Text;

            {
                //string de conexão com o mysql
                string CONFIG = ("Persist Security Info=False; Server=https://phpmyadmin.locaweb.com.br; server=grupoamaral.mysql.dbaas.com.br; Username=grupoamaral; Password=Hl47076961; database=grupoamaral");
                MySqlConnection Conexao = new MySqlConnection(CONFIG);
                MySqlCommand Query = new MySqlCommand
                {
                    Connection = Conexao
                };
                Conexao.Open();
                //string de inclusão de dados no Mysql
                Query.CommandText = "INSERT INTO USUARIO(Nome,Senha,Permissao) VALUES(@Nome, @Senha, @Permissao)";
                Query.Parameters.AddWithValue("@Nome", Nome);
                Query.Parameters.AddWithValue("@Senha", Senha);
                Query.Parameters.AddWithValue("@Permissao", Permissao);
                Query.ExecuteNonQuery();
                Query.Dispose();
                MessageBox.Show("Usuário cadastrado com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bt_Usu_apagar.PerformClick();
                Conexao.Close();
            }
        }

        private void Bt_listar_usu_Click(object sender, EventArgs e)
        {

        }
    }
}