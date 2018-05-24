namespace WpfApplication3.Vistas.Empleados
{
    partial class FormListar
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
            this.dgv_Listar = new System.Windows.Forms.DataGridView();
            this.Nuevo = new System.Windows.Forms.LinkLabel();
            this.txt_lblL = new System.Windows.Forms.Label();
            this.txt_BuscarL = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Listar
            // 
            this.dgv_Listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Listar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgv_Listar.Location = new System.Drawing.Point(12, 70);
            this.dgv_Listar.Name = "dgv_Listar";
            this.dgv_Listar.Size = new System.Drawing.Size(593, 186);
            this.dgv_Listar.TabIndex = 0;
            // 
            // Nuevo
            // 
            this.Nuevo.AutoSize = true;
            this.Nuevo.Location = new System.Drawing.Point(12, 9);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(73, 13);
            this.Nuevo.TabIndex = 2;
            this.Nuevo.TabStop = true;
            this.Nuevo.Text = "Nuevo cliente";
            // 
            // txt_lblL
            // 
            this.txt_lblL.AutoSize = true;
            this.txt_lblL.Location = new System.Drawing.Point(427, 9);
            this.txt_lblL.Name = "txt_lblL";
            this.txt_lblL.Size = new System.Drawing.Size(40, 13);
            this.txt_lblL.TabIndex = 3;
            this.txt_lblL.Text = "Buscar";
            // 
            // txt_BuscarL
            // 
            this.txt_BuscarL.Location = new System.Drawing.Point(430, 25);
            this.txt_BuscarL.Name = "txt_BuscarL";
            this.txt_BuscarL.Size = new System.Drawing.Size(170, 20);
            this.txt_BuscarL.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Apellidos";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rut";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sexo";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Edad";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // FormListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 268);
            this.Controls.Add(this.txt_BuscarL);
            this.Controls.Add(this.txt_lblL);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.dgv_Listar);
            this.Name = "FormListar";
            this.Text = "Listar";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Listar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Listar;
        private System.Windows.Forms.LinkLabel Nuevo;
        private System.Windows.Forms.Label txt_lblL;
        private System.Windows.Forms.TextBox txt_BuscarL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}