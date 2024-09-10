using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace SV
{
    internal class Class_Cargo
    {
        string Cargo;

        public string cargo
        {
            get { return Cargo; }
            set { Cargo = value; }
        }

    }
}
