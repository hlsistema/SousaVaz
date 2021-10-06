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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private MySqlConnection Conexao;
        private DataSet ConexaoDataSet1;

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void bt_limp_prod_Click(object sender, EventArgs e)
        {
            cons_prod.Text = "";
        }

        private void bt_consulta_prod_Click(object sender, EventArgs e)
        {
            ConexaoDataSet1 = new DataSet();
            Conexao = new MySqlConnection("Server=https://phpmyadmin.locaweb.com.br; server=grupoamaral.mysql.dbaas.com.br; Username=grupoamaral; Password=Hl47076961; persistsecurityinfo=True; database=grupoamaral");
            try
            {

                Conexao.Open();
                MySqlCommand verifica = new MySqlCommand("SELECT * FROM USUARIO WHERE NOME = '" + cons_prod.Text + "'", Conexao);
                bool resultado = verifica.ExecuteReader().HasRows;

                if (resultado == true)
                {
                    Conexao.Close();
                    MessageBox.Show("Conectado!");

                }
                else
                {
                    MessageBox.Show("PRODUTO NÃO ENCONTRADO!");
                    MessageBox.Show("DIGITE O NOME CORRETO!");cons_prod.Text = "";
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
    }
}
