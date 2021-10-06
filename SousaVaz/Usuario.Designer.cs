namespace SousaVaz
{
    partial class Usuario
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
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.txb_usu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bt_cad_us = new System.Windows.Forms.Button();
            this.Bt_cons_usu = new System.Windows.Forms.Button();
            this.dataGrid_usuario = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Combobox_Usu = new System.Windows.Forms.ComboBox();
            this.Bt_Usu_apagar = new System.Windows.Forms.Button();
            this.Bt_listar_usu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // txb_senha
            // 
            this.txb_senha.BackColor = System.Drawing.Color.Black;
            this.txb_senha.ForeColor = System.Drawing.Color.White;
            this.txb_senha.Location = new System.Drawing.Point(233, 60);
            this.txb_senha.MaxLength = 15;
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.PasswordChar = '*';
            this.txb_senha.Size = new System.Drawing.Size(156, 26);
            this.txb_senha.TabIndex = 2;
            this.txb_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_usu
            // 
            this.txb_usu.BackColor = System.Drawing.Color.Black;
            this.txb_usu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_usu.ForeColor = System.Drawing.Color.White;
            this.txb_usu.Location = new System.Drawing.Point(233, 28);
            this.txb_usu.MaxLength = 30;
            this.txb_usu.Name = "txb_usu";
            this.txb_usu.Size = new System.Drawing.Size(156, 26);
            this.txb_usu.TabIndex = 1;
            this.txb_usu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SousaVaz.Properties.Resources.índice00;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuário";
            // 
            // Bt_cad_us
            // 
            this.Bt_cad_us.Location = new System.Drawing.Point(289, 92);
            this.Bt_cad_us.Name = "Bt_cad_us";
            this.Bt_cad_us.Size = new System.Drawing.Size(100, 30);
            this.Bt_cad_us.TabIndex = 4;
            this.Bt_cad_us.Text = "&Cadastrar";
            this.Bt_cad_us.UseVisualStyleBackColor = true;
            this.Bt_cad_us.Click += new System.EventHandler(this.Bt_cad_us_Click);
            // 
            // Bt_cons_usu
            // 
            this.Bt_cons_usu.Location = new System.Drawing.Point(289, 124);
            this.Bt_cons_usu.Name = "Bt_cons_usu";
            this.Bt_cons_usu.Size = new System.Drawing.Size(100, 30);
            this.Bt_cons_usu.TabIndex = 5;
            this.Bt_cons_usu.Text = "C&onsultar";
            this.Bt_cons_usu.UseVisualStyleBackColor = true;
            // 
            // dataGrid_usuario
            // 
            this.dataGrid_usuario.Location = new System.Drawing.Point(5, 219);
            this.dataGrid_usuario.Name = "dataGrid_usuario";
            this.dataGrid_usuario.Size = new System.Drawing.Size(384, 62);
            this.dataGrid_usuario.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Permissão";
            // 
            // Combobox_Usu
            // 
            this.Combobox_Usu.FormattingEnabled = true;
            this.Combobox_Usu.Items.AddRange(new object[] {
            "Administrador",
            "Comprador",
            "Consulta",
            "Cotação"});
            this.Combobox_Usu.Location = new System.Drawing.Point(163, 185);
            this.Combobox_Usu.Name = "Combobox_Usu";
            this.Combobox_Usu.Size = new System.Drawing.Size(121, 28);
            this.Combobox_Usu.TabIndex = 3;
            // 
            // Bt_Usu_apagar
            // 
            this.Bt_Usu_apagar.Location = new System.Drawing.Point(290, 185);
            this.Bt_Usu_apagar.Name = "Bt_Usu_apagar";
            this.Bt_Usu_apagar.Size = new System.Drawing.Size(100, 30);
            this.Bt_Usu_apagar.TabIndex = 7;
            this.Bt_Usu_apagar.Text = "&Limpar";
            this.Bt_Usu_apagar.UseVisualStyleBackColor = true;
            this.Bt_Usu_apagar.Click += new System.EventHandler(this.Bt_Usu_apagar_Click);
            // 
            // Bt_listar_usu
            // 
            this.Bt_listar_usu.Location = new System.Drawing.Point(290, 155);
            this.Bt_listar_usu.Name = "Bt_listar_usu";
            this.Bt_listar_usu.Size = new System.Drawing.Size(100, 30);
            this.Bt_listar_usu.TabIndex = 6;
            this.Bt_listar_usu.Text = "L&istar";
            this.Bt_listar_usu.UseVisualStyleBackColor = true;
            this.Bt_listar_usu.Click += new System.EventHandler(this.Bt_listar_usu_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 288);
            this.Controls.Add(this.Bt_listar_usu);
            this.Controls.Add(this.Bt_Usu_apagar);
            this.Controls.Add(this.Combobox_Usu);
            this.Controls.Add(this.dataGrid_usuario);
            this.Controls.Add(this.Bt_cons_usu);
            this.Controls.Add(this.Bt_cad_us);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txb_senha);
            this.Controls.Add(this.txb_usu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Consulta: Usuários";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.TextBox txb_usu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bt_cad_us;
        private System.Windows.Forms.Button Bt_cons_usu;
        private System.Windows.Forms.DataGridView dataGrid_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Combobox_Usu;
        private System.Windows.Forms.Button Bt_Usu_apagar;
        private System.Windows.Forms.Button Bt_listar_usu;
    }
}