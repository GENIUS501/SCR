namespace SCR
{
    partial class Mantenimiento_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cclave = new System.Windows.Forms.TextBox();
            this.lbl_cclave = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_genero = new System.Windows.Forms.ComboBox();
            this.cbo_rol = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sCRDataSet = new SCR.SCRDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cedula = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.rolesTableAdapter = new SCR.SCRDataSetTableAdapters.RolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula";
            // 
            // txt_cclave
            // 
            this.txt_cclave.Location = new System.Drawing.Point(193, 120);
            this.txt_cclave.Name = "txt_cclave";
            this.txt_cclave.PasswordChar = '.';
            this.txt_cclave.Size = new System.Drawing.Size(165, 22);
            this.txt_cclave.TabIndex = 7;
            // 
            // lbl_cclave
            // 
            this.lbl_cclave.AutoSize = true;
            this.lbl_cclave.Location = new System.Drawing.Point(190, 100);
            this.lbl_cclave.Name = "lbl_cclave";
            this.lbl_cclave.Size = new System.Drawing.Size(144, 17);
            this.lbl_cclave.TabIndex = 6;
            this.lbl_cclave.Text = "Confirmar contraseña";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(9, 120);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '.';
            this.txt_clave.Size = new System.Drawing.Size(167, 22);
            this.txt_clave.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contraseña";
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Location = new System.Drawing.Point(9, 52);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(167, 22);
            this.txt_nombre_usuario.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre de Usuario";
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(152, 168);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(128, 22);
            this.txt_apellido2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Segundo Apellido";
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.Location = new System.Drawing.Point(9, 168);
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(124, 22);
            this.txt_apellido1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Primer Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(9, 109);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(179, 22);
            this.txt_nombre.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nombre";
            // 
            // cbo_genero
            // 
            this.cbo_genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_genero.FormattingEnabled = true;
            this.cbo_genero.Location = new System.Drawing.Point(208, 109);
            this.cbo_genero.Name = "cbo_genero";
            this.cbo_genero.Size = new System.Drawing.Size(121, 24);
            this.cbo_genero.TabIndex = 18;
            // 
            // cbo_rol
            // 
            this.cbo_rol.DataSource = this.rolesBindingSource;
            this.cbo_rol.DisplayMember = "Nombre_Rol";
            this.cbo_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_rol.FormattingEnabled = true;
            this.cbo_rol.Location = new System.Drawing.Point(193, 52);
            this.cbo_rol.Name = "cbo_rol";
            this.cbo_rol.Size = new System.Drawing.Size(165, 24);
            this.cbo_rol.TabIndex = 19;
            this.cbo_rol.ValueMember = "Id_Rol";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.sCRDataSet;
            // 
            // sCRDataSet
            // 
            this.sCRDataSet.DataSetName = "SCRDataSet";
            this.sCRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rol";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cedula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbo_genero);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_apellido2);
            this.groupBox1.Controls.Add(this.txt_apellido1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 203);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(9, 52);
            this.txt_cedula.Mask = "000000000";
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(179, 22);
            this.txt_cedula.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_nombre_usuario);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbo_rol);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_clave);
            this.groupBox2.Controls.Add(this.txt_cclave);
            this.groupBox2.Controls.Add(this.lbl_cclave);
            this.groupBox2.Location = new System.Drawing.Point(377, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 203);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Acceso";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = global::SCR.Properties.Resources.Img_Acept;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(164, 243);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(128, 111);
            this.btn_aceptar.TabIndex = 24;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SCR.Properties.Resources.Img_Cancelar__2_;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(468, 243);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(128, 111);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // Mantenimiento_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 382);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mantenimiento_Usuarios";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Mantenimiento_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sCRDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cclave;
        private System.Windows.Forms.Label lbl_cclave;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_genero;
        private System.Windows.Forms.ComboBox cbo_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.MaskedTextBox txt_cedula;
        private SCRDataSet sCRDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private SCRDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
    }
}