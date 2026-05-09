namespace DiazMaxiPrimerParcial
{
    partial class frmVentaEquiposInformaticos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArticulosConsulta = new System.Windows.Forms.Label();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.btnExportarDatos = new System.Windows.Forms.Button();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.lblCantiArticulos = new System.Windows.Forms.Label();
            this.lblTotalValorStock = new System.Windows.Forms.Label();
            this.lblCantidadArticulos = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulosConsulta
            // 
            this.lblArticulosConsulta.AutoSize = true;
            this.lblArticulosConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosConsulta.Location = new System.Drawing.Point(23, 16);
            this.lblArticulosConsulta.Name = "lblArticulosConsulta";
            this.lblArticulosConsulta.Size = new System.Drawing.Size(115, 17);
            this.lblArticulosConsulta.TabIndex = 0;
            this.lblArticulosConsulta.Text = "Consulta de Articulos";
            this.lblArticulosConsulta.UseCompatibleTextRendering = true;
            this.lblArticulosConsulta.Click += new System.EventHandler(this.lblArticulosConsulta_Click);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(20, 60);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(98, 13);
            this.lblSeleccionar.TabIndex = 1;
            this.lblSeleccionar.Text = "Seleccionar Rubro:";
            // 
            // cmbRubro
            // 
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(138, 57);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(121, 21);
            this.cmbRubro.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLink);
            this.groupBox1.Controls.Add(this.btnExportarDatos);
            this.groupBox1.Controls.Add(this.lblTotalStock);
            this.groupBox1.Controls.Add(this.lblCantiArticulos);
            this.groupBox1.Controls.Add(this.lblTotalValorStock);
            this.groupBox1.Controls.Add(this.lblCantidadArticulos);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.dgvArticulos);
            this.groupBox1.Controls.Add(this.lblArticulosConsulta);
            this.groupBox1.Controls.Add(this.cmbRubro);
            this.groupBox1.Controls.Add(this.lblSeleccionar);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 556);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(6, 520);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(123, 13);
            this.lblLink.TabIndex = 9;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Acerca del Desarrollador";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // btnExportarDatos
            // 
            this.btnExportarDatos.Location = new System.Drawing.Point(360, 492);
            this.btnExportarDatos.Name = "btnExportarDatos";
            this.btnExportarDatos.Size = new System.Drawing.Size(86, 26);
            this.btnExportarDatos.TabIndex = 8;
            this.btnExportarDatos.Text = "Exportar Datos";
            this.btnExportarDatos.UseVisualStyleBackColor = true;
            this.btnExportarDatos.Click += new System.EventHandler(this.btnExportarDatos_Click);
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalStock.Location = new System.Drawing.Point(138, 477);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(110, 22);
            this.lblTotalStock.TabIndex = 7;
            // 
            // lblCantiArticulos
            // 
            this.lblCantiArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantiArticulos.Location = new System.Drawing.Point(138, 432);
            this.lblCantiArticulos.Name = "lblCantiArticulos";
            this.lblCantiArticulos.Size = new System.Drawing.Size(110, 22);
            this.lblCantiArticulos.TabIndex = 6;
            // 
            // lblTotalValorStock
            // 
            this.lblTotalValorStock.AutoSize = true;
            this.lblTotalValorStock.Location = new System.Drawing.Point(6, 478);
            this.lblTotalValorStock.Name = "lblTotalValorStock";
            this.lblTotalValorStock.Size = new System.Drawing.Size(89, 13);
            this.lblTotalValorStock.TabIndex = 5;
            this.lblTotalValorStock.Text = "Total valor stock:";
            // 
            // lblCantidadArticulos
            // 
            this.lblCantidadArticulos.AutoSize = true;
            this.lblCantidadArticulos.Location = new System.Drawing.Point(6, 433);
            this.lblCantidadArticulos.Name = "lblCantidadArticulos";
            this.lblCantidadArticulos.Size = new System.Drawing.Size(110, 13);
            this.lblCantidadArticulos.TabIndex = 4;
            this.lblCantidadArticulos.Text = "Cantidad de Articulos:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(360, 57);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(86, 26);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvArticulos.Location = new System.Drawing.Point(9, 117);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(562, 269);
            this.dgvArticulos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Costo";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stock";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Valor en Stock";
            this.Column5.Name = "Column5";
            // 
            // frmVentaEquiposInformaticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 576);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVentaEquiposInformaticos";
            this.Text = "Venta de Articulos Informaticos";
            this.Load += new System.EventHandler(this.frmVentaEquiposInformaticos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblArticulosConsulta;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.Label lblCantiArticulos;
        private System.Windows.Forms.Label lblTotalValorStock;
        private System.Windows.Forms.Label lblCantidadArticulos;
        private System.Windows.Forms.Button btnExportarDatos;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}

