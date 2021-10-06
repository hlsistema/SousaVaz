using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SousaVaz
{
    public partial class Metodoconexao : Form
    {
        public Metodoconexao()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Web_Click(object sender, EventArgs e)
        {
            Aut frm = new Aut();
            frm.Show();
            Hide();
        }

        private void Bt_Local_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            Hide();
        }

        private void Metodoconexao_Load(object sender, EventArgs e)
        {

        }
    }
}
