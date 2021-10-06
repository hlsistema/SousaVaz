namespace SousaVaz
{
    partial class Aut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aut));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.bt_sair2 = new System.Windows.Forms.Button();
            this.txb_senha_log2 = new System.Windows.Forms.TextBox();
            this.txb_usu_log2 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.bt_sair1 = new System.Windows.Forms.Button();
            this.txb_senha_log1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bt_Aut_Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(259, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Acesso 77";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(12, 12);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(151, 151);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // bt_sair2
            // 
            this.bt_sair2.Location = new System.Drawing.Point(169, 132);
            this.bt_sair2.Name = "bt_sair2";
            this.bt_sair2.Size = new System.Drawing.Size(75, 31);
            this.bt_sair2.TabIndex = 12;
            this.bt_sair2.Text = "&Sair";
            this.bt_sair2.UseVisualStyleBackColor = true;
            // 
            // txb_senha_log2
            // 
            this.txb_senha_log2.BackColor = System.Drawing.Color.Black;
            this.txb_senha_log2.ForeColor = System.Drawing.Color.White;
            this.txb_senha_log2.Location = new System.Drawing.Point(235, 91);
            this.txb_senha_log2.MaxLength = 10;
            this.txb_senha_log2.Name = "txb_senha_log2";
            this.txb_senha_log2.PasswordChar = '@';
            this.txb_senha_log2.Size = new System.Drawing.Size(158, 20);
            this.txb_senha_log2.TabIndex = 8;
            this.txb_senha_log2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_usu_log2
            // 
            this.txb_usu_log2.BackColor = System.Drawing.Color.Black;
            this.txb_usu_log2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_usu_log2.ForeColor = System.Drawing.Color.White;
            this.txb_usu_log2.Location = new System.Drawing.Point(235, 44);
            this.txb_usu_log2.MaxLength = 10;
            this.txb_usu_log2.Name = "txb_usu_log2";
            this.txb_usu_log2.Size = new System.Drawing.Size(158, 20);
            this.txb_usu_log2.TabIndex = 7;
            this.txb_usu_log2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label33.Location = new System.Drawing.Point(165, 94);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(56, 20);
            this.label33.TabIndex = 11;
            this.label33.Text = "Senha";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label22.Location = new System.Drawing.Point(165, 47);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 20);
            this.label22.TabIndex = 9;
            this.label22.Text = "Usuário";
            // 
            // bt_sair1
            // 
            this.bt_sair1.Location = new System.Drawing.Point(116, 83);
            this.bt_sair1.Name = "bt_sair1";
            this.bt_sair1.Size = new System.Drawing.Size(70, 31);
            this.bt_sair1.TabIndex = 1;
            this.bt_sair1.Text = "&Entrar";
            this.bt_sair1.UseVisualStyleBackColor = true;
            this.bt_sair1.Click += new System.EventHandler(this.Bt_Aut_Entrar_click);
            // 
            // txb_senha_log1
            // 
            this.txb_senha_log1.BackColor = System.Drawing.Color.Black;
            this.txb_senha_log1.ForeColor = System.Drawing.Color.White;
            this.txb_senha_log1.Location = new System.Drawing.Point(178, 41);
            this.txb_senha_log1.MaxLength = 12;
            this.txb_senha_log1.Name = "txb_senha_log1";
            this.txb_senha_log1.PasswordChar = '#';
            this.txb_senha_log1.Size = new System.Drawing.Size(130, 26);
            this.txb_senha_log1.TabIndex = 0;
            this.txb_senha_log1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(116, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(158, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Acesso";
            // 
            // Bt_Aut_Sair
            // 
            this.Bt_Aut_Sair.Location = new System.Drawing.Point(209, 83);
            this.Bt_Aut_Sair.Name = "Bt_Aut_Sair";
            this.Bt_Aut_Sair.Size = new System.Drawing.Size(70, 31);
            this.Bt_Aut_Sair.TabIndex = 12;
            this.Bt_Aut_Sair.Text = "&SAIR";
            this.Bt_Aut_Sair.UseVisualStyleBackColor = true;
            this.Bt_Aut_Sair.Click += new System.EventHandler(this.Bt_Aut_Sair_Click);
            // 
            // Aut
            // 
            this.ClientSize = new System.Drawing.Size(320, 125);
            this.ControlBox = false;
            this.Controls.Add(this.Bt_Aut_Sair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_sair1);
            this.Controls.Add(this.txb_senha_log1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Aut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button bt_sair2;
        private System.Windows.Forms.TextBox txb_senha_log2;
        private System.Windows.Forms.TextBox txb_usu_log2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button bt_sair1;
        private System.Windows.Forms.TextBox txb_senha_log1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bt_Aut_Sair;
    }
}