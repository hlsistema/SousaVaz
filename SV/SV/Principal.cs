using System;
using System.Windows.Forms;

namespace SV
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void FinalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void LojasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa frm = new Empresa();
            frm.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto_Consulta frm = new Produto_Consulta();
            frm.Show();
        }

        private void ScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Script frm = new Script();
            frm.Show();
        }

        private void FornecedorTooltripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor frm = new Fornecedor();
            frm.Show();
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionário frm = new Funcionário();
            frm.Show();
        }

        private void UsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuário frm = new Usuário();
            frm.Show();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SV-ERP");
        }

        private void FabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fabricante frm = new Fabricante();
            frm.Show();
        }

        private void ProdutoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Produto frm = new Produto();
            frm.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargo frm = new Cargo();
            frm.Show();
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupo frm = new Grupo();
            frm.Show();
        }


        private void cancelamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancelamento frm = new Cancelamento();
            frm.Show();
        }

        private void horárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Horário frm = new Horário();
            frm.Show();
        }

        private void horárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Horário frm = new Horário();
            frm.Show();
        }
    }
}
