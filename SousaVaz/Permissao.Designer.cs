
namespace SousaVaz
{
    partial class Permissao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.check_admin = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check_compra = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.check_consulta = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.check_cotacao = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permissões do Sistema";
            // 
            // check_admin
            // 
            this.check_admin.FormattingEnabled = true;
            this.check_admin.Items.AddRange(new object[] {
            "Total"});
            this.check_admin.Location = new System.Drawing.Point(12, 71);
            this.check_admin.Name = "check_admin";
            this.check_admin.Size = new System.Drawing.Size(240, 25);
            this.check_admin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Administrador";
            // 
            // check_compra
            // 
            this.check_compra.FormattingEnabled = true;
            this.check_compra.Items.AddRange(new object[] {
            "Compras",
            "Consulta",
            "Cotação",
            "Total"});
            this.check_compra.Location = new System.Drawing.Point(12, 132);
            this.check_compra.Name = "check_compra";
            this.check_compra.Size = new System.Drawing.Size(240, 88);
            this.check_compra.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Compras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Consulta";
            // 
            // check_consulta
            // 
            this.check_consulta.FormattingEnabled = true;
            this.check_consulta.Items.AddRange(new object[] {
            "Compras",
            "Consulta",
            "Cotação",
            "Total"});
            this.check_consulta.Location = new System.Drawing.Point(16, 252);
            this.check_consulta.Name = "check_consulta";
            this.check_consulta.Size = new System.Drawing.Size(240, 88);
            this.check_consulta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cotação";
            // 
            // check_cotacao
            // 
            this.check_cotacao.FormattingEnabled = true;
            this.check_cotacao.Items.AddRange(new object[] {
            "Compras",
            "Consulta",
            "Cotação",
            "Total"});
            this.check_cotacao.Location = new System.Drawing.Point(16, 373);
            this.check_cotacao.Name = "check_cotacao";
            this.check_cotacao.Size = new System.Drawing.Size(240, 88);
            this.check_cotacao.TabIndex = 7;
            // 
            // Permissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 473);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.check_cotacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.check_consulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.check_compra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check_admin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Permissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Permissões";
            this.Load += new System.EventHandler(this.Permissao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox check_admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox check_compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox check_consulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox check_cotacao;
    }
}