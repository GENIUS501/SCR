namespace SCR
{
    partial class Reporte_Punto_Venta_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Punto_Venta_Cliente));
            this.dat_reporte = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_buscar_cedula = new System.Windows.Forms.MaskedTextBox();
            this.sCRDataSet = new SCR.SCRDataSet();
            this.puntoVentaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.punto_Venta_ClienteTableAdapter = new SCR.SCRDataSetTableAdapters.Punto_Venta_ClienteTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulajuridicafisicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_imprimir_Nombre = new System.Windows.Forms.Button();
            this.btn_imprimir_Cedula = new System.Windows.Forms.Button();
            this.btn_buscar_nombre = new System.Windows.Forms.Button();
            this.btn_buscar_cedula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_reporte)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dat_reporte
            // 
            this.dat_reporte.AllowUserToAddRows = false;
            this.dat_reporte.AllowUserToDeleteRows = false;
            this.dat_reporte.AutoGenerateColumns = false;
            this.dat_reporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn,
            this.cedulajuridicafisicaDataGridViewTextBoxColumn});
            this.dat_reporte.DataSource = this.puntoVentaClienteBindingSource;
            this.dat_reporte.Location = new System.Drawing.Point(12, 162);
            this.dat_reporte.Name = "dat_reporte";
            this.dat_reporte.ReadOnly = true;
            this.dat_reporte.RowTemplate.Height = 24;
            this.dat_reporte.Size = new System.Drawing.Size(776, 150);
            this.dat_reporte.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_buscar_cedula);
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_imprimir_Nombre);
            this.groupBox1.Controls.Add(this.btn_imprimir_Cedula);
            this.groupBox1.Controls.Add(this.btn_buscar_nombre);
            this.groupBox1.Controls.Add(this.btn_buscar_cedula);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 144);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(9, 105);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(259, 22);
            this.txt_buscar.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nombre del punto de venta o cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cedula";
            // 
            // txt_buscar_cedula
            // 
            this.txt_buscar_cedula.Location = new System.Drawing.Point(9, 47);
            this.txt_buscar_cedula.Mask = "0000000000";
            this.txt_buscar_cedula.Name = "txt_buscar_cedula";
            this.txt_buscar_cedula.Size = new System.Drawing.Size(259, 22);
            this.txt_buscar_cedula.TabIndex = 38;
            // 
            // sCRDataSet
            // 
            this.sCRDataSet.DataSetName = "SCRDataSet";
            this.sCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo Electronico";
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            this.correoElectronicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulajuridicafisicaDataGridViewTextBoxColumn
            // 
            this.cedulajuridicafisicaDataGridViewTextBoxColumn.DataPropertyName = "Cedula_juridica_fisica";
            this.cedulajuridicafisicaDataGridViewTextBoxColumn.HeaderText = "Cedula juridica fisica";
            this.cedulajuridicafisicaDataGridViewTextBoxColumn.Name = "cedulajuridicafisicaDataGridViewTextBoxColumn";
            this.cedulajuridicafisicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCR.Properties.Resources.Logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(460, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btn_imprimir_Nombre
            // 
            this.btn_imprimir_Nombre.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_Nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_Nombre.Location = new System.Drawing.Point(307, 103);
            this.btn_imprimir_Nombre.Name = "btn_imprimir_Nombre";
            this.btn_imprimir_Nombre.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_Nombre.TabIndex = 16;
            this.btn_imprimir_Nombre.UseVisualStyleBackColor = true;
            this.btn_imprimir_Nombre.Click += new System.EventHandler(this.btn_imprimir_Nombre_Click);
            // 
            // btn_imprimir_Cedula
            // 
            this.btn_imprimir_Cedula.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_Cedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_Cedula.Location = new System.Drawing.Point(307, 46);
            this.btn_imprimir_Cedula.Name = "btn_imprimir_Cedula";
            this.btn_imprimir_Cedula.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_Cedula.TabIndex = 15;
            this.btn_imprimir_Cedula.UseVisualStyleBackColor = true;
            this.btn_imprimir_Cedula.Click += new System.EventHandler(this.btn_imprimir_Cedula_Click);
            // 
            // btn_buscar_nombre
            // 
            this.btn_buscar_nombre.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_nombre.Location = new System.Drawing.Point(274, 104);
            this.btn_buscar_nombre.Name = "btn_buscar_nombre";
            this.btn_buscar_nombre.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_nombre.TabIndex = 13;
            this.btn_buscar_nombre.UseVisualStyleBackColor = true;
            this.btn_buscar_nombre.Click += new System.EventHandler(this.btn_buscar_nombre_Click);
            // 
            // btn_buscar_cedula
            // 
            this.btn_buscar_cedula.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_cedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_cedula.Location = new System.Drawing.Point(274, 46);
            this.btn_buscar_cedula.Name = "btn_buscar_cedula";
            this.btn_buscar_cedula.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_cedula.TabIndex = 12;
            this.btn_buscar_cedula.UseVisualStyleBackColor = true;
            this.btn_buscar_cedula.Click += new System.EventHandler(this.btn_buscar_cedula_Click);
            // 
            // Reporte_Punto_Venta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dat_reporte);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reporte_Punto_Venta_Cliente";
            this.Text = "Reporte_Punto_Venta_Cliente";
            this.Load += new System.EventHandler(this.Reporte_Punto_Venta_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_reporte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_reporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_imprimir_Nombre;
        private System.Windows.Forms.Button btn_imprimir_Cedula;
        private System.Windows.Forms.Button btn_buscar_nombre;
        private System.Windows.Forms.Button btn_buscar_cedula;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txt_buscar_cedula;
        private SCRDataSet sCRDataSet;
        private System.Windows.Forms.BindingSource puntoVentaClienteBindingSource;
        private SCRDataSetTableAdapters.Punto_Venta_ClienteTableAdapter punto_Venta_ClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulajuridicafisicaDataGridViewTextBoxColumn;
    }
}