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
    public partial class web : Form
    {
        public web()
        {
            InitializeComponent();
        }

        private void Bt_atualizar_web_Click(object sender, EventArgs e)
        {
            string Nome = txtbox_web.Text;

            {
                //string de conexão com o mysql
                string CONFIG = ("Persist Security Info=False; Server=https://phpmyadmin.locaweb.com.br; server=grupoamaral.mysql.dbaas.com.br; Username=grupoamaral; Password=Hl47076961; database=grupoamaral");
                MySqlConnection Conexao = new MySqlConnection(CONFIG);
                MySqlCommand Query = new MySqlCommand();
                Query.Connection = Conexao;
                Conexao.Open();
                //string de inclusão de dados no Mysql
                Query.CommandText = "INSERT INTO USUARIO(Nome,Senha,Permissao) VALUES(@Nome, @Senha, @Permissao)";
                Query.Parameters.AddWithValue("@Nome", Nome);
                Query.ExecuteNonQuery();
                Query.Dispose();
                MessageBox.Show("SQL gerado com sucesso.", "SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bt_web_limp.PerformClick();
                Conexao.Close();
            }
        }

        private void At_atualizar_web_Click(object sender, EventArgs e)
        {

        }

        private void Bt_web_limp_Click(object sender, EventArgs e)
        {
            txtbox_web.Clear();
         }
    }
}
