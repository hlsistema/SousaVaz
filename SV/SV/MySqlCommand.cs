using System;

namespace SV
{
    internal class MySqlCommand
    {
        private string query;
        private MySqlConnection conexao;

        public MySqlCommand(string query, MySqlConnection conexao)
        {
            this.query = query;
            this.conexao = conexao;
        }

        public object Parameters { get; internal set; }

        internal object ExecuteReader() => throw new NotImplementedException();

        public static explicit operator MySql.Data.MySqlClient.MySqlDataReader(MySqlCommand v)
        {
            throw new NotImplementedException();
        }
    }
}