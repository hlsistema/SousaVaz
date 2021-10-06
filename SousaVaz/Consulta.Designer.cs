namespace SousaVaz
{
    partial class Consulta
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.cons_prod = new System.Windows.Forms.TextBox();
            this.bt_consulta_prod = new System.Windows.Forms.Button();
            this.data_prod = new System.Windows.Forms.DataGridView();
            this.data_similar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_limp_prod = new System.Windows.Forms.Button();
            this.mySqlGeometryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data_prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_similar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlGeometryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // cons_prod
            // 
            this.cons_prod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cons_prod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cons_prod.Location = new System.Drawing.Point(98, 64);
            this.cons_prod.MaxLength = 60;
            this.cons_prod.Name = "cons_prod";
            this.cons_prod.Size = new System.Drawing.Size(757, 26);
            this.cons_prod.TabIndex = 2;
            // 
            // bt_consulta_prod
            // 
            this.bt_consulta_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_consulta_prod.Location = new System.Drawing.Point(769, 96);
            this.bt_consulta_prod.Name = "bt_consulta_prod";
            this.bt_consulta_prod.Size = new System.Drawing.Size(86, 26);
            this.bt_consulta_prod.TabIndex = 3;
            this.bt_consulta_prod.Text = "&Consultar";
            this.bt_consulta_prod.UseVisualStyleBackColor = true;
            this.bt_consulta_prod.Click += new System.EventHandler(this.bt_consulta_prod_Click);
            // 
            // data_prod
            // 
            this.data_prod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_prod.Location = new System.Drawing.Point(12, 160);
            this.data_prod.Name = "data_prod";
            this.data_prod.Size = new System.Drawing.Size(843, 70);
            this.data_prod.TabIndex = 4;
            // 
            // data_similar
            // 
            this.data_similar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_similar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_similar.Location = new System.Drawing.Point(12, 278);
            this.data_similar.Name = "data_similar";
            this.data_similar.Size = new System.Drawing.Size(843, 155);
            this.data_similar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Similar";
            // 
            // bt_limp_prod
            // 
            this.bt_limp_prod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_limp_prod.Location = new System.Drawing.Point(769, 128);
            this.bt_limp_prod.Name = "bt_limp_prod";
            this.bt_limp_prod.Size = new System.Drawing.Size(86, 26);
            this.bt_limp_prod.TabIndex = 7;
            this.bt_limp_prod.Text = "&Limpar";
            this.bt_limp_prod.UseVisualStyleBackColor = true;
            this.bt_limp_prod.Click += new System.EventHandler(this.bt_limp_prod_Click);
            // 
            // mySqlGeometryBindingSource
            // 
            this.mySqlGeometryBindingSource.DataSource = typeof(MySql.Data.Types.MySqlGeometry);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 442);
            this.Controls.Add(this.bt_limp_prod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_similar);
            this.Controls.Add(this.data_prod);
            this.Controls.Add(this.bt_consulta_prod);
            this.Controls.Add(this.cons_prod);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_similar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySqlGeometryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cons_prod;
        private System.Windows.Forms.Button bt_consulta_prod;
        private System.Windows.Forms.DataGridView data_prod;
        private System.Windows.Forms.DataGridView data_similar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_limp_prod;
        private System.Windows.Forms.BindingSource mySqlGeometryBindingSource;
    }
}