namespace SCR
{
    partial class Bitacora_Movimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora_Movimientos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_movimiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.txt_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dat_sesiones = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionesRealizadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCRDataSet = new SCR.SCRDataSet();
            this.acciones_RealizadasTableAdapter = new SCR.SCRDataSetTableAdapters.Acciones_RealizadasTableAdapter();
            this.btn_imprimir_movimiento = new System.Windows.Forms.Button();
            this.btn_buscar_movimientos = new System.Windows.Forms.Button();
            this.btn_imprimir_fechas = new System.Windows.Forms.Button();
            this.btn_buscar_fechas = new System.Windows.Forms.Button();
            this.btn_imprimir_Usuario = new System.Windows.Forms.Button();
            this.btn_buscar_Usuario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accionesRealizadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_imprimir_movimiento);
            this.groupBox1.Controls.Add(this.btn_buscar_movimientos);
            this.groupBox1.Controls.Add(this.cbo_movimiento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_imprimir_fechas);
            this.groupBox1.Controls.Add(this.btn_buscar_fechas);
            this.groupBox1.Controls.Add(this.btn_imprimir_Usuario);
            this.groupBox1.Controls.Add(this.btn_buscar_Usuario);
            this.groupBox1.Controls.Add(this.txt_fecha_fin);
            this.groupBox1.Controls.Add(this.txt_fecha_ini);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(631, 199);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // cbo_movimiento
            // 
            this.cbo_movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_movimiento.FormattingEnabled = true;
            this.cbo_movimiento.Items.AddRange(new object[] {
            "Agrego",
            "Modifico",
            "Elimino",
            "Genero"});
            this.cbo_movimiento.Location = new System.Drawing.Point(15, 168);
            this.cbo_movimiento.Name = "cbo_movimiento";
            this.cbo_movimiento.Size = new System.Drawing.Size(195, 24);
            this.cbo_movimiento.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Movimiento";
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin.Location = new System.Drawing.Point(287, 117);
            this.txt_fecha_fin.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.Size = new System.Drawing.Size(265, 22);
            this.txt_fecha_fin.TabIndex = 5;
            // 
            // txt_fecha_ini
            // 
            this.txt_fecha_ini.Location = new System.Drawing.Point(12, 117);
            this.txt_fecha_ini.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_ini.Name = "txt_fecha_ini";
            this.txt_fecha_ini.Size = new System.Drawing.Size(265, 22);
            this.txt_fecha_ini.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha inicial";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(12, 52);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(198, 22);
            this.txt_usuario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre de usuario";
            // 
            // dat_sesiones
            // 
            this.dat_sesiones.AllowUserToAddRows = false;
            this.dat_sesiones.AllowUserToDeleteRows = false;
            this.dat_sesiones.AutoGenerateColumns = false;
            this.dat_sesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_sesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_sesiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.idAccionDataGridViewTextBoxColumn,
            this.accionDataGridViewTextBoxColumn,
            this.tablaDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn});
            this.dat_sesiones.DataSource = this.accionesRealizadasBindingSource;
            this.dat_sesiones.Location = new System.Drawing.Point(13, 220);
            this.dat_sesiones.Margin = new System.Windows.Forms.Padding(4);
            this.dat_sesiones.Name = "dat_sesiones";
            this.dat_sesiones.ReadOnly = true;
            this.dat_sesiones.Size = new System.Drawing.Size(774, 185);
            this.dat_sesiones.TabIndex = 58;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAccionDataGridViewTextBoxColumn
            // 
            this.idAccionDataGridViewTextBoxColumn.DataPropertyName = "Id_Accion";
            this.idAccionDataGridViewTextBoxColumn.HeaderText = "Id Accion";
            this.idAccionDataGridViewTextBoxColumn.Name = "idAccionDataGridViewTextBoxColumn";
            this.idAccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accionDataGridViewTextBoxColumn
            // 
            this.accionDataGridViewTextBoxColumn.DataPropertyName = "Accion";
            this.accionDataGridViewTextBoxColumn.HeaderText = "Accion";
            this.accionDataGridViewTextBoxColumn.Name = "accionDataGridViewTextBoxColumn";
            this.accionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablaDataGridViewTextBoxColumn
            // 
            this.tablaDataGridViewTextBoxColumn.DataPropertyName = "Tabla";
            this.tablaDataGridViewTextBoxColumn.HeaderText = "Tabla";
            this.tablaDataGridViewTextBoxColumn.Name = "tablaDataGridViewTextBoxColumn";
            this.tablaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accionesRealizadasBindingSource
            // 
            this.accionesRealizadasBindingSource.DataMember = "Acciones_Realizadas";
            this.accionesRealizadasBindingSource.DataSource = this.sCRDataSet;
            // 
            // sCRDataSet
            // 
            this.sCRDataSet.DataSetName = "SCRDataSet";
            this.sCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acciones_RealizadasTableAdapter
            // 
            this.acciones_RealizadasTableAdapter.ClearBeforeFill = true;
            // 
            // btn_imprimir_movimiento
            // 
            this.btn_imprimir_movimiento.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_movimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_movimiento.Location = new System.Drawing.Point(250, 167);
            this.btn_imprimir_movimiento.Name = "btn_imprimir_movimiento";
            this.btn_imprimir_movimiento.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_movimiento.TabIndex = 37;
            this.btn_imprimir_movimiento.UseVisualStyleBackColor = true;
            this.btn_imprimir_movimiento.Click += new System.EventHandler(this.btn_imprimir_movimiento_Click);
            // 
            // btn_buscar_movimientos
            // 
            this.btn_buscar_movimientos.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_movimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_movimientos.Location = new System.Drawing.Point(217, 168);
            this.btn_buscar_movimientos.Name = "btn_buscar_movimientos";
            this.btn_buscar_movimientos.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_movimientos.TabIndex = 36;
            this.btn_buscar_movimientos.UseVisualStyleBackColor = true;
            this.btn_buscar_movimientos.Click += new System.EventHandler(this.btn_buscar_movimientos_Click);
            // 
            // btn_imprimir_fechas
            // 
            this.btn_imprimir_fechas.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_fechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_fechas.Location = new System.Drawing.Point(593, 115);
            this.btn_imprimir_fechas.Name = "btn_imprimir_fechas";
            this.btn_imprimir_fechas.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_fechas.TabIndex = 33;
            this.btn_imprimir_fechas.UseVisualStyleBackColor = true;
            this.btn_imprimir_fechas.Click += new System.EventHandler(this.btn_imprimir_fechas_Click);
            // 
            // btn_buscar_fechas
            // 
            this.btn_buscar_fechas.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_fechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_fechas.Location = new System.Drawing.Point(559, 115);
            this.btn_buscar_fechas.Name = "btn_buscar_fechas";
            this.btn_buscar_fechas.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_fechas.TabIndex = 32;
            this.btn_buscar_fechas.UseVisualStyleBackColor = true;
            this.btn_buscar_fechas.Click += new System.EventHandler(this.btn_buscar_fechas_Click);
            // 
            // btn_imprimir_Usuario
            // 
            this.btn_imprimir_Usuario.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_Usuario.Location = new System.Drawing.Point(250, 50);
            this.btn_imprimir_Usuario.Name = "btn_imprimir_Usuario";
            this.btn_imprimir_Usuario.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_Usuario.TabIndex = 31;
            this.btn_imprimir_Usuario.UseVisualStyleBackColor = true;
            this.btn_imprimir_Usuario.Click += new System.EventHandler(this.btn_imprimir_Usuario_Click);
            // 
            // btn_buscar_Usuario
            // 
            this.btn_buscar_Usuario.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_Usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_Usuario.Location = new System.Drawing.Point(217, 51);
            this.btn_buscar_Usuario.Name = "btn_buscar_Usuario";
            this.btn_buscar_Usuario.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_Usuario.TabIndex = 30;
            this.btn_buscar_Usuario.UseVisualStyleBackColor = true;
            this.btn_buscar_Usuario.Click += new System.EventHandler(this.btn_buscar_Usuario_Click);
            // 
            // Bitacora_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dat_sesiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bitacora_Movimientos";
            this.Text = "Bitacora_Movimientos";
            this.Load += new System.EventHandler(this.Bitacora_Movimientos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accionesRealizadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_imprimir_fechas;
        private System.Windows.Forms.Button btn_buscar_fechas;
        private System.Windows.Forms.Button btn_imprimir_Usuario;
        private System.Windows.Forms.Button btn_buscar_Usuario;
        private System.Windows.Forms.DateTimePicker txt_fecha_fin;
        private System.Windows.Forms.DateTimePicker txt_fecha_ini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dat_sesiones;
        private System.Windows.Forms.Button btn_imprimir_movimiento;
        private System.Windows.Forms.Button btn_buscar_movimientos;
        private System.Windows.Forms.ComboBox cbo_movimiento;
        private System.Windows.Forms.Label label4;
        private SCRDataSet sCRDataSet;
        private System.Windows.Forms.BindingSource accionesRealizadasBindingSource;
        private SCRDataSetTableAdapters.Acciones_RealizadasTableAdapter acciones_RealizadasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
    }
}