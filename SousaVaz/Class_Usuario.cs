using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SousaVaz
{
    class Class_Usuario
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Permissao { get; set; }

    }
}
