namespace SousaVaz
{
    partial class Validade
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
            this.Dt_Produto = new System.Windows.Forms.DataGridView();
            this.Bt_Validade_Pesq = new System.Windows.Forms.Button();
            this.Bt_Validade_Editar = new System.Windows.Forms.Button();
            this.Bt_Validade_Cad = new System.Windows.Forms.Button();
            this.Tb_Validade_Nome = new System.Windows.Forms.TextBox();
            this.Tb_Validade_Cod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_Validade_Qtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mk_Validade_Venc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Validades";
            // 
            // Dt_Produto
            // 
            this.Dt_Produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dt_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Produto.Location = new System.Drawing.Point(12, 287);
            this.Dt_Produto.Name = "Dt_Produto";
            this.Dt_Produto.Size = new System.Drawing.Size(484, 108);
            this.Dt_Produto.TabIndex = 22;
            // 
            // Bt_Validade_Pesq
            // 
            this.Bt_Validade_Pesq.Location = new System.Drawing.Point(383, 247);
            this.Bt_Validade_Pesq.Name = "Bt_Validade_Pesq";
            this.Bt_Validade_Pesq.Size = new System.Drawing.Size(113, 34);
            this.Bt_Validade_Pesq.TabIndex = 21;
            this.Bt_Validade_Pesq.Text = "&Pesquisar";
            this.Bt_Validade_Pesq.UseVisualStyleBackColor = true;
            // 
            // Bt_Validade_Editar
            // 
            this.Bt_Validade_Editar.Location = new System.Drawing.Point(206, 247);
            this.Bt_Validade_Editar.Name = "Bt_Validade_Editar";
            this.Bt_Validade_Editar.Size = new System.Drawing.Size(113, 34);
            this.Bt_Validade_Editar.TabIndex = 20;
            this.Bt_Validade_Editar.Text = "&Editar";
            this.Bt_Validade_Editar.UseVisualStyleBackColor = true;
            // 
            // Bt_Validade_Cad
            // 
            this.Bt_Validade_Cad.Location = new System.Drawing.Point(12, 247);
            this.Bt_Validade_Cad.Name = "Bt_Validade_Cad";
            this.Bt_Validade_Cad.Size = new System.Drawing.Size(113, 34);
            this.Bt_Validade_Cad.TabIndex = 3;
            this.Bt_Validade_Cad.Text = "&Cadastrar";
            this.Bt_Validade_Cad.UseVisualStyleBackColor = true;
            // 
            // Tb_Validade_Nome
            // 
            this.Tb_Validade_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Validade_Nome.Location = new System.Drawing.Point(110, 126);
            this.Tb_Validade_Nome.MaxLength = 60;
            this.Tb_Validade_Nome.Name = "Tb_Validade_Nome";
            this.Tb_Validade_Nome.Size = new System.Drawing.Size(325, 26);
            this.Tb_Validade_Nome.TabIndex = 11;
            // 
            // Tb_Validade_Cod
            // 
            this.Tb_Validade_Cod.Location = new System.Drawing.Point(110, 94);
            this.Tb_Validade_Cod.MaxLength = 14;
            this.Tb_Validade_Cod.Name = "Tb_Validade_Cod";
            this.Tb_Validade_Cod.Size = new System.Drawing.Size(157, 26);
            this.Tb_Validade_Cod.TabIndex = 0;
            this.Tb_Validade_Cod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Quantidade";
            // 
            // Tb_Validade_Qtd
            // 
            this.Tb_Validade_Qtd.Location = new System.Drawing.Point(110, 166);
            this.Tb_Validade_Qtd.MaxLength = 2;
            this.Tb_Validade_Qtd.Name = "Tb_Validade_Qtd";
            this.Tb_Validade_Qtd.Size = new System.Drawing.Size(59, 26);
            this.Tb_Validade_Qtd.TabIndex = 1;
            this.Tb_Validade_Qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Vencimento";
            // 
            // Mk_Validade_Venc
            // 
            this.Mk_Validade_Venc.Location = new System.Drawing.Point(110, 207);
            this.Mk_Validade_Venc.Mask = "99/99";
            this.Mk_Validade_Venc.Name = "Mk_Validade_Venc";
            this.Mk_Validade_Venc.Size = new System.Drawing.Size(59, 26);
            this.Mk_Validade_Venc.TabIndex = 2;
            this.Mk_Validade_Venc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Validade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 407);
            this.Controls.Add(this.Mk_Validade_Venc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_Validade_Qtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dt_Produto);
            this.Controls.Add(this.Bt_Validade_Pesq);
            this.Controls.Add(this.Bt_Validade_Editar);
            this.Controls.Add(this.Bt_Validade_Cad);
            this.Controls.Add(this.Tb_Validade_Nome);
            this.Controls.Add(this.Tb_Validade_Cod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Validade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta: Validades";
            this.Load += new System.EventHandler(this.Validade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dt_Produto;
        private System.Windows.Forms.Button Bt_Validade_Pesq;
        private System.Windows.Forms.Button Bt_Validade_Editar;
        private System.Windows.Forms.Button Bt_Validade_Cad;
        private System.Windows.Forms.TextBox Tb_Validade_Nome;
        private System.Windows.Forms.TextBox Tb_Validade_Cod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_Validade_Qtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Mk_Validade_Venc;
    }
}