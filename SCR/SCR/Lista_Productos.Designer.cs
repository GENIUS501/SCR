namespace SCR
{
    partial class Lista_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Productos));
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_buscar_nombre = new System.Windows.Forms.Button();
            this.txt_buscar_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dat_rol = new System.Windows.Forms.DataGridView();
            this.btn_buscar_codigo = new System.Windows.Forms.Button();
            this.txt_buscar_coodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dat_rol)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_consultar
            // 
            this.btn_consultar.Enabled = false;
            this.btn_consultar.Location = new System.Drawing.Point(270, 137);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(87, 34);
            this.btn_consultar.TabIndex = 26;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(189, 137);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 34);
            this.btn_eliminar.TabIndex = 25;
            this.btn_eliminar.Text = "Elliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(96, 137);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(86, 34);
            this.btn_modificar.TabIndex = 24;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(15, 137);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 34);
            this.btn_agregar.TabIndex = 23;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_buscar_nombre
            // 
            this.btn_buscar_nombre.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_nombre.Location = new System.Drawing.Point(155, 93);
            this.btn_buscar_nombre.Name = "btn_buscar_nombre";
            this.btn_buscar_nombre.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_nombre.TabIndex = 22;
            this.btn_buscar_nombre.UseVisualStyleBackColor = true;
            this.btn_buscar_nombre.Click += new System.EventHandler(this.btn_buscar_nombre_Click);
            // 
            // txt_buscar_nombre
            // 
            this.txt_buscar_nombre.Location = new System.Drawing.Point(15, 94);
            this.txt_buscar_nombre.Name = "txt_buscar_nombre";
            this.txt_buscar_nombre.Size = new System.Drawing.Size(134, 22);
            this.txt_buscar_nombre.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre del producto:";
            // 
            // dat_rol
            // 
            this.dat_rol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_rol.Location = new System.Drawing.Point(15, 177);
            this.dat_rol.Name = "dat_rol";
            this.dat_rol.ReadOnly = true;
            this.dat_rol.RowTemplate.Height = 24;
            this.dat_rol.Size = new System.Drawing.Size(733, 150);
            this.dat_rol.TabIndex = 19;
            this.dat_rol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_rol_CellClick);
            // 
            // btn_buscar_codigo
            // 
            this.btn_buscar_codigo.BackgroundImage = global::SCR.Properties.Resources.Img_Buscar;
            this.btn_buscar_codigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_codigo.Location = new System.Drawing.Point(152, 32);
            this.btn_buscar_codigo.Name = "btn_buscar_codigo";
            this.btn_buscar_codigo.Size = new System.Drawing.Size(27, 24);
            this.btn_buscar_codigo.TabIndex = 29;
            this.btn_buscar_codigo.UseVisualStyleBackColor = true;
            this.btn_buscar_codigo.Click += new System.EventHandler(this.btn_buscar_codigo_Click);
            // 
            // txt_buscar_coodigo
            // 
            this.txt_buscar_coodigo.Location = new System.Drawing.Point(12, 33);
            this.txt_buscar_coodigo.Name = "txt_buscar_coodigo";
            this.txt_buscar_coodigo.Size = new System.Drawing.Size(134, 22);
            this.txt_buscar_coodigo.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Codigo del producto:";
            // 
            // Lista_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(757, 337);
            this.Controls.Add(this.btn_buscar_codigo);
            this.Controls.Add(this.txt_buscar_coodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_buscar_nombre);
            this.Controls.Add(this.txt_buscar_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dat_rol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Lista_Productos";
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.Lista_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_rol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_buscar_nombre;
        private System.Windows.Forms.TextBox txt_buscar_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dat_rol;
        private System.Windows.Forms.Button btn_buscar_codigo;
        private System.Windows.Forms.TextBox txt_buscar_coodigo;
        private System.Windows.Forms.Label label2;
    }
}