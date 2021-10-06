namespace SousaVaz
{
    partial class Produto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_Prod_Cod = new System.Windows.Forms.TextBox();
            this.Tb_Prod_Nome = new System.Windows.Forms.TextBox();
            this.Cb_Prod_Grupo = new System.Windows.Forms.ComboBox();
            this.Cb_Prod_Fabricante = new System.Windows.Forms.ComboBox();
            this.Bt_Prod_Cad = new System.Windows.Forms.Button();
            this.Bt_Prod_Editar = new System.Windows.Forms.Button();
            this.Bt_Prod_Pesq = new System.Windows.Forms.Button();
            this.Dt_Produto = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Cb_Prod_Acao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grupo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fabricante";
            // 
            // Tb_Prod_Cod
            // 
            this.Tb_Prod_Cod.Location = new System.Drawing.Point(142, 62);
            this.Tb_Prod_Cod.MaxLength = 8;
            this.Tb_Prod_Cod.Name = "Tb_Prod_Cod";
            this.Tb_Prod_Cod.Size = new System.Drawing.Size(91, 26);
            this.Tb_Prod_Cod.TabIndex = 0;
            // 
            // Tb_Prod_Nome
            // 
            this.Tb_Prod_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Prod_Nome.Location = new System.Drawing.Point(142, 94);
            this.Tb_Prod_Nome.MaxLength = 60;
            this.Tb_Prod_Nome.Name = "Tb_Prod_Nome";
            this.Tb_Prod_Nome.Size = new System.Drawing.Size(354, 26);
            this.Tb_Prod_Nome.TabIndex = 1;
            // 
            // Cb_Prod_Grupo
            // 
            this.Cb_Prod_Grupo.FormattingEnabled = true;
            this.Cb_Prod_Grupo.Location = new System.Drawing.Point(142, 126);
            this.Cb_Prod_Grupo.Name = "Cb_Prod_Grupo";
            this.Cb_Prod_Grupo.Size = new System.Drawing.Size(147, 28);
            this.Cb_Prod_Grupo.TabIndex = 2;
            // 
            // Cb_Prod_Fabricante
            // 
            this.Cb_Prod_Fabricante.FormattingEnabled = true;
            this.Cb_Prod_Fabricante.Location = new System.Drawing.Point(142, 194);
            this.Cb_Prod_Fabricante.Name = "Cb_Prod_Fabricante";
            this.Cb_Prod_Fabricante.Size = new System.Drawing.Size(147, 28);
            this.Cb_Prod_Fabricante.TabIndex = 4;
            // 
            // Bt_Prod_Cad
            // 
            this.Bt_Prod_Cad.Location = new System.Drawing.Point(12, 247);
            this.Bt_Prod_Cad.Name = "Bt_Prod_Cad";
            this.Bt_Prod_Cad.Size = new System.Drawing.Size(113, 34);
            this.Bt_Prod_Cad.TabIndex = 5;
            this.Bt_Prod_Cad.Text = "&Cadastrar";
            this.Bt_Prod_Cad.UseVisualStyleBackColor = true;
            // 
            // Bt_Prod_Editar
            // 
            this.Bt_Prod_Editar.Location = new System.Drawing.Point(206, 247);
            this.Bt_Prod_Editar.Name = "Bt_Prod_Editar";
            this.Bt_Prod_Editar.Size = new System.Drawing.Size(113, 34);
            this.Bt_Prod_Editar.TabIndex = 6;
            this.Bt_Prod_Editar.Text = "&Editar";
            this.Bt_Prod_Editar.UseVisualStyleBackColor = true;
            // 
            // Bt_Prod_Pesq
            // 
            this.Bt_Prod_Pesq.Location = new System.Drawing.Point(383, 247);
            this.Bt_Prod_Pesq.Name = "Bt_Prod_Pesq";
            this.Bt_Prod_Pesq.Size = new System.Drawing.Size(113, 34);
            this.Bt_Prod_Pesq.TabIndex = 7;
            this.Bt_Prod_Pesq.Text = "&Pesquisar";
            this.Bt_Prod_Pesq.UseVisualStyleBackColor = true;
            // 
            // Dt_Produto
            // 
            this.Dt_Produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dt_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Produto.Location = new System.Drawing.Point(12, 287);
            this.Dt_Produto.Name = "Dt_Produto";
            this.Dt_Produto.Size = new System.Drawing.Size(484, 108);
            this.Dt_Produto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Grupo de Ação";
            // 
            // Cb_Prod_Acao
            // 
            this.Cb_Prod_Acao.FormattingEnabled = true;
            this.Cb_Prod_Acao.Location = new System.Drawing.Point(142, 160);
            this.Cb_Prod_Acao.Name = "Cb_Prod_Acao";
            this.Cb_Prod_Acao.Size = new System.Drawing.Size(147, 28);
            this.Cb_Prod_Acao.TabIndex = 3;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 407);
            this.Controls.Add(this.Cb_Prod_Acao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dt_Produto);
            this.Controls.Add(this.Bt_Prod_Pesq);
            this.Controls.Add(this.Bt_Prod_Editar);
            this.Controls.Add(this.Bt_Prod_Cad);
            this.Controls.Add(this.Cb_Prod_Fabricante);
            this.Controls.Add(this.Cb_Prod_Grupo);
            this.Controls.Add(this.Tb_Prod_Nome);
            this.Controls.Add(this.Tb_Prod_Cod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta: Produtos";
            this.Load += new System.EventHandler(this.Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_Prod_Cod;
        private System.Windows.Forms.TextBox Tb_Prod_Nome;
        private System.Windows.Forms.ComboBox Cb_Prod_Grupo;
        private System.Windows.Forms.ComboBox Cb_Prod_Fabricante;
        private System.Windows.Forms.Button Bt_Prod_Cad;
        private System.Windows.Forms.Button Bt_Prod_Editar;
        private System.Windows.Forms.Button Bt_Prod_Pesq;
        private System.Windows.Forms.DataGridView Dt_Produto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cb_Prod_Acao;
    }
}