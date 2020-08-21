namespace SCR
{
    partial class Proceso_Vencimiento_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proceso_Vencimiento_Productos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tiempo_reaccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha_reporte = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_supervisor = new System.Windows.Forms.ComboBox();
            this.supervisoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCRDataSet = new SCR.SCRDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_codigo = new System.Windows.Forms.MaskedTextBox();
            this.cbo_cliente = new System.Windows.Forms.ComboBox();
            this.puntoVentaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbo_zona = new System.Windows.Forms.ComboBox();
            this.zonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txt_unidades = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chb_3_meses = new System.Windows.Forms.CheckBox();
            this.chb_5_meses = new System.Windows.Forms.CheckBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.supervisoresTableAdapter = new SCR.SCRDataSetTableAdapters.SupervisoresTableAdapter();
            this.punto_Venta_ClienteTableAdapter = new SCR.SCRDataSetTableAdapters.Punto_Venta_ClienteTableAdapter();
            this.zonasTableAdapter = new SCR.SCRDataSetTableAdapters.ZonasTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supervisoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tiempo_reaccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_fecha_reporte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_fecha_vencimiento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de vencimiento";
            // 
            // txt_tiempo_reaccion
            // 
            this.txt_tiempo_reaccion.Location = new System.Drawing.Point(302, 52);
            this.txt_tiempo_reaccion.Name = "txt_tiempo_reaccion";
            this.txt_tiempo_reaccion.Size = new System.Drawing.Size(116, 22);
            this.txt_tiempo_reaccion.TabIndex = 6;
            this.txt_tiempo_reaccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tiempo_reaccion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de vencimiento del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiempo de reaccion";
            // 
            // txt_fecha_reporte
            // 
            this.txt_fecha_reporte.Location = new System.Drawing.Point(9, 110);
            this.txt_fecha_reporte.Name = "txt_fecha_reporte";
            this.txt_fecha_reporte.Size = new System.Drawing.Size(264, 22);
            this.txt_fecha_reporte.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha del reporte del vencimiento";
            // 
            // txt_fecha_vencimiento
            // 
            this.txt_fecha_vencimiento.Location = new System.Drawing.Point(9, 51);
            this.txt_fecha_vencimiento.Name = "txt_fecha_vencimiento";
            this.txt_fecha_vencimiento.Size = new System.Drawing.Size(264, 22);
            this.txt_fecha_vencimiento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Supervisor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Zona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cliente";
            // 
            // cbo_supervisor
            // 
            this.cbo_supervisor.DataSource = this.supervisoresBindingSource;
            this.cbo_supervisor.DisplayMember = "Nombre";
            this.cbo_supervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_supervisor.FormattingEnabled = true;
            this.cbo_supervisor.Location = new System.Drawing.Point(9, 52);
            this.cbo_supervisor.Name = "cbo_supervisor";
            this.cbo_supervisor.Size = new System.Drawing.Size(148, 24);
            this.cbo_supervisor.TabIndex = 7;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_codigo);
            this.groupBox2.Controls.Add(this.cbo_cliente);
            this.groupBox2.Controls.Add(this.cbo_zona);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbo_supervisor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(474, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 141);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Informativos";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(178, 107);
            this.txt_codigo.Mask = "000000000";
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(121, 22);
            this.txt_codigo.TabIndex = 20;
            // 
            // cbo_cliente
            // 
            this.cbo_cliente.DataSource = this.puntoVentaClienteBindingSource;
            this.cbo_cliente.DisplayMember = "Nombre";
            this.cbo_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cliente.FormattingEnabled = true;
            this.cbo_cliente.Location = new System.Drawing.Point(178, 53);
            this.cbo_cliente.Name = "cbo_cliente";
            this.cbo_cliente.Size = new System.Drawing.Size(121, 24);
            this.cbo_cliente.TabIndex = 11;
            this.cbo_cliente.ValueMember = "Cedula_juridica_fisica";
            // 
            // puntoVentaClienteBindingSource
            // 
            this.puntoVentaClienteBindingSource.DataMember = "Punto_Venta_Cliente";
            this.puntoVentaClienteBindingSource.DataSource = this.sCRDataSet;
            // 
            // cbo_zona
            // 
            this.cbo_zona.DataSource = this.zonasBindingSource;
            this.cbo_zona.DisplayMember = "Nombre_Zona";
            this.cbo_zona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_zona.FormattingEnabled = true;
            this.cbo_zona.Location = new System.Drawing.Point(9, 107);
            this.cbo_zona.Name = "cbo_zona";
            this.cbo_zona.Size = new System.Drawing.Size(148, 24);
            this.cbo_zona.TabIndex = 10;
            this.cbo_zona.ValueMember = "Id_Zona";
            // 
            // zonasBindingSource
            // 
            this.zonasBindingSource.DataMember = "Zonas";
            this.zonasBindingSource.DataSource = this.sCRDataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Codigo";
            // 
            // txt_unidades
            // 
            this.txt_unidades.Location = new System.Drawing.Point(7, 51);
            this.txt_unidades.Name = "txt_unidades";
            this.txt_unidades.Size = new System.Drawing.Size(100, 22);
            this.txt_unidades.TabIndex = 9;
            this.txt_unidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_unidades_KeyPress);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(9, 106);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(198, 85);
            this.txt_descripcion.TabIndex = 10;
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(222, 106);
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(196, 85);
            this.txt_observaciones.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Unidades*SKU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Descripcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Observaciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_unidades);
            this.groupBox3.Controls.Add(this.txt_descripcion);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_observaciones);
            this.groupBox3.Location = new System.Drawing.Point(12, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 202);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del producto vencido";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chb_3_meses);
            this.groupBox4.Controls.Add(this.chb_5_meses);
            this.groupBox4.Location = new System.Drawing.Point(474, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 93);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de seguimiento";
            // 
            // chb_3_meses
            // 
            this.chb_3_meses.AutoSize = true;
            this.chb_3_meses.Location = new System.Drawing.Point(9, 20);
            this.chb_3_meses.Name = "chb_3_meses";
            this.chb_3_meses.Size = new System.Drawing.Size(165, 21);
            this.chb_3_meses.TabIndex = 19;
            this.chb_3_meses.Text = "Seguimiento 3 meses";
            this.chb_3_meses.UseVisualStyleBackColor = true;
            // 
            // chb_5_meses
            // 
            this.chb_5_meses.AutoSize = true;
            this.chb_5_meses.Location = new System.Drawing.Point(9, 52);
            this.chb_5_meses.Name = "chb_5_meses";
            this.chb_5_meses.Size = new System.Drawing.Size(165, 21);
            this.chb_5_meses.TabIndex = 18;
            this.chb_5_meses.Text = "Seguimiento 5 meses";
            this.chb_5_meses.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SCR.Properties.Resources.Img_Cancelar__2_;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(366, 389);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(84, 68);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::SCR.Properties.Resources.Img_Acept;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar.Location = new System.Drawing.Point(234, 389);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(87, 68);
            this.btn_agregar.TabIndex = 21;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCR.Properties.Resources.Logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(507, 294);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // supervisoresTableAdapter
            // 
            this.supervisoresTableAdapter.ClearBeforeFill = true;
            // 
            // punto_Venta_ClienteTableAdapter
            // 
            this.punto_Venta_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // zonasTableAdapter
            // 
            this.zonasTableAdapter.ClearBeforeFill = true;
            // 
            // Proceso_Vencimiento_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proceso_Vencimiento_Productos";
            this.Text = "Proceso_Vencimiento_Productos";
            this.Load += new System.EventHandler(this.Proceso_Vencimiento_Productos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supervisoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_fecha_vencimiento;
        private System.Windows.Forms.DateTimePicker txt_fecha_reporte;
        private System.Windows.Forms.TextBox txt_tiempo_reaccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_supervisor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_unidades;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbo_zona;
        private System.Windows.Forms.ComboBox cbo_cliente;
        private System.Windows.Forms.MaskedTextBox txt_codigo;
        private System.Windows.Forms.CheckBox chb_3_meses;
        private System.Windows.Forms.CheckBox chb_5_meses;
        private SCRDataSet sCRDataSet;
        private System.Windows.Forms.BindingSource supervisoresBindingSource;
        private SCRDataSetTableAdapters.SupervisoresTableAdapter supervisoresTableAdapter;
        private System.Windows.Forms.BindingSource puntoVentaClienteBindingSource;
        private SCRDataSetTableAdapters.Punto_Venta_ClienteTableAdapter punto_Venta_ClienteTableAdapter;
        private System.Windows.Forms.BindingSource zonasBindingSource;
        private SCRDataSetTableAdapters.ZonasTableAdapter zonasTableAdapter;
    }
}