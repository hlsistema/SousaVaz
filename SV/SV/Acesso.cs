using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SV
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        // Conexão com o SQL Server
        private string connectionString = "Server=HUGO\\HUGO,1433;Database=EV;User = sa; Password=Grupo_01;";


        // Botão SAIR
        private void Btsairacesso_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Botão ENTRAR
        private void BtEntrar_Click(object sender, EventArgs e)
        {
            string Usu_Login = txtUsuario.Text.Trim();
            string Usu_Senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(Usu_Login) || string.IsNullOrEmpty(Usu_Senha))
            {
                MessageBox.Show("Preencha usuário e senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    string sql = "SELECT COUNT(*) FROM Usuario WHERE Usuario = @usuario AND Senha = @senha";
                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@usuario", Usu_Login);
                        cmd.Parameters.AddWithValue("@senha", Usu_Senha);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            Principal frm = new Principal();
                            frm.ShowDialog();
                            this.Close();
                        }
                        // Abrir tela principal
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsuario.Text = "";
                            txtSenha.Text = "";
                            txtUsuario.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btsairacesso_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
