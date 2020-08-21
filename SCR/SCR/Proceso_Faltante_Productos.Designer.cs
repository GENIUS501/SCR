namespace SCR
{
    partial class Proceso_Faltante_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proceso_Faltante_Productos));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_punto_venta = new System.Windows.Forms.ComboBox();
            this.puntoVentaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCRDataSet = new SCR.SCRDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbo_zona = new System.Windows.Forms.ComboBox();
            this.zonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chb_sugerido = new System.Windows.Forms.CheckBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fecha_mes = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zonasTableAdapter = new SCR.SCRDataSetTableAdapters.ZonasTableAdapter();
            this.punto_Venta_ClienteTableAdapter = new SCR.SCRDataSetTableAdapters.Punto_Venta_ClienteTableAdapter();
            this.txt_codigo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Punto de venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zona Geografica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.txt_marca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 330);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(9, 117);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(228, 22);
            this.txt_nombre.TabIndex = 18;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Enabled = false;
            this.txt_descripcion.Location = new System.Drawing.Point(9, 177);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(228, 125);
            this.txt_descripcion.TabIndex = 17;
            // 
            // txt_marca
            // 
            this.txt_marca.Enabled = false;
            this.txt_marca.Location = new System.Drawing.Point(137, 52);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(100, 22);
            this.txt_marca.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo";
            // 
            // cbo_punto_venta
            // 
            this.cbo_punto_venta.DataSource = this.puntoVentaClienteBindingSource;
            this.cbo_punto_venta.DisplayMember = "Nombre";
            this.cbo_punto_venta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_punto_venta.FormattingEnabled = true;
            this.cbo_punto_venta.Location = new System.Drawing.Point(185, 50);
            this.cbo_punto_venta.Name = "cbo_punto_venta";
            this.cbo_punto_venta.Size = new System.Drawing.Size(121, 24);
            this.cbo_punto_venta.TabIndex = 13;
            this.cbo_punto_venta.ValueMember = "Cedula_juridica_fisica";
            // 
            // puntoVentaClienteBindingSource
            // 
            this.puntoVentaClienteBindingSource.DataMember = "Punto_Venta_Cliente";
            this.puntoVentaClienteBindingSource.DataSource = this.sCRDataSet;
            // 
            // sCRDataSet
            // 
            this.sCRDataSet.DataSetName = "SCRDataSet";
            this.sCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbo_zona);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbo_punto_venta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(306, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 101);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de punto venta";
            // 
            // cbo_zona
            // 
            this.cbo_zona.DataSource = this.zonasBindingSource;
            this.cbo_zona.DisplayMember = "Nombre_Zona";
            this.cbo_zona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_zona.FormattingEnabled = true;
            this.cbo_zona.Location = new System.Drawing.Point(9, 51);
            this.cbo_zona.Name = "cbo_zona";
            this.cbo_zona.Size = new System.Drawing.Size(161, 24);
            this.cbo_zona.TabIndex = 14;
            this.cbo_zona.ValueMember = "Id_Zona";
            // 
            // zonasBindingSource
            // 
            this.zonasBindingSource.DataMember = "Zonas";
            this.zonasBindingSource.DataSource = this.sCRDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chb_sugerido);
            this.groupBox3.Controls.Add(this.txt_cantidad);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(306, 181);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otros datos";
            // 
            // chb_sugerido
            // 
            this.chb_sugerido.AutoSize = true;
            this.chb_sugerido.Location = new System.Drawing.Point(142, 59);
            this.chb_sugerido.Name = "chb_sugerido";
            this.chb_sugerido.Size = new System.Drawing.Size(87, 21);
            this.chb_sugerido.TabIndex = 8;
            this.chb_sugerido.Text = "Sugerido";
            this.chb_sugerido.UseVisualStyleBackColor = true;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(9, 57);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 22);
            this.txt_cantidad.TabIndex = 7;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha Mes";
            // 
            // txt_fecha_mes
            // 
            this.txt_fecha_mes.Location = new System.Drawing.Point(12, 30);
            this.txt_fecha_mes.Name = "txt_fecha_mes";
            this.txt_fecha_mes.Size = new System.Drawing.Size(100, 22);
            this.txt_fecha_mes.TabIndex = 17;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SCR.Properties.Resources.Img_Cancelar__2_;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(343, 441);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(84, 68);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = global::SCR.Properties.Resources.Img_Acept;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(162, 441);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(87, 68);
            this.btn_aceptar.TabIndex = 18;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCR.Properties.Resources.Logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(343, 295);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // zonasTableAdapter
            // 
            this.zonasTableAdapter.ClearBeforeFill = true;
            // 
            // punto_Venta_ClienteTableAdapter
            // 
            this.punto_Venta_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(9, 52);
            this.txt_codigo.Mask = "000000000";
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_codigo.TabIndex = 19;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // Proceso_Faltante_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_fecha_mes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proceso_Faltante_Productos";
            this.Text = "Proceso_Faltante_Productos";
            this.Load += new System.EventHandler(this.Proceso_Faltante_Productos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zonasBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_punto_venta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chb_sugerido;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fecha_mes;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbo_zona;
        private SCRDataSet sCRDataSet;
        private System.Windows.Forms.BindingSource zonasBindingSource;
        private SCRDataSetTableAdapters.ZonasTableAdapter zonasTableAdapter;
        private System.Windows.Forms.BindingSource puntoVentaClienteBindingSource;
        private SCRDataSetTableAdapters.Punto_Venta_ClienteTableAdapter punto_Venta_ClienteTableAdapter;
        private System.Windows.Forms.MaskedTextBox txt_codigo;
    }
}