using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static SV.MySqlConnection;
using static SV.MySqlConnection.TipoConexao;

namespace SV
{
    class Class_Conexao
    {
        public string mErro = "";


        // Variaveis de configuração de acesso ao banco de dados
        public string Server = "grupoamaral.mysql.dbaas.com.br";
        public string Usuario = "grupoamaral";
        public string Senha = "Hl47076961";
        public string Database = "grupoamaral";



        public MySqlConnection conn;

        public Class_Conexao(TipoConexao.Conexao TConexao)
        {
            GetConexao(TConexao);
        }

        internal static void Open()
        {
            throw new NotImplementedException();
        }

        public Class_Conexao()
        {
            GetConexao(TipoConexao.Conexao.Classe);
        }

        internal static void Close()
        {
            throw new NotImplementedException();
        }

        // Verifica se existe erro
        public Boolean ExisteErro()
        {
            if (mErro.Length > 0)
            {
                return true;
            }
            return false;
        }

        // Faz a Conexao com o Banco de Dados
        private void GetConexao(TipoConexao.Conexao TConexao)
        {
            try
            {
                string connectionStrings = "";
                if (TConexao == TipoConexao.Conexao.Classe)
                {
                    connectionStrings = string.Format("server={0}; usuario={1};senha={2}; database={3};Connect Timeout=28800;Command Timeout=2880", this.Server, this.Database, this.Usuario, this.Senha);
                }

                this.conn = new MySqlConnection(connectionStrings);
            }
            catch (Exception erro)
            {
                this.mErro = erro.Message;
                this.conn = null;
            }
        }

        public MySqlConnection GetConn() => conn;

        // Abre conexao com o Banco de Dados
        public Boolean OpenConexao(MySqlConnection conn)
        {
            Boolean _return = true;
            try
            {
                object value = conn.Open();
            }
            catch (Exception erro)
            {
                this.mErro = erro.Message;
                _return = false;
            }

            return _return;
        }

        // Fecha conexao com o Banco de Dados
        public void CloseConexao()
        {
            conn.Close();
            conn.Dispose();
        }
    }

    public class MySqlConnection : IDisposable
    {
        private readonly string _connectionString;
        private IDbConnection _conexao;

        public MySqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string ConnectionString => _connectionString;

        public void Open()
        {
            _conexao = new SqlConnection(_connectionString);
            _conexao.Open();
        }

        public void Close()
        {
            _conexao?.Close();
        }

        public void Dispose()
        {
            _conexao?.Dispose();
        }

        public class TipoConexao
        {
            public enum Conexao { WebConfig = 1, Classe = 2 };
        }
    }
}