namespace SV
{
    partial class Script
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
            this.txtbox_script = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bt_Executar_Script = new System.Windows.Forms.Button();
            this.Bt_Limpar_Script = new System.Windows.Forms.Button();
            this.Bt_Sair_Script = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(235, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comandos";
            // 
            // txtbox_script
            // 
            this.txtbox_script.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_script.Location = new System.Drawing.Point(12, 61);
            this.txtbox_script.MaxLength = 32767000;
            this.txtbox_script.Multiline = true;
            this.txtbox_script.Name = "txtbox_script";
            this.txtbox_script.Size = new System.Drawing.Size(580, 171);
            this.txtbox_script.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 112);
            this.dataGridView1.TabIndex = 2;
            // 
            // Bt_Executar_Script
            // 
            this.Bt_Executar_Script.Location = new System.Drawing.Point(12, 238);
            this.Bt_Executar_Script.Name = "Bt_Executar_Script";
            this.Bt_Executar_Script.Size = new System.Drawing.Size(102, 38);
            this.Bt_Executar_Script.TabIndex = 3;
            this.Bt_Executar_Script.Text = "&Executar";
            this.Bt_Executar_Script.UseVisualStyleBackColor = true;
            // 
            // Bt_Limpar_Script
            // 
            this.Bt_Limpar_Script.Location = new System.Drawing.Point(256, 238);
            this.Bt_Limpar_Script.Name = "Bt_Limpar_Script";
            this.Bt_Limpar_Script.Size = new System.Drawing.Size(102, 38);
            this.Bt_Limpar_Script.TabIndex = 4;
            this.Bt_Limpar_Script.Text = "&Limpar";
            this.Bt_Limpar_Script.UseVisualStyleBackColor = true;
            // 
            // Bt_Sair_Script
            // 
            this.Bt_Sair_Script.Location = new System.Drawing.Point(496, 238);
            this.Bt_Sair_Script.Name = "Bt_Sair_Script";
            this.Bt_Sair_Script.Size = new System.Drawing.Size(96, 38);
            this.Bt_Sair_Script.TabIndex = 5;
            this.Bt_Sair_Script.Text = "&Sair";
            this.Bt_Sair_Script.UseVisualStyleBackColor = true;
            this.Bt_Sair_Script.Click += new System.EventHandler(this.Bt_Sair_Script_Click);
            // 
            // Script
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 406);
            this.Controls.Add(this.Bt_Sair_Script);
            this.Controls.Add(this.Bt_Limpar_Script);
            this.Controls.Add(this.Bt_Executar_Script);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbox_script);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Script";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_script;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bt_Executar_Script;
        private System.Windows.Forms.Button Bt_Limpar_Script;
        private System.Windows.Forms.Button Bt_Sair_Script;
    }
}