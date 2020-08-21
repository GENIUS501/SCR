namespace SCR
{
    partial class Bitacora_Ingreso_Salida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora_Ingreso_Salida));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_imprimir_fecha = new System.Windows.Forms.Button();
            this.btn_buscar_fecha = new System.Windows.Forms.Button();
            this.btn_imprimir_usuario = new System.Windows.Forms.Button();
            this.btn_buscar_usuario = new System.Windows.Forms.Button();
            this.txt_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.txt_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dat_sesiones = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresosSalidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCRDataSet = new SCR.SCRDataSet();
            this.ingresos_SalidasTableAdapter = new SCR.SCRDataSetTableAdapters.Ingresos_SalidasTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sesiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosSalidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_imprimir_fecha);
            this.groupBox1.Controls.Add(this.btn_buscar_fecha);
            this.groupBox1.Controls.Add(this.btn_imprimir_usuario);
            this.groupBox1.Controls.Add(this.btn_buscar_usuario);
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
            this.groupBox1.Size = new System.Drawing.Size(633, 164);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // btn_imprimir_fecha
            // 
            this.btn_imprimir_fecha.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_fecha.Location = new System.Drawing.Point(593, 115);
            this.btn_imprimir_fecha.Name = "btn_imprimir_fecha";
            this.btn_imprimir_fecha.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_fecha.TabIndex = 33;
            this.btn_imprimir_fecha.UseVisualStyleBackColor = true;
            this.btn_imprimir_fecha.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_buscar_fecha
            // 
            this.btn_buscar_fecha.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_fecha.Location = new System.Drawing.Point(559, 115);
            this.btn_buscar_fecha.Name = "btn_buscar_fecha";
            this.btn_buscar_fecha.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_fecha.TabIndex = 32;
            this.btn_buscar_fecha.UseVisualStyleBackColor = true;
            this.btn_buscar_fecha.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_imprimir_usuario
            // 
            this.btn_imprimir_usuario.BackgroundImage = global::SCR.Properties.Resources.Img_Imprimir;
            this.btn_imprimir_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir_usuario.Location = new System.Drawing.Point(250, 50);
            this.btn_imprimir_usuario.Name = "btn_imprimir_usuario";
            this.btn_imprimir_usuario.Size = new System.Drawing.Size(27, 24);
            this.btn_imprimir_usuario.TabIndex = 31;
            this.btn_imprimir_usuario.UseVisualStyleBackColor = true;
            this.btn_imprimir_usuario.Click += new System.EventHandler(this.btn_imprimir_usuario_Click);
            // 
            // btn_buscar_usuario
            // 
            this.btn_buscar_usuario.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_usuario.Location = new System.Drawing.Point(217, 50);
            this.btn_buscar_usuario.Name = "btn_buscar_usuario";
            this.btn_buscar_usuario.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_usuario.TabIndex = 30;
            this.btn_buscar_usuario.UseVisualStyleBackColor = true;
            this.btn_buscar_usuario.Click += new System.EventHandler(this.btn_buscar_usuario_Click);
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
            this.idDataGridViewTextBoxColumn,
            this.fechaHoraIngresoDataGridViewTextBoxColumn,
            this.fechaHoraSalidaDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn});
            this.dat_sesiones.DataSource = this.ingresosSalidasBindingSource;
            this.dat_sesiones.Location = new System.Drawing.Point(13, 185);
            this.dat_sesiones.Margin = new System.Windows.Forms.Padding(4);
            this.dat_sesiones.Name = "dat_sesiones";
            this.dat_sesiones.ReadOnly = true;
            this.dat_sesiones.Size = new System.Drawing.Size(774, 185);
            this.dat_sesiones.TabIndex = 56;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraIngresoDataGridViewTextBoxColumn
            // 
            this.fechaHoraIngresoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Hora_Ingreso";
            this.fechaHoraIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha_Hora_Ingreso";
            this.fechaHoraIngresoDataGridViewTextBoxColumn.Name = "fechaHoraIngresoDataGridViewTextBoxColumn";
            this.fechaHoraIngresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHoraSalidaDataGridViewTextBoxColumn
            // 
            this.fechaHoraSalidaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Hora_Salida";
            this.fechaHoraSalidaDataGridViewTextBoxColumn.HeaderText = "Fecha_Hora_Salida";
            this.fechaHoraSalidaDataGridViewTextBoxColumn.Name = "fechaHoraSalidaDataGridViewTextBoxColumn";
            this.fechaHoraSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre_Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingresosSalidasBindingSource
            // 
            this.ingresosSalidasBindingSource.DataMember = "Ingresos_Salidas";
            this.ingresosSalidasBindingSource.DataSource = this.sCRDataSet;
            // 
            // sCRDataSet
            // 
            this.sCRDataSet.DataSetName = "SCRDataSet";
            this.sCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingresos_SalidasTableAdapter
            // 
            this.ingresos_SalidasTableAdapter.ClearBeforeFill = true;
            // 
            // Bitacora_Ingreso_Salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dat_sesiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bitacora_Ingreso_Salida";
            this.Text = "Bitacora_Ingreso_Salida";
            this.Load += new System.EventHandler(this.Bitacora_Ingreso_Salida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sesiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosSalidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txt_fecha_fin;
        private System.Windows.Forms.DateTimePicker txt_fecha_ini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dat_sesiones;
        private System.Windows.Forms.Button btn_imprimir_fecha;
        private System.Windows.Forms.Button btn_buscar_fecha;
        private System.Windows.Forms.Button btn_imprimir_usuario;
        private System.Windows.Forms.Button btn_buscar_usuario;
        private SCRDataSet sCRDataSet;
        private System.Windows.Forms.BindingSource ingresosSalidasBindingSource;
        private SCRDataSetTableAdapters.Ingresos_SalidasTableAdapter ingresos_SalidasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
    }
}