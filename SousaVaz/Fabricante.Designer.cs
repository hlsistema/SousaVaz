namespace SousaVaz
{
    partial class Fabricante
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
            this.Tb_Fab = new System.Windows.Forms.TextBox();
            this.Bt_Fab_Cad = new System.Windows.Forms.Button();
            this.Bt_Fab_Ed = new System.Windows.Forms.Button();
            this.Bt_Fab_Pesq = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // Tb_Fab
            // 
            this.Tb_Fab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Fab.Location = new System.Drawing.Point(69, 66);
            this.Tb_Fab.MaxLength = 20;
            this.Tb_Fab.Name = "Tb_Fab";
            this.Tb_Fab.Size = new System.Drawing.Size(211, 26);
            this.Tb_Fab.TabIndex = 0;
            // 
            // Bt_Fab_Cad
            // 
            this.Bt_Fab_Cad.Location = new System.Drawing.Point(12, 107);
            this.Bt_Fab_Cad.Name = "Bt_Fab_Cad";
            this.Bt_Fab_Cad.Size = new System.Drawing.Size(92, 32);
            this.Bt_Fab_Cad.TabIndex = 3;
            this.Bt_Fab_Cad.Text = "&Cadastrar";
            this.Bt_Fab_Cad.UseVisualStyleBackColor = true;
            // 
            // Bt_Fab_Ed
            // 
            this.Bt_Fab_Ed.Location = new System.Drawing.Point(110, 107);
            this.Bt_Fab_Ed.Name = "Bt_Fab_Ed";
            this.Bt_Fab_Ed.Size = new System.Drawing.Size(75, 32);
            this.Bt_Fab_Ed.TabIndex = 4;
            this.Bt_Fab_Ed.Text = "&Editar";
            this.Bt_Fab_Ed.UseVisualStyleBackColor = true;
            // 
            // Bt_Fab_Pesq
            // 
            this.Bt_Fab_Pesq.Location = new System.Drawing.Point(191, 107);
            this.Bt_Fab_Pesq.Name = "Bt_Fab_Pesq";
            this.Bt_Fab_Pesq.Size = new System.Drawing.Size(94, 32);
            this.Bt_Fab_Pesq.TabIndex = 5;
            this.Bt_Fab_Pesq.Text = "&Pesquisar";
            this.Bt_Fab_Pesq.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Fabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 303);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bt_Fab_Pesq);
            this.Controls.Add(this.Bt_Fab_Ed);
            this.Controls.Add(this.Bt_Fab_Cad);
            this.Controls.Add(this.Tb_Fab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fabricante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta de Fabricantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Fab;
        private System.Windows.Forms.Button Bt_Fab_Cad;
        private System.Windows.Forms.Button Bt_Fab_Ed;
        private System.Windows.Forms.Button Bt_Fab_Pesq;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}