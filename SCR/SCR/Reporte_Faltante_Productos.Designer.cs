namespace SCR
{
    partial class Reporte_Faltante_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Faltante_Productos));
            this.dat_faltante = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_punto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fecha_mes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_imprimir_codigo = new System.Windows.Forms.Button();
            this.btn_imprimir_punto = new System.Windows.Forms.Button();
            this.btn_imprimir_fecha = new System.Windows.Forms.Button();
            this.btn_buscar_codigo = new System.Windows.Forms.Button();
            this.btn_buscar_punto = new System.Windows.Forms.Button();
            this.btn_buscar_fecha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sCRDataSet = new SCR.SCRDataSet();
            this.faltantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faltantesTableAdapter = new SCR.SCRDataSetTableAdapters.FaltantesTableAdapter();
            this.idRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sugeridosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaMesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntoVentaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punto_Venta_ClienteTableAdapter = new SCR.SCRDataSetTableAdapters.Punto_Venta_ClienteTableAdapter();
            this.txt_codigo = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dat_faltante)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faltantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_faltante
            // 
            this.dat_faltante.AllowUserToAddRows = false;
            this.dat_faltante.AllowUserToDeleteRows = false;
            this.dat_faltante.AutoGenerateColumns = false;
            this.dat_faltante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_faltante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_faltante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRegistroDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.sugeridosDataGridViewTextBoxColumn,
            this.fechaMesDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dat_faltante.DataSource = this.faltantesBindingSource;
            this.dat_faltante.Location = new System.Drawing.Point(12, 227);
            this.dat_faltante.Name = "dat_faltante";
            this.dat_faltante.ReadOnly = true;
            this.dat_faltante.RowTemplate.Height = 24;
            this.dat_faltante.Size = new System.Drawing.Size(776, 150);
            this.dat_faltante.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_punto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_fecha_mes);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_imprimir_codigo);
            this.groupBox1.Controls.Add(this.btn_imprimir_punto);
            this.groupBox1.Controls.Add(this.btn_imprimir_fecha);
            this.groupBox1.Controls.Add(this.btn_buscar_codigo);
            this.groupBox1.Controls.Add(this.btn_buscar_punto);
            this.groupBox1.Controls.Add(this.btn_buscar_fecha);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 196);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo";
            // 
            // cbo_punto
            // 
            this.cbo_punto.DataSource = this.puntoVentaClienteBindingSource;
            this.cbo_punto.DisplayMember = "Nombre";
            this.cbo_punto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_punto.FormattingEnabled = true;
            this.cbo_punto.Location = new System.Drawing.Point(9, 105);
            this.cbo_punto.Name = "cbo_punto";
            this.cbo_punto.Size = new System.Drawing.Size(229, 24);
            this.cbo_punto.TabIndex = 21;
            this.cbo_punto.ValueMember = "Cedula_juridica_fisica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Punto de venta";
            // 
            // txt_fecha_mes
            // 
            this.txt_fecha_mes.Location = new System.Drawing.Point(9, 48);
            this.txt_fecha_mes.Name = "txt_fecha_mes";
            this.txt_fecha_mes.Size = new System.Drawing.Size(229, 22);
            this.txt_fecha_mes.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha Mes";
            // 
            // btn_imprimir_codigo
            // 
            this.btn_imprimir_codigo.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_codigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_codigo.Location = new System.Drawing.Point(277, 160);
            this.btn_imprimir_codigo.Name = "btn_imprimir_codigo";
            this.btn_imprimir_codigo.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_codigo.TabIndex = 17;
            this.btn_imprimir_codigo.UseVisualStyleBackColor = true;
            this.btn_imprimir_codigo.Click += new System.EventHandler(this.btn_imprimir_codigo_Click);
            // 
            // btn_imprimir_punto
            // 
            this.btn_imprimir_punto.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_punto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_punto.Location = new System.Drawing.Point(277, 105);
            this.btn_imprimir_punto.Name = "btn_imprimir_punto";
            this.btn_imprimir_punto.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_punto.TabIndex = 16;
            this.btn_imprimir_punto.UseVisualStyleBackColor = true;
            this.btn_imprimir_punto.Click += new System.EventHandler(this.btn_imprimir_punto_Click);
            // 
            // btn_imprimir_fecha
            // 
            this.btn_imprimir_fecha.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_fecha.Location = new System.Drawing.Point(277, 47);
            this.btn_imprimir_fecha.Name = "btn_imprimir_fecha";
            this.btn_imprimir_fecha.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_fecha.TabIndex = 15;
            this.btn_imprimir_fecha.UseVisualStyleBackColor = true;
            this.btn_imprimir_fecha.Click += new System.EventHandler(this.btn_imprimir_fecha_Click);
            // 
            // btn_buscar_codigo
            // 
            this.btn_buscar_codigo.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_codigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_codigo.Location = new System.Drawing.Point(244, 160);
            this.btn_buscar_codigo.Name = "btn_buscar_codigo";
            this.btn_buscar_codigo.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_codigo.TabIndex = 14;
            this.btn_buscar_codigo.UseVisualStyleBackColor = true;
            this.btn_buscar_codigo.Click += new System.EventHandler(this.btn_buscar_codigo_Click);
            // 
            // btn_buscar_punto
            // 
            this.btn_buscar_punto.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_punto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_punto.Location = new System.Drawing.Point(244, 105);
            this.btn_buscar_punto.Name = "btn_buscar_punto";
            this.btn_buscar_punto.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_punto.TabIndex = 13;
            this.btn_buscar_punto.UseVisualStyleBackColor = true;
            this.btn_buscar_punto.Click += new System.EventHandler(this.btn_buscar_punto_Click);
            // 
            // btn_buscar_fecha
            // 
            this.btn_buscar_fecha.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_fecha.Location = new System.Drawing.Point(244, 46);
            this.btn_buscar_fecha.Name = "btn_buscar_fecha";
            this.btn_buscar_fecha.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_fecha.TabIndex = 12;
            this.btn_buscar_fecha.UseVisualStyleBackColor = true;
            this.btn_buscar_fecha.Click += new System.EventHandler(this.btn_buscar_fecha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCR.Properties.Resources.Logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(419, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // sCRDataSet
            // 
            this.sCRDataSet.DataSetName = "SCRDataSet";
            this.sCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // faltantesBindingSource
            // 
            this.faltantesBindingSource.DataMember = "Faltantes";
            this.faltantesBindingSource.DataSource = this.sCRDataSet;
            // 
            // faltantesTableAdapter
            // 
            this.faltantesTableAdapter.ClearBeforeFill = true;
            // 
            // idRegistroDataGridViewTextBoxColumn
            // 
            this.idRegistroDataGridViewTextBoxColumn.DataPropertyName = "Id_Registro";
            this.idRegistroDataGridViewTextBoxColumn.HeaderText = "Id Registro";
            this.idRegistroDataGridViewTextBoxColumn.Name = "idRegistroDataGridViewTextBoxColumn";
            this.idRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Producto";
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "Codigo Producto";
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            this.codigoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sugeridosDataGridViewTextBoxColumn
            // 
            this.sugeridosDataGridViewTextBoxColumn.DataPropertyName = "Sugeridos";
            this.sugeridosDataGridViewTextBoxColumn.HeaderText = "Sugeridos";
            this.sugeridosDataGridViewTextBoxColumn.Name = "sugeridosDataGridViewTextBoxColumn";
            this.sugeridosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaMesDataGridViewTextBoxColumn
            // 
            this.fechaMesDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Mes";
            this.fechaMesDataGridViewTextBoxColumn.HeaderText = "Fecha Mes";
            this.fechaMesDataGridViewTextBoxColumn.Name = "fechaMesDataGridViewTextBoxColumn";
            this.fechaMesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puntoVentaClienteBindingSource
            // 
            this.puntoVentaClienteBindingSource.DataMember = "Punto_Venta_Cliente";
            this.puntoVentaClienteBindingSource.DataSource = this.sCRDataSet;
            // 
            // punto_Venta_ClienteTableAdapter
            // 
            this.punto_Venta_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(9, 160);
            this.txt_codigo.Mask = "000000000";
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(229, 22);
            this.txt_codigo.TabIndex = 24;
            // 
            // Reporte_Faltante_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dat_faltante);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reporte_Faltante_Productos";
            this.Text = "Reporte_Faltante_Productos";
            this.Load += new System.EventHandler(this.Reporte_Faltante_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_faltante)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faltantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_faltante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_imprimir_codigo;
        private System.Windows.Forms.Button btn_imprimir_punto;
        private System.Windows.Forms.Button btn_imprimir_fecha;
        private System.Windows.Forms.Button btn_buscar_codigo;
        private System.Windows.Forms.Button btn_buscar_punto;
        private System.Windows.Forms.Button btn_buscar_fecha;
        private System.Windows.Forms.TextBox txt_fecha_mes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_punto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SCRDataSet sCRDataSet;
        private System.Windows.Forms.BindingSource faltantesBindingSource;
        private SCRDataSetTableAdapters.FaltantesTableAdapter faltantesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sugeridosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaMesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource puntoVentaClienteBindingSource;
        private SCRDataSetTableAdapters.Punto_Venta_ClienteTableAdapter punto_Venta_ClienteTableAdapter;
        private System.Windows.Forms.MaskedTextBox txt_codigo;
    }
}