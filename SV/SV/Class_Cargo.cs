using System;
using System.Data;
using System.Data.SqlClient;


public class Cargo
{
    public int Id { get; set; }
    public string Nome { get; set; }

    //private string connectionString = "Data Source=SEU_SERVIDOR;Initial Catalog=SEU_BANCO;Integrated Security=True";
    private string connectionString = "Server=HUGO\\HUGO,1433;Database=EV;User = sa; Password=Grupo_01;";

    // Método para incluir
    public void Incluir()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string sql = "INSERT INTO Cargo (Nome) VALUES (@Nome)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", Nome);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Método para alterar
    public void Alterar()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string sql = "UPDATE Cargo SET Nome = @Nome WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Id", Id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    // Método para excluir
    public void Excluir()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string sql = "DELETE FROM Cargo WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", Id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
