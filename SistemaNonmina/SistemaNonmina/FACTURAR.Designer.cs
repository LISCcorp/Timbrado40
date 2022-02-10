namespace SistemaNonmina
{
    partial class FACTURAR
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
            this.btnCarga = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnxml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(12, 12);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(100, 38);
            this.btnCarga.TabIndex = 0;
            this.btnCarga.Text = "Ver Facturas";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 321);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(696, 402);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(92, 36);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 402);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(92, 36);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnxml
            // 
            this.btnxml.Location = new System.Drawing.Point(155, 12);
            this.btnxml.Name = "btnxml";
            this.btnxml.Size = new System.Drawing.Size(105, 38);
            this.btnxml.TabIndex = 4;
            this.btnxml.Text = "Genera XML";
            this.btnxml.UseVisualStyleBackColor = true;
            this.btnxml.Click += new System.EventHandler(this.btnxml_Click);
            // 
            // FACTURAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxml);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCarga);
            this.Name = "FACTURAR";
            this.Text = "FACTURAR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnxml;
    }
}