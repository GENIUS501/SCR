namespace SCR
{
    partial class Lista_Supervisores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Supervisores));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_buscar_cedula = new System.Windows.Forms.MaskedTextBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dat_supervisores = new System.Windows.Forms.DataGridView();
            this.btn_buscar_cedula = new System.Windows.Forms.Button();
            this.btn_buscar_nombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_supervisores)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Cedula:";
            // 
            // txt_buscar_cedula
            // 
            this.txt_buscar_cedula.Location = new System.Drawing.Point(15, 29);
            this.txt_buscar_cedula.Mask = "000000000";
            this.txt_buscar_cedula.Name = "txt_buscar_cedula";
            this.txt_buscar_cedula.Size = new System.Drawing.Size(134, 22);
            this.txt_buscar_cedula.TabIndex = 37;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Enabled = false;
            this.btn_consultar.Location = new System.Drawing.Point(270, 143);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(87, 34);
            this.btn_consultar.TabIndex = 36;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(189, 143);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 34);
            this.btn_eliminar.TabIndex = 35;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(96, 143);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(86, 34);
            this.btn_modificar.TabIndex = 34;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(15, 143);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 34);
            this.btn_agregar.TabIndex = 33;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(15, 100);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(134, 22);
            this.txt_buscar.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            // 
            // dat_supervisores
            // 
            this.dat_supervisores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_supervisores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_supervisores.Location = new System.Drawing.Point(15, 182);
            this.dat_supervisores.Name = "dat_supervisores";
            this.dat_supervisores.ReadOnly = true;
            this.dat_supervisores.RowTemplate.Height = 24;
            this.dat_supervisores.Size = new System.Drawing.Size(840, 150);
            this.dat_supervisores.TabIndex = 29;
            this.dat_supervisores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_supervisores_CellClick);
            // 
            // btn_buscar_cedula
            // 
            this.btn_buscar_cedula.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_cedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_cedula.Location = new System.Drawing.Point(155, 29);
            this.btn_buscar_cedula.Name = "btn_buscar_cedula";
            this.btn_buscar_cedula.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_cedula.TabIndex = 39;
            this.btn_buscar_cedula.UseVisualStyleBackColor = true;
            this.btn_buscar_cedula.Click += new System.EventHandler(this.btn_buscar_cedula_Click);
            // 
            // btn_buscar_nombre
            // 
            this.btn_buscar_nombre.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_nombre.Location = new System.Drawing.Point(155, 99);
            this.btn_buscar_nombre.Name = "btn_buscar_nombre";
            this.btn_buscar_nombre.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_nombre.TabIndex = 32;
            this.btn_buscar_nombre.UseVisualStyleBackColor = true;
            this.btn_buscar_nombre.Click += new System.EventHandler(this.btn_buscar_nombre_Click);
            // 
            // Lista_Supervisores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 341);
            this.Controls.Add(this.btn_buscar_cedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_buscar_cedula);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_buscar_nombre);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dat_supervisores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Lista_Supervisores";
            this.Text = "Lista_Supervisores";
            this.Load += new System.EventHandler(this.Lista_Supervisores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_supervisores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar_cedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_buscar_cedula;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_buscar_nombre;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dat_supervisores;
    }
}