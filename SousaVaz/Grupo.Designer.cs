namespace SousaVaz
{
    partial class Grupo
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
            this.Tb_Grupo = new System.Windows.Forms.TextBox();
            this.Bt_Grupo_Cad = new System.Windows.Forms.Button();
            this.Bt_Grupo_Editar = new System.Windows.Forms.Button();
            this.Bt_Grupo_Pesq = new System.Windows.Forms.Button();
            this.Dt_Grupo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Grupo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamento";
            // 
            // Tb_Grupo
            // 
            this.Tb_Grupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Grupo.Location = new System.Drawing.Point(130, 78);
            this.Tb_Grupo.MaxLength = 20;
            this.Tb_Grupo.Name = "Tb_Grupo";
            this.Tb_Grupo.Size = new System.Drawing.Size(187, 26);
            this.Tb_Grupo.TabIndex = 0;
            // 
            // Bt_Grupo_Cad
            // 
            this.Bt_Grupo_Cad.Location = new System.Drawing.Point(12, 120);
            this.Bt_Grupo_Cad.Name = "Bt_Grupo_Cad";
            this.Bt_Grupo_Cad.Size = new System.Drawing.Size(93, 38);
            this.Bt_Grupo_Cad.TabIndex = 1;
            this.Bt_Grupo_Cad.Text = "&Cadastrar";
            this.Bt_Grupo_Cad.UseVisualStyleBackColor = true;
            // 
            // Bt_Grupo_Editar
            // 
            this.Bt_Grupo_Editar.Location = new System.Drawing.Point(120, 120);
            this.Bt_Grupo_Editar.Name = "Bt_Grupo_Editar";
            this.Bt_Grupo_Editar.Size = new System.Drawing.Size(93, 38);
            this.Bt_Grupo_Editar.TabIndex = 4;
            this.Bt_Grupo_Editar.Text = "&Editar";
            this.Bt_Grupo_Editar.UseVisualStyleBackColor = true;
            // 
            // Bt_Grupo_Pesq
            // 
            this.Bt_Grupo_Pesq.Location = new System.Drawing.Point(224, 120);
            this.Bt_Grupo_Pesq.Name = "Bt_Grupo_Pesq";
            this.Bt_Grupo_Pesq.Size = new System.Drawing.Size(93, 38);
            this.Bt_Grupo_Pesq.TabIndex = 5;
            this.Bt_Grupo_Pesq.Text = "&Pesquisar";
            this.Bt_Grupo_Pesq.UseVisualStyleBackColor = true;
            // 
            // Dt_Grupo
            // 
            this.Dt_Grupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dt_Grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Grupo.Location = new System.Drawing.Point(12, 164);
            this.Dt_Grupo.Name = "Dt_Grupo";
            this.Dt_Grupo.Size = new System.Drawing.Size(305, 162);
            this.Dt_Grupo.TabIndex = 6;
            // 
            // Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 338);
            this.Controls.Add(this.Dt_Grupo);
            this.Controls.Add(this.Bt_Grupo_Pesq);
            this.Controls.Add(this.Bt_Grupo_Editar);
            this.Controls.Add(this.Bt_Grupo_Cad);
            this.Controls.Add(this.Tb_Grupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta: Departamento";
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Grupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Grupo;
        private System.Windows.Forms.Button Bt_Grupo_Cad;
        private System.Windows.Forms.Button Bt_Grupo_Editar;
        private System.Windows.Forms.Button Bt_Grupo_Pesq;
        private System.Windows.Forms.DataGridView Dt_Grupo;
    }
}