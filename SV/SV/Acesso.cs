using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SV
{
    public partial class Acesso : Form
    {
        public object TipoConexao { get; private set; }

        public Acesso()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btsairacesso_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {
                    Principal frm = new Principal();
                    frm.Show();
                    Hide();
        }
    }
}
