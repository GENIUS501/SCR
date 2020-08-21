namespace SCR
{
    partial class Mantenimiento_Supervisores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Supervisores));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grb_personales = new System.Windows.Forms.GroupBox();
            this.txt_cedula = new System.Windows.Forms.MaskedTextBox();
            this.grb_contacto = new System.Windows.Forms.GroupBox();
            this.txt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.grb_personales.SuspendLayout();
            this.grb_contacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(9, 103);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(222, 22);
            this.txt_nombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txt_apellido1
            // 
            this.txt_apellido1.Location = new System.Drawing.Point(9, 157);
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(100, 22);
            this.txt_apellido1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Primer Apellido";
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.Location = new System.Drawing.Point(128, 157);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(103, 22);
            this.txt_apellido2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(9, 103);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(165, 22);
            this.txt_correo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo";
            // 
            // grb_personales
            // 
            this.grb_personales.Controls.Add(this.txt_cedula);
            this.grb_personales.Controls.Add(this.label1);
            this.grb_personales.Controls.Add(this.label2);
            this.grb_personales.Controls.Add(this.txt_nombre);
            this.grb_personales.Controls.Add(this.label3);
            this.grb_personales.Controls.Add(this.txt_apellido2);
            this.grb_personales.Controls.Add(this.txt_apellido1);
            this.grb_personales.Controls.Add(this.label4);
            this.grb_personales.Location = new System.Drawing.Point(12, 24);
            this.grb_personales.Name = "grb_personales";
            this.grb_personales.Size = new System.Drawing.Size(249, 193);
            this.grb_personales.TabIndex = 12;
            this.grb_personales.TabStop = false;
            this.grb_personales.Text = "Datos Personales";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(9, 49);
            this.txt_cedula.Mask = "000000000";
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(222, 22);
            this.txt_cedula.TabIndex = 16;
            // 
            // grb_contacto
            // 
            this.grb_contacto.Controls.Add(this.txt_telefono);
            this.grb_contacto.Controls.Add(this.label5);
            this.grb_contacto.Controls.Add(this.txt_correo);
            this.grb_contacto.Controls.Add(this.label6);
            this.grb_contacto.Location = new System.Drawing.Point(278, 24);
            this.grb_contacto.Name = "grb_contacto";
            this.grb_contacto.Size = new System.Drawing.Size(195, 193);
            this.grb_contacto.TabIndex = 13;
            this.grb_contacto.TabStop = false;
            this.grb_contacto.Text = "Datos de Contacto";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(9, 50);
            this.txt_telefono.Mask = "00000000";
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(165, 22);
            this.txt_telefono.TabIndex = 12;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::SCR.Properties.Resources.Img_Cancelar__2_;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(287, 239);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(84, 68);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = global::SCR.Properties.Resources.Img_Acept;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(140, 239);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(87, 68);
            this.btn_aceptar.TabIndex = 14;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Mantenimiento_Supervisores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 327);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.grb_contacto);
            this.Controls.Add(this.grb_personales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mantenimiento_Supervisores";
            this.Text = "Mantenimiento_Supervisores";
            this.Load += new System.EventHandler(this.Mantenimiento_Supervisores_Load);
            this.grb_personales.ResumeLayout(false);
            this.grb_personales.PerformLayout();
            this.grb_contacto.ResumeLayout(false);
            this.grb_contacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grb_personales;
        private System.Windows.Forms.GroupBox grb_contacto;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.MaskedTextBox txt_cedula;
        private System.Windows.Forms.MaskedTextBox txt_telefono;
    }
}