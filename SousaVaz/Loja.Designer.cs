namespace SousaVaz
{
    partial class Loja
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bt_Loja_Pesq = new System.Windows.Forms.Button();
            this.Bt_Loja_Ed = new System.Windows.Forms.Button();
            this.Bt_Loja_Cad = new System.Windows.Forms.Button();
            this.Tb_Loja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // Bt_Loja_Pesq
            // 
            this.Bt_Loja_Pesq.Location = new System.Drawing.Point(191, 102);
            this.Bt_Loja_Pesq.Name = "Bt_Loja_Pesq";
            this.Bt_Loja_Pesq.Size = new System.Drawing.Size(94, 32);
            this.Bt_Loja_Pesq.TabIndex = 12;
            this.Bt_Loja_Pesq.Text = "&Pesquisar";
            this.Bt_Loja_Pesq.UseVisualStyleBackColor = true;
            // 
            // Bt_Loja_Ed
            // 
            this.Bt_Loja_Ed.Location = new System.Drawing.Point(110, 102);
            this.Bt_Loja_Ed.Name = "Bt_Loja_Ed";
            this.Bt_Loja_Ed.Size = new System.Drawing.Size(75, 32);
            this.Bt_Loja_Ed.TabIndex = 11;
            this.Bt_Loja_Ed.Text = "&Editar";
            this.Bt_Loja_Ed.UseVisualStyleBackColor = true;
            // 
            // Bt_Loja_Cad
            // 
            this.Bt_Loja_Cad.Location = new System.Drawing.Point(12, 102);
            this.Bt_Loja_Cad.Name = "Bt_Loja_Cad";
            this.Bt_Loja_Cad.Size = new System.Drawing.Size(92, 32);
            this.Bt_Loja_Cad.TabIndex = 1;
            this.Bt_Loja_Cad.Text = "&Cadastrar";
            this.Bt_Loja_Cad.UseVisualStyleBackColor = true;
            // 
            // Tb_Loja
            // 
            this.Tb_Loja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Loja.Location = new System.Drawing.Point(69, 61);
            this.Tb_Loja.MaxLength = 20;
            this.Tb_Loja.Name = "Tb_Loja";
            this.Tb_Loja.Size = new System.Drawing.Size(211, 26);
            this.Tb_Loja.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lojas";
            // 
            // Loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 303);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bt_Loja_Pesq);
            this.Controls.Add(this.Bt_Loja_Ed);
            this.Controls.Add(this.Bt_Loja_Cad);
            this.Controls.Add(this.Tb_Loja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta de Loja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bt_Loja_Pesq;
        private System.Windows.Forms.Button Bt_Loja_Ed;
        private System.Windows.Forms.Button Bt_Loja_Cad;
        private System.Windows.Forms.TextBox Tb_Loja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}