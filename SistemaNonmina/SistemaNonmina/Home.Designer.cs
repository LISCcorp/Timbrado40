namespace SistemaNonmina
{
    partial class Home
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
            this.txtFicheroCSV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btLeerCSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeparador = new System.Windows.Forms.TextBox();
            this.txtSeparadorCampos = new System.Windows.Forms.TextBox();
            this.opTitulos = new System.Windows.Forms.CheckBox();
            this.dbTabla = new System.Windows.Forms.DataGridView();
            this.Regresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFicheroCSV
            // 
            this.txtFicheroCSV.Location = new System.Drawing.Point(38, 65);
            this.txtFicheroCSV.Name = "txtFicheroCSV";
            this.txtFicheroCSV.Size = new System.Drawing.Size(444, 20);
            this.txtFicheroCSV.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "........";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btLeerCSV
            // 
            this.btLeerCSV.Location = new System.Drawing.Point(571, 64);
            this.btLeerCSV.Name = "btLeerCSV";
            this.btLeerCSV.Size = new System.Drawing.Size(105, 21);
            this.btLeerCSV.TabIndex = 2;
            this.btLeerCSV.Text = "Leer y Cargar";
            this.btLeerCSV.UseVisualStyleBackColor = true;
            this.btLeerCSV.Click += new System.EventHandler(this.btLeerCSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caracter separador de campos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caracter separador de valores";
            // 
            // txtSeparador
            // 
            this.txtSeparador.Location = new System.Drawing.Point(193, 106);
            this.txtSeparador.Name = "txtSeparador";
            this.txtSeparador.Size = new System.Drawing.Size(36, 20);
            this.txtSeparador.TabIndex = 5;
            // 
            // txtSeparadorCampos
            // 
            this.txtSeparadorCampos.Location = new System.Drawing.Point(413, 107);
            this.txtSeparadorCampos.Name = "txtSeparadorCampos";
            this.txtSeparadorCampos.Size = new System.Drawing.Size(37, 20);
            this.txtSeparadorCampos.TabIndex = 6;
            this.txtSeparadorCampos.Text = "|";
            // 
            // opTitulos
            // 
            this.opTitulos.AutoSize = true;
            this.opTitulos.Location = new System.Drawing.Point(484, 109);
            this.opTitulos.Name = "opTitulos";
            this.opTitulos.Size = new System.Drawing.Size(275, 17);
            this.opTitulos.TabIndex = 9;
            this.opTitulos.Text = "La primera linea contiene los titulos de las columnas?";
            this.opTitulos.UseVisualStyleBackColor = true;
            // 
            // dbTabla
            // 
            this.dbTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbTabla.Location = new System.Drawing.Point(12, 148);
            this.dbTabla.Name = "dbTabla";
            this.dbTabla.Size = new System.Drawing.Size(757, 245);
            this.dbTabla.TabIndex = 10;
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(12, 410);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(125, 23);
            this.Regresar.TabIndex = 11;
            this.Regresar.Text = "Regresar al menu";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Leer un fichero CSV";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(781, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.dbTabla);
            this.Controls.Add(this.opTitulos);
            this.Controls.Add(this.txtSeparadorCampos);
            this.Controls.Add(this.txtSeparador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLeerCSV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFicheroCSV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dbTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFicheroCSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btLeerCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeparador;
        private System.Windows.Forms.TextBox txtSeparadorCampos;
        private System.Windows.Forms.CheckBox opTitulos;
        private System.Windows.Forms.DataGridView dbTabla;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label label3;
    }
}