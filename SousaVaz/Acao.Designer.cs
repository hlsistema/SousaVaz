namespace SousaVaz
{
    partial class Acao
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
            this.Tb_Acao = new System.Windows.Forms.TextBox();
            this.Bt_Acao_Cad = new System.Windows.Forms.Button();
            this.Bt_Acao_Ed = new System.Windows.Forms.Button();
            this.Bt_Acao_Pesq = new System.Windows.Forms.Button();
            this.Dt_Acao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Acao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo de Ação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ação";
            // 
            // Tb_Acao
            // 
            this.Tb_Acao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Acao.Location = new System.Drawing.Point(74, 82);
            this.Tb_Acao.MaxLength = 20;
            this.Tb_Acao.Name = "Tb_Acao";
            this.Tb_Acao.Size = new System.Drawing.Size(243, 26);
            this.Tb_Acao.TabIndex = 0;
            // 
            // Bt_Acao_Cad
            // 
            this.Bt_Acao_Cad.Location = new System.Drawing.Point(12, 126);
            this.Bt_Acao_Cad.Name = "Bt_Acao_Cad";
            this.Bt_Acao_Cad.Size = new System.Drawing.Size(95, 35);
            this.Bt_Acao_Cad.TabIndex = 1;
            this.Bt_Acao_Cad.Text = "&Cadastrar";
            this.Bt_Acao_Cad.UseVisualStyleBackColor = true;
            // 
            // Bt_Acao_Ed
            // 
            this.Bt_Acao_Ed.Location = new System.Drawing.Point(114, 126);
            this.Bt_Acao_Ed.Name = "Bt_Acao_Ed";
            this.Bt_Acao_Ed.Size = new System.Drawing.Size(101, 35);
            this.Bt_Acao_Ed.TabIndex = 2;
            this.Bt_Acao_Ed.Text = "&Editar";
            this.Bt_Acao_Ed.UseVisualStyleBackColor = true;
            // 
            // Bt_Acao_Pesq
            // 
            this.Bt_Acao_Pesq.Location = new System.Drawing.Point(221, 126);
            this.Bt_Acao_Pesq.Name = "Bt_Acao_Pesq";
            this.Bt_Acao_Pesq.Size = new System.Drawing.Size(96, 35);
            this.Bt_Acao_Pesq.TabIndex = 3;
            this.Bt_Acao_Pesq.Text = "&Pesquisar";
            this.Bt_Acao_Pesq.UseVisualStyleBackColor = true;
            // 
            // Dt_Acao
            // 
            this.Dt_Acao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Acao.Location = new System.Drawing.Point(12, 167);
            this.Dt_Acao.Name = "Dt_Acao";
            this.Dt_Acao.Size = new System.Drawing.Size(305, 83);
            this.Dt_Acao.TabIndex = 6;
            // 
            // Acao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 262);
            this.Controls.Add(this.Dt_Acao);
            this.Controls.Add(this.Bt_Acao_Pesq);
            this.Controls.Add(this.Bt_Acao_Ed);
            this.Controls.Add(this.Bt_Acao_Cad);
            this.Controls.Add(this.Tb_Acao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Acao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta: Grupo de Ação";
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Acao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Acao;
        private System.Windows.Forms.Button Bt_Acao_Cad;
        private System.Windows.Forms.Button Bt_Acao_Ed;
        private System.Windows.Forms.Button Bt_Acao_Pesq;
        private System.Windows.Forms.DataGridView Dt_Acao;
    }
}