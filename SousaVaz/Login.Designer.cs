namespace SousaVaz
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_Login_Usuario = new System.Windows.Forms.TextBox();
            this.Tb_Login_Senha = new System.Windows.Forms.TextBox();
            this.Bt_Login_Entrar = new System.Windows.Forms.Button();
            this.Bt_Login_Sair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Cb_Login_Loja = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SousaVaz.Properties.Resources.índice;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso ao Consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // Tb_Login_Usuario
            // 
            this.Tb_Login_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Login_Usuario.Location = new System.Drawing.Point(234, 75);
            this.Tb_Login_Usuario.MaxLength = 30;
            this.Tb_Login_Usuario.Name = "Tb_Login_Usuario";
            this.Tb_Login_Usuario.Size = new System.Drawing.Size(121, 22);
            this.Tb_Login_Usuario.TabIndex = 1;
            this.Tb_Login_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tb_Login_Senha
            // 
            this.Tb_Login_Senha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Tb_Login_Senha.Location = new System.Drawing.Point(234, 103);
            this.Tb_Login_Senha.MaxLength = 15;
            this.Tb_Login_Senha.Name = "Tb_Login_Senha";
            this.Tb_Login_Senha.PasswordChar = '*';
            this.Tb_Login_Senha.Size = new System.Drawing.Size(121, 22);
            this.Tb_Login_Senha.TabIndex = 2;
            this.Tb_Login_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bt_Login_Entrar
            // 
            this.Bt_Login_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Login_Entrar.Location = new System.Drawing.Point(176, 131);
            this.Bt_Login_Entrar.Name = "Bt_Login_Entrar";
            this.Bt_Login_Entrar.Size = new System.Drawing.Size(81, 23);
            this.Bt_Login_Entrar.TabIndex = 3;
            this.Bt_Login_Entrar.Text = "&ENTRAR";
            this.Bt_Login_Entrar.UseVisualStyleBackColor = true;
            this.Bt_Login_Entrar.Click += new System.EventHandler(this.Bt_Login_Entrar_click);
            // 
            // Bt_Login_Sair
            // 
            this.Bt_Login_Sair.Location = new System.Drawing.Point(277, 131);
            this.Bt_Login_Sair.Name = "Bt_Login_Sair";
            this.Bt_Login_Sair.Size = new System.Drawing.Size(78, 23);
            this.Bt_Login_Sair.TabIndex = 4;
            this.Bt_Login_Sair.Text = "&SAIR";
            this.Bt_Login_Sair.UseVisualStyleBackColor = true;
            this.Bt_Login_Sair.Click += new System.EventHandler(this.Bt_Login_Sair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loja";
            this.label4.Visible = false;
            // 
            // Cb_Login_Loja
            // 
            this.Cb_Login_Loja.FormattingEnabled = true;
            this.Cb_Login_Loja.Items.AddRange(new object[] {
            "Ducao",
            "FXT",
            "Nestral",
            "Nutriamaral",
            "Nutricascais",
            "Nutricosteira",
            "Nutrimaua",
            "Vira Lata"});
            this.Cb_Login_Loja.Location = new System.Drawing.Point(234, 45);
            this.Cb_Login_Loja.Name = "Cb_Login_Loja";
            this.Cb_Login_Loja.Size = new System.Drawing.Size(121, 24);
            this.Cb_Login_Loja.TabIndex = 0;
            this.Cb_Login_Loja.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 162);
            this.ControlBox = false;
            this.Controls.Add(this.Cb_Login_Loja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bt_Login_Sair);
            this.Controls.Add(this.Bt_Login_Entrar);
            this.Controls.Add(this.Tb_Login_Senha);
            this.Controls.Add(this.Tb_Login_Usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_Login_Usuario;
        private System.Windows.Forms.TextBox Tb_Login_Senha;
        private System.Windows.Forms.Button Bt_Login_Entrar;
        private System.Windows.Forms.Button Bt_Login_Sair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cb_Login_Loja;
    }
}