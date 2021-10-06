
namespace SousaVaz
{
    partial class web
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
            this.txtbox_web = new System.Windows.Forms.TextBox();
            this.bt_atualizar_web = new System.Windows.Forms.Button();
            this.bt_web_limp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atualização de Informações para a Web";
            // 
            // txtbox_web
            // 
            this.txtbox_web.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_web.Location = new System.Drawing.Point(12, 38);
            this.txtbox_web.MaxLength = 327670000;
            this.txtbox_web.Multiline = true;
            this.txtbox_web.Name = "txtbox_web";
            this.txtbox_web.Size = new System.Drawing.Size(564, 93);
            this.txtbox_web.TabIndex = 1;
            // 
            // bt_atualizar_web
            // 
            this.bt_atualizar_web.Location = new System.Drawing.Point(465, 137);
            this.bt_atualizar_web.Name = "bt_atualizar_web";
            this.bt_atualizar_web.Size = new System.Drawing.Size(111, 32);
            this.bt_atualizar_web.TabIndex = 2;
            this.bt_atualizar_web.Text = "&Atualizar";
            this.bt_atualizar_web.UseVisualStyleBackColor = true;
            this.bt_atualizar_web.Click += new System.EventHandler(this.Bt_atualizar_web_Click);
            // 
            // bt_web_limp
            // 
            this.bt_web_limp.Location = new System.Drawing.Point(12, 137);
            this.bt_web_limp.Name = "bt_web_limp";
            this.bt_web_limp.Size = new System.Drawing.Size(111, 32);
            this.bt_web_limp.TabIndex = 3;
            this.bt_web_limp.Text = "&Limpar";
            this.bt_web_limp.UseVisualStyleBackColor = true;
            this.bt_web_limp.Click += new System.EventHandler(this.Bt_web_limp_Click);
            // 
            // web
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 179);
            this.Controls.Add(this.bt_web_limp);
            this.Controls.Add(this.bt_atualizar_web);
            this.Controls.Add(this.txtbox_web);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "web";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização para Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_web;
        private System.Windows.Forms.Button bt_atualizar_web;
        private System.Windows.Forms.Button bt_web_limp;
    }
}