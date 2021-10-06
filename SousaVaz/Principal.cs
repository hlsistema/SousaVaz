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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta frm = new Consulta();
            frm.Show();
        }

        private void UsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario frm = new Usuario();
            frm.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void FabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fabricante frm = new Fabricante();
            frm.Show();
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor frm = new Fornecedor();
            frm.Show();
        }

        private void GrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupo frm = new Grupo();
            frm.Show();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto frm = new Produto();
            frm.Show();
        }

        private void AçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acao frm = new Acao();
            frm.Show();
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void CadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Validade frm = new Validade();
            frm.Show();
        }

        private void LojasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loja frm = new Loja();
            frm.Show();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preco frm = new Preco();
            frm.Show();
        }

        private void PermissõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permissao frm = new Permissao();
            frm.Show();
        }

        private void WebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web frm = new web();
            frm.Show();
        }
    }
}
