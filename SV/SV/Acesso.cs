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
        private string connectionString = "Server=VAZ\\HUGO,1433;Database=EV; Trusted_Connection=true; ";

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
                return;
            }

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    string sql = "SELECT COUNT(*) FROM Usuario WHERE Usu_Login = @usuario AND Usu_Senha = @senha";
                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@usuario", Usu_Login);
                        cmd.Parameters.AddWithValue("@senha", Usu_Senha);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Abrir tela principal
                            this.Hide();
                            Principal frm = new Principal(); // substitua pelo seu form principal
                            DialogResult dialogResult = frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
