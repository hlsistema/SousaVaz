namespace SousaVaz
{
    partial class Fornecedor
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
            this.Tb_Forn = new System.Windows.Forms.TextBox();
            this.Tb_Forn_contato = new System.Windows.Forms.TextBox();
            this.Tb_Forn_email = new System.Windows.Forms.TextBox();
            this.Bt_Forn_Cad = new System.Windows.Forms.Button();
            this.Bt_Forn_Ed = new System.Windows.Forms.Button();
            this.Bt_Forn_Forn = new System.Windows.Forms.Button();
            this.Dt_Fornecedor = new System.Windows.Forms.DataGridView();
            this.Mk_Forn_telefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Fornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone";
            // 
            // Tb_Forn
            // 
            this.Tb_Forn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Forn.Location = new System.Drawing.Point(109, 52);
            this.Tb_Forn.MaxLength = 20;
            this.Tb_Forn.Name = "Tb_Forn";
            this.Tb_Forn.Size = new System.Drawing.Size(187, 26);
            this.Tb_Forn.TabIndex = 0;
            // 
            // Tb_Forn_contato
            // 
            this.Tb_Forn_contato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Forn_contato.Location = new System.Drawing.Point(109, 84);
            this.Tb_Forn_contato.MaxLength = 10;
            this.Tb_Forn_contato.Name = "Tb_Forn_contato";
            this.Tb_Forn_contato.Size = new System.Drawing.Size(187, 26);
            this.Tb_Forn_contato.TabIndex = 1;
            // 
            // Tb_Forn_email
            // 
            this.Tb_Forn_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Forn_email.Location = new System.Drawing.Point(109, 148);
            this.Tb_Forn_email.MaxLength = 30;
            this.Tb_Forn_email.Name = "Tb_Forn_email";
            this.Tb_Forn_email.Size = new System.Drawing.Size(187, 26);
            this.Tb_Forn_email.TabIndex = 3;
            // 
            // Bt_Forn_Cad
            // 
            this.Bt_Forn_Cad.Location = new System.Drawing.Point(12, 184);
            this.Bt_Forn_Cad.Name = "Bt_Forn_Cad";
            this.Bt_Forn_Cad.Size = new System.Drawing.Size(87, 29);
            this.Bt_Forn_Cad.TabIndex = 9;
            this.Bt_Forn_Cad.Text = "&Cadastrar";
            this.Bt_Forn_Cad.UseVisualStyleBackColor = true;
            // 
            // Bt_Forn_Ed
            // 
            this.Bt_Forn_Ed.Location = new System.Drawing.Point(109, 184);
            this.Bt_Forn_Ed.Name = "Bt_Forn_Ed";
            this.Bt_Forn_Ed.Size = new System.Drawing.Size(91, 29);
            this.Bt_Forn_Ed.TabIndex = 10;
            this.Bt_Forn_Ed.Text = "&Editar";
            this.Bt_Forn_Ed.UseVisualStyleBackColor = true;
            // 
            // Bt_Forn_Forn
            // 
            this.Bt_Forn_Forn.Location = new System.Drawing.Point(206, 184);
            this.Bt_Forn_Forn.Name = "Bt_Forn_Forn";
            this.Bt_Forn_Forn.Size = new System.Drawing.Size(90, 29);
            this.Bt_Forn_Forn.TabIndex = 11;
            this.Bt_Forn_Forn.Text = "&Pesquisar";
            this.Bt_Forn_Forn.UseVisualStyleBackColor = true;
            // 
            // Dt_Fornecedor
            // 
            this.Dt_Fornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dt_Fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Fornecedor.Location = new System.Drawing.Point(12, 219);
            this.Dt_Fornecedor.Name = "Dt_Fornecedor";
            this.Dt_Fornecedor.Size = new System.Drawing.Size(284, 128);
            this.Dt_Fornecedor.TabIndex = 12;
            // 
            // Mk_Forn_telefone
            // 
            this.Mk_Forn_telefone.Location = new System.Drawing.Point(109, 116);
            this.Mk_Forn_telefone.Mask = "(00) 00000-0000";
            this.Mk_Forn_telefone.Name = "Mk_Forn_telefone";
            this.Mk_Forn_telefone.Size = new System.Drawing.Size(187, 26);
            this.Mk_Forn_telefone.TabIndex = 2;
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 359);
            this.Controls.Add(this.Mk_Forn_telefone);
            this.Controls.Add(this.Dt_Fornecedor);
            this.Controls.Add(this.Bt_Forn_Forn);
            this.Controls.Add(this.Bt_Forn_Ed);
            this.Controls.Add(this.Bt_Forn_Cad);
            this.Controls.Add(this.Tb_Forn_email);
            this.Controls.Add(this.Tb_Forn_contato);
            this.Controls.Add(this.Tb_Forn);
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
            this.Name = "Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta: Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Fornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_Forn;
        private System.Windows.Forms.TextBox Tb_Forn_contato;
        private System.Windows.Forms.TextBox Tb_Forn_email;
        private System.Windows.Forms.Button Bt_Forn_Cad;
        private System.Windows.Forms.Button Bt_Forn_Ed;
        private System.Windows.Forms.Button Bt_Forn_Forn;
        private System.Windows.Forms.DataGridView Dt_Fornecedor;
        private System.Windows.Forms.MaskedTextBox Mk_Forn_telefone;
    }
}