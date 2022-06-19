using System;
using MySql.Data.MySqlClient;

namespace SousaVaz
{
    public class Conexao
    {

        public string mErro = "";

        
        // Variaveis de configuração de acesso ao banco de dados
        public string Server = "https://phpmyadmin.locaweb.com.br";
        public string Server1 = "grupoamaral.mysql.dbaas.com.br";
        public string Database = "grupoamaral";
        public string Usuario = "grupoamaral";
        public string Senha = "Hl47076961";


        public MySqlConnection conn;

        public Conexao(TipoConexao.Conexao TConexao)
        {
            GetConexao(TConexao);
        }

        internal static void Open()
        {
            throw new NotImplementedException();
        }

        public Conexao()
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
                    connectionStrings = string.Format("server={0}; server1={1}; user id={2};pwd='{3}';database={1};Connect Timeout=28800;Command Timeout=2880", this.Server, this.Server1, this.Database, this.Usuario, this.Senha);
                }
               
                this.conn = new MySqlConnection(connectionStrings);
            }
            catch (Exception erro)
            {
                this.mErro = erro.Message;
                this.conn = null;
            }
        }

        // Abre conexao com o Banco de Dados
        public Boolean OpenConexao()
        {
            Boolean _return = true;
            try
            {
                conn.Open();
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

    /// <summary>
    /// Definição de tipos de Conexão 
    /// </summary>
    public class TipoConexao
    {
        public enum Conexao { WebConfig = 1, Classe = 2 };
    }
}