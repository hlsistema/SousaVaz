namespace SousaVaz
{
    partial class Metodoconexao
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
            this.Bt_Local = new System.Windows.Forms.Button();
            this.Bt_Web = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(50, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SousaVaz";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Bt_Local
            // 
            this.Bt_Local.Location = new System.Drawing.Point(9, 54);
            this.Bt_Local.Name = "Bt_Local";
            this.Bt_Local.Size = new System.Drawing.Size(83, 32);
            this.Bt_Local.TabIndex = 0;
            this.Bt_Local.Text = "Local";
            this.Bt_Local.UseVisualStyleBackColor = true;
            this.Bt_Local.Click += new System.EventHandler(this.Bt_Local_Click);
            // 
            // Bt_Web
            // 
            this.Bt_Web.Location = new System.Drawing.Point(104, 54);
            this.Bt_Web.Name = "Bt_Web";
            this.Bt_Web.Size = new System.Drawing.Size(83, 32);
            this.Bt_Web.TabIndex = 1;
            this.Bt_Web.Text = "Web";
            this.Bt_Web.UseVisualStyleBackColor = true;
            this.Bt_Web.Click += new System.EventHandler(this.Bt_Web_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conexão";
            // 
            // Metodoconexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(194, 90);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bt_Web);
            this.Controls.Add(this.Bt_Local);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Metodoconexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Metodoconexao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_Local;
        private System.Windows.Forms.Button Bt_Web;
        private System.Windows.Forms.Label label2;
    }
}