namespace SCR
{
    partial class Reporte_Vencimiento_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Vencimiento_producto));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_reporte = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_vencimiento_producto = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_supervisor = new System.Windows.Forms.ComboBox();
            this.supervisoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCRDataSet = new SCR.SCRDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_imprimir_supervisor = new System.Windows.Forms.Button();
            this.btn_imprimir_reporte = new System.Windows.Forms.Button();
            this.btn_imprimir_vencimiento = new System.Windows.Forms.Button();
            this.btn_buscar_supervision = new System.Windows.Forms.Button();
            this.btn_buscar_reporte = new System.Windows.Forms.Button();
            this.btn_buscar_vencimiento = new System.Windows.Forms.Button();
            this.dat_vencimiento = new System.Windows.Forms.DataGridView();
            this.fechareportevencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavencimientoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiemporeaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaSupervisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionSKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesxSKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguimiento3mesesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguimiento5mesesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimientoProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vencimiento_ProductosTableAdapter = new SCR.SCRDataSetTableAdapters.Vencimiento_ProductosTableAdapter();
            this.supervisoresTableAdapter = new SCR.SCRDataSetTableAdapters.SupervisoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.supervisoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_vencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vencimientoProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de vencimiento del producto";
            // 
            // txt_reporte
            // 
            this.txt_reporte.Location = new System.Drawing.Point(9, 108);
            this.txt_reporte.Name = "txt_reporte";
            this.txt_reporte.Size = new System.Drawing.Size(276, 22);
            this.txt_reporte.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha del reporte del vencimiento";
            // 
            // txt_vencimiento_producto
            // 
            this.txt_vencimiento_producto.Location = new System.Drawing.Point(9, 49);
            this.txt_vencimiento_producto.Name = "txt_vencimiento_producto";
            this.txt_vencimiento_producto.Size = new System.Drawing.Size(276, 22);
            this.txt_vencimiento_producto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Supervisor";
            // 
            // cbo_supervisor
            // 
            this.cbo_supervisor.DataSource = this.supervisoresBindingSource;
            this.cbo_supervisor.DisplayMember = "Nombre";
            this.cbo_supervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_supervisor.FormattingEnabled = true;
            this.cbo_supervisor.Location = new System.Drawing.Point(9, 163);
            this.cbo_supervisor.Name = "cbo_supervisor";
            this.cbo_supervisor.Size = new System.Drawing.Size(276, 24);
            this.cbo_supervisor.TabIndex = 11;
            this.cbo_supervisor.ValueMember = "Cedula";
            // 
            // supervisoresBindingSource
            // 
            this.supervisoresBindingSource.DataMember = "Supervisores";
            this.supervisoresBindingSource.DataSource = this.sCRDataSet;
            // 
            // sCRDataSet
            // 
            this.sCRDataSet.DataSetName = "SCRDataSet";
            this.sCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_imprimir_supervisor);
            this.groupBox1.Controls.Add(this.btn_imprimir_reporte);
            this.groupBox1.Controls.Add(this.btn_imprimir_vencimiento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_buscar_supervision);
            this.groupBox1.Controls.Add(this.txt_vencimiento_producto);
            this.groupBox1.Controls.Add(this.btn_buscar_reporte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_buscar_vencimiento);
            this.groupBox1.Controls.Add(this.txt_reporte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbo_supervisor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 196);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // btn_imprimir_supervisor
            // 
            this.btn_imprimir_supervisor.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_supervisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_supervisor.Location = new System.Drawing.Point(324, 162);
            this.btn_imprimir_supervisor.Name = "btn_imprimir_supervisor";
            this.btn_imprimir_supervisor.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_supervisor.TabIndex = 17;
            this.btn_imprimir_supervisor.UseVisualStyleBackColor = true;
            this.btn_imprimir_supervisor.Click += new System.EventHandler(this.btn_imprimir_supervisor_Click);
            // 
            // btn_imprimir_reporte
            // 
            this.btn_imprimir_reporte.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_reporte.Location = new System.Drawing.Point(324, 106);
            this.btn_imprimir_reporte.Name = "btn_imprimir_reporte";
            this.btn_imprimir_reporte.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_reporte.TabIndex = 16;
            this.btn_imprimir_reporte.UseVisualStyleBackColor = true;
            this.btn_imprimir_reporte.Click += new System.EventHandler(this.btn_imprimir_reporte_Click);
            // 
            // btn_imprimir_vencimiento
            // 
            this.btn_imprimir_vencimiento.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_vencimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_vencimiento.Location = new System.Drawing.Point(324, 49);
            this.btn_imprimir_vencimiento.Name = "btn_imprimir_vencimiento";
            this.btn_imprimir_vencimiento.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_vencimiento.TabIndex = 15;
            this.btn_imprimir_vencimiento.UseVisualStyleBackColor = true;
            this.btn_imprimir_vencimiento.Click += new System.EventHandler(this.btn_imprimir_vencimiento_Click);
            // 
            // btn_buscar_supervision
            // 
            this.btn_buscar_supervision.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_supervision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_supervision.Location = new System.Drawing.Point(291, 162);
            this.btn_buscar_supervision.Name = "btn_buscar_supervision";
            this.btn_buscar_supervision.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_supervision.TabIndex = 14;
            this.btn_buscar_supervision.UseVisualStyleBackColor = true;
            this.btn_buscar_supervision.Click += new System.EventHandler(this.btn_buscar_supervision_Click);
            // 
            // btn_buscar_reporte
            // 
            this.btn_buscar_reporte.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_reporte.Location = new System.Drawing.Point(291, 106);
            this.btn_buscar_reporte.Name = "btn_buscar_reporte";
            this.btn_buscar_reporte.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_reporte.TabIndex = 13;
            this.btn_buscar_reporte.UseVisualStyleBackColor = true;
            this.btn_buscar_reporte.Click += new System.EventHandler(this.btn_buscar_reporte_Click);
            // 
            // btn_buscar_vencimiento
            // 
            this.btn_buscar_vencimiento.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_vencimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_vencimiento.Location = new System.Drawing.Point(291, 47);
            this.btn_buscar_vencimiento.Name = "btn_buscar_vencimiento";
            this.btn_buscar_vencimiento.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_vencimiento.TabIndex = 12;
            this.btn_buscar_vencimiento.UseVisualStyleBackColor = true;
            this.btn_buscar_vencimiento.Click += new System.EventHandler(this.btn_buscar_vencimiento_Click);
            // 
            // dat_vencimiento
            // 
            this.dat_vencimiento.AllowUserToAddRows = false;
            this.dat_vencimiento.AllowUserToDeleteRows = false;
            this.dat_vencimiento.AutoGenerateColumns = false;
            this.dat_vencimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_vencimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechareportevencimientoDataGridViewTextBoxColumn,
            this.fechavencimientoproductoDataGridViewTextBoxColumn,
            this.tiemporeaccionDataGridViewTextBoxColumn,
            this.cedulaSupervisorDataGridViewTextBoxColumn,
            this.zonaDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.descripcionSKUDataGridViewTextBoxColumn,
            this.unidadesxSKUDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.seguimiento3mesesDataGridViewTextBoxColumn,
            this.seguimiento5mesesDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dat_vencimiento.DataSource = this.vencimientoProductosBindingSource;
            this.dat_vencimiento.Location = new System.Drawing.Point(12, 227);
            this.dat_vencimiento.Name = "dat_vencimiento";
            this.dat_vencimiento.ReadOnly = true;
            this.dat_vencimiento.RowTemplate.Height = 24;
            this.dat_vencimiento.Size = new System.Drawing.Size(776, 150);
            this.dat_vencimiento.TabIndex = 16;
            // 
            // fechareportevencimientoDataGridViewTextBoxColumn
            // 
            this.fechareportevencimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_reporte_vencimiento";
            this.fechareportevencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha reporte vencimiento";
            this.fechareportevencimientoDataGridViewTextBoxColumn.Name = "fechareportevencimientoDataGridViewTextBoxColumn";
            this.fechareportevencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechavencimientoproductoDataGridViewTextBoxColumn
            // 
            this.fechavencimientoproductoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_vencimiento_producto";
            this.fechavencimientoproductoDataGridViewTextBoxColumn.HeaderText = "Fecha vencimiento producto";
            this.fechavencimientoproductoDataGridViewTextBoxColumn.Name = "fechavencimientoproductoDataGridViewTextBoxColumn";
            this.fechavencimientoproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiemporeaccionDataGridViewTextBoxColumn
            // 
            this.tiemporeaccionDataGridViewTextBoxColumn.DataPropertyName = "tiempo_reaccion";
            this.tiemporeaccionDataGridViewTextBoxColumn.HeaderText = "tiempo reaccion";
            this.tiemporeaccionDataGridViewTextBoxColumn.Name = "tiemporeaccionDataGridViewTextBoxColumn";
            this.tiemporeaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaSupervisorDataGridViewTextBoxColumn
            // 
            this.cedulaSupervisorDataGridViewTextBoxColumn.DataPropertyName = "Cedula_Supervisor";
            this.cedulaSupervisorDataGridViewTextBoxColumn.HeaderText = "Cedula Supervisor";
            this.cedulaSupervisorDataGridViewTextBoxColumn.Name = "cedulaSupervisorDataGridViewTextBoxColumn";
            this.cedulaSupervisorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zonaDataGridViewTextBoxColumn
            // 
            this.zonaDataGridViewTextBoxColumn.DataPropertyName = "Zona";
            this.zonaDataGridViewTextBoxColumn.HeaderText = "Zona";
            this.zonaDataGridViewTextBoxColumn.Name = "zonaDataGridViewTextBoxColumn";
            this.zonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionSKUDataGridViewTextBoxColumn
            // 
            this.descripcionSKUDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_SKU";
            this.descripcionSKUDataGridViewTextBoxColumn.HeaderText = "Descripcion SKU";
            this.descripcionSKUDataGridViewTextBoxColumn.Name = "descripcionSKUDataGridViewTextBoxColumn";
            this.descripcionSKUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadesxSKUDataGridViewTextBoxColumn
            // 
            this.unidadesxSKUDataGridViewTextBoxColumn.DataPropertyName = "UnidadesxSKU";
            this.unidadesxSKUDataGridViewTextBoxColumn.HeaderText = "Unidades * SKU";
            this.unidadesxSKUDataGridViewTextBoxColumn.Name = "unidadesxSKUDataGridViewTextBoxColumn";
            this.unidadesxSKUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            this.observacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seguimiento3mesesDataGridViewTextBoxColumn
            // 
            this.seguimiento3mesesDataGridViewTextBoxColumn.DataPropertyName = "Seguimiento_3_meses";
            this.seguimiento3mesesDataGridViewTextBoxColumn.HeaderText = "Seguimiento 3 meses";
            this.seguimiento3mesesDataGridViewTextBoxColumn.Name = "seguimiento3mesesDataGridViewTextBoxColumn";
            this.seguimiento3mesesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seguimiento5mesesDataGridViewTextBoxColumn
            // 
            this.seguimiento5mesesDataGridViewTextBoxColumn.DataPropertyName = "Seguimiento_5_meses";
            this.seguimiento5mesesDataGridViewTextBoxColumn.HeaderText = "Seguimiento 5 meses";
            this.seguimiento5mesesDataGridViewTextBoxColumn.Name = "seguimiento5mesesDataGridViewTextBoxColumn";
            this.seguimiento5mesesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vencimientoProductosBindingSource
            // 
            this.vencimientoProductosBindingSource.DataMember = "Vencimiento_Productos";
            this.vencimientoProductosBindingSource.DataSource = this.sCRDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCR.Properties.Resources.Logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(419, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // vencimiento_ProductosTableAdapter
            // 
            this.vencimiento_ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // supervisoresTableAdapter
            // 
            this.supervisoresTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Vencimiento_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dat_vencimiento);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reporte_Vencimiento_producto";
            this.Text = "Reporte_Vencimiento_producto";
            this.Load += new System.EventHandler(this.Reporte_Vencimiento_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supervisoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_vencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vencimientoProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_reporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_vencimiento_producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_supervisor;
        private System.Windows.Forms.Button btn_buscar_vencimiento;
        private System.Windows.Forms.Button btn_buscar_reporte;
        private System.Windows.Forms.Button btn_buscar_supervision;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dat_vencimiento;
        private System.Windows.Forms.Button btn_imprimir_vencimiento;
        private System.Windows.Forms.Button btn_imprimir_supervisor;
        private System.Windows.Forms.Button btn_imprimir_reporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SCRDataSet sCRDataSet;
        private System.Windows.Forms.BindingSource vencimientoProductosBindingSource;
        private SCRDataSetTableAdapters.Vencimiento_ProductosTableAdapter vencimiento_ProductosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechareportevencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavencimientoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiemporeaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaSupervisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionSKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesxSKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguimiento3mesesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguimiento5mesesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supervisoresBindingSource;
        private SCRDataSetTableAdapters.SupervisoresTableAdapter supervisoresTableAdapter;
    }
}