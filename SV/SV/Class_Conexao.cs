using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SV
{
    class Class_Conexao
    {
        // Conexão com o SQL Server
        private string connectionString = "Server=HUGO\\HUGO,1433;Database=EV;User = sa; Password=Grupo_01;";
        private readonly TextBox txtUsuario;
        private readonly TextBox txtSenha;

        // Construtor para receber os TextBoxes de usuário e senha
        public Class_Conexao(TextBox usuario, TextBox senha)
        {
            txtUsuario = usuario;
            txtSenha = senha;
        }

        // Botão SAIR
        private void Btsairacesso_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Botão ENTRAR
        private void BtEntrar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text.Trim();
            string Senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(Usuario) || string.IsNullOrEmpty(Senha))
            {
                MessageBox.Show("Preencha usuário e senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.Parameters.AddWithValue("@usuario", Usuario);
                        cmd.Parameters.AddWithValue("@senha", Senha);

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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close() => throw new NotImplementedException();
        private void Hide() => throw new NotImplementedException();
    }
}