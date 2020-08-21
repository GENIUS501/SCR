namespace SCR
{
    partial class Mantenimiento_Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Roles));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_rol = new System.Windows.Forms.TextBox();
            this.txt_nombre_rol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb_rep_punto = new System.Windows.Forms.CheckBox();
            this.chb_rep_faltante = new System.Windows.Forms.CheckBox();
            this.chb_rep_vencimiento = new System.Windows.Forms.CheckBox();
            this.chb_vencimiento = new System.Windows.Forms.CheckBox();
            this.chb_faltante_productos = new System.Windows.Forms.CheckBox();
            this.bnt_add_sup = new System.Windows.Forms.Button();
            this.lst_supervisores = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_supervisores = new System.Windows.Forms.ComboBox();
            this.chb_supervisores = new System.Windows.Forms.CheckBox();
            this.bnt_add_pun = new System.Windows.Forms.Button();
            this.lst_punto = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_punto = new System.Windows.Forms.ComboBox();
            this.bnt_add_prod = new System.Windows.Forms.Button();
            this.lst_productos = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_productos = new System.Windows.Forms.ComboBox();
            this.bnt_add_usu = new System.Windows.Forms.Button();
            this.lst_usuarios = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_usuarios = new System.Windows.Forms.ComboBox();
            this.bnt_add_rol = new System.Windows.Forms.Button();
            this.lst_roles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_roles = new System.Windows.Forms.ComboBox();
            this.chb_movimientos = new System.Windows.Forms.CheckBox();
            this.chb_sesiones = new System.Windows.Forms.CheckBox();
            this.chb_Punto_ventas = new System.Windows.Forms.CheckBox();
            this.chb_productos = new System.Windows.Forms.CheckBox();
            this.chb_usuarios = new System.Windows.Forms.CheckBox();
            this.chb_Roles = new System.Windows.Forms.CheckBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del rol";
            // 
            // txt_id_rol
            // 
            this.txt_id_rol.Location = new System.Drawing.Point(9, 52);
            this.txt_id_rol.Name = "txt_id_rol";
            this.txt_id_rol.Size = new System.Drawing.Size(100, 22);
            this.txt_id_rol.TabIndex = 1;
            this.txt_id_rol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_rol_KeyPress);
            // 
            // txt_nombre_rol
            // 
            this.txt_nombre_rol.Location = new System.Drawing.Point(11, 119);
            this.txt_nombre_rol.Name = "txt_nombre_rol";
            this.txt_nombre_rol.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre_rol.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del rol";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre_rol);
            this.groupBox1.Controls.Add(this.txt_id_rol);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 161);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del rol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb_rep_punto);
            this.groupBox2.Controls.Add(this.chb_rep_faltante);
            this.groupBox2.Controls.Add(this.chb_rep_vencimiento);
            this.groupBox2.Controls.Add(this.chb_vencimiento);
            this.groupBox2.Controls.Add(this.chb_faltante_productos);
            this.groupBox2.Controls.Add(this.bnt_add_sup);
            this.groupBox2.Controls.Add(this.lst_supervisores);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbo_supervisores);
            this.groupBox2.Controls.Add(this.chb_supervisores);
            this.groupBox2.Controls.Add(this.bnt_add_pun);
            this.groupBox2.Controls.Add(this.lst_punto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbo_punto);
            this.groupBox2.Controls.Add(this.bnt_add_prod);
            this.groupBox2.Controls.Add(this.lst_productos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbo_productos);
            this.groupBox2.Controls.Add(this.bnt_add_usu);
            this.groupBox2.Controls.Add(this.lst_usuarios);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbo_usuarios);
            this.groupBox2.Controls.Add(this.bnt_add_rol);
            this.groupBox2.Controls.Add(this.lst_roles);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbo_roles);
            this.groupBox2.Controls.Add(this.chb_movimientos);
            this.groupBox2.Controls.Add(this.chb_sesiones);
            this.groupBox2.Controls.Add(this.chb_Punto_ventas);
            this.groupBox2.Controls.Add(this.chb_productos);
            this.groupBox2.Controls.Add(this.chb_usuarios);
            this.groupBox2.Controls.Add(this.chb_Roles);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1050, 471);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos";
            // 
            // chb_rep_punto
            // 
            this.chb_rep_punto.AutoSize = true;
            this.chb_rep_punto.Location = new System.Drawing.Point(503, 309);
            this.chb_rep_punto.Name = "chb_rep_punto";
            this.chb_rep_punto.Size = new System.Drawing.Size(226, 21);
            this.chb_rep_punto.TabIndex = 38;
            this.chb_rep_punto.Text = "Reporte de punto venta-cliente";
            this.chb_rep_punto.UseVisualStyleBackColor = true;
            // 
            // chb_rep_faltante
            // 
            this.chb_rep_faltante.AutoSize = true;
            this.chb_rep_faltante.Location = new System.Drawing.Point(265, 306);
            this.chb_rep_faltante.Name = "chb_rep_faltante";
            this.chb_rep_faltante.Size = new System.Drawing.Size(232, 21);
            this.chb_rep_faltante.TabIndex = 37;
            this.chb_rep_faltante.Text = "Reporte de faltante de producto";
            this.chb_rep_faltante.UseVisualStyleBackColor = true;
            // 
            // chb_rep_vencimiento
            // 
            this.chb_rep_vencimiento.AutoSize = true;
            this.chb_rep_vencimiento.Location = new System.Drawing.Point(777, 259);
            this.chb_rep_vencimiento.Name = "chb_rep_vencimiento";
            this.chb_rep_vencimiento.Size = new System.Drawing.Size(260, 21);
            this.chb_rep_vencimiento.TabIndex = 36;
            this.chb_rep_vencimiento.Text = "Reporte de vencimiento de producto";
            this.chb_rep_vencimiento.UseVisualStyleBackColor = true;
            // 
            // chb_vencimiento
            // 
            this.chb_vencimiento.AutoSize = true;
            this.chb_vencimiento.Location = new System.Drawing.Point(503, 259);
            this.chb_vencimiento.Name = "chb_vencimiento";
            this.chb_vencimiento.Size = new System.Drawing.Size(268, 21);
            this.chb_vencimiento.TabIndex = 35;
            this.chb_vencimiento.Text = "Proceso de vencimiento de productos";
            this.chb_vencimiento.UseVisualStyleBackColor = true;
            // 
            // chb_faltante_productos
            // 
            this.chb_faltante_productos.AutoSize = true;
            this.chb_faltante_productos.Location = new System.Drawing.Point(265, 259);
            this.chb_faltante_productos.Name = "chb_faltante_productos";
            this.chb_faltante_productos.Size = new System.Drawing.Size(220, 21);
            this.chb_faltante_productos.TabIndex = 34;
            this.chb_faltante_productos.Text = "Proceso faltante de productos";
            this.chb_faltante_productos.UseVisualStyleBackColor = true;
            // 
            // bnt_add_sup
            // 
            this.bnt_add_sup.Enabled = false;
            this.bnt_add_sup.Location = new System.Drawing.Point(134, 306);
            this.bnt_add_sup.Name = "bnt_add_sup";
            this.bnt_add_sup.Size = new System.Drawing.Size(75, 23);
            this.bnt_add_sup.TabIndex = 33;
            this.bnt_add_sup.Text = "Agregar";
            this.bnt_add_sup.UseVisualStyleBackColor = true;
            this.bnt_add_sup.Click += new System.EventHandler(this.bnt_add_sup_Click);
            // 
            // lst_supervisores
            // 
            this.lst_supervisores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lst_supervisores.Enabled = false;
            this.lst_supervisores.GridLines = true;
            this.lst_supervisores.HideSelection = false;
            this.lst_supervisores.Location = new System.Drawing.Point(8, 350);
            this.lst_supervisores.Name = "lst_supervisores";
            this.lst_supervisores.Size = new System.Drawing.Size(129, 97);
            this.lst_supervisores.TabIndex = 32;
            this.lst_supervisores.UseCompatibleStateImageBehavior = false;
            this.lst_supervisores.View = System.Windows.Forms.View.Details;
            this.lst_supervisores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_supervisores_MouseDoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Accesos";
            this.columnHeader6.Width = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Agregar Accion";
            // 
            // cbo_supervisores
            // 
            this.cbo_supervisores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_supervisores.Enabled = false;
            this.cbo_supervisores.FormattingEnabled = true;
            this.cbo_supervisores.Items.AddRange(new object[] {
            "Agregar",
            "Modificar",
            "Eliminar",
            "Consultar"});
            this.cbo_supervisores.Location = new System.Drawing.Point(6, 306);
            this.cbo_supervisores.Name = "cbo_supervisores";
            this.cbo_supervisores.Size = new System.Drawing.Size(121, 24);
            this.cbo_supervisores.TabIndex = 30;
            // 
            // chb_supervisores
            // 
            this.chb_supervisores.AutoSize = true;
            this.chb_supervisores.Location = new System.Drawing.Point(8, 259);
            this.chb_supervisores.Margin = new System.Windows.Forms.Padding(4);
            this.chb_supervisores.Name = "chb_supervisores";
            this.chb_supervisores.Size = new System.Drawing.Size(227, 21);
            this.chb_supervisores.TabIndex = 28;
            this.chb_supervisores.Text = "Mantenimiento de supervisores";
            this.chb_supervisores.UseVisualStyleBackColor = true;
            this.chb_supervisores.CheckedChanged += new System.EventHandler(this.chb_supervisores_CheckedChanged);
            // 
            // bnt_add_pun
            // 
            this.bnt_add_pun.Enabled = false;
            this.bnt_add_pun.Location = new System.Drawing.Point(823, 87);
            this.bnt_add_pun.Name = "bnt_add_pun";
            this.bnt_add_pun.Size = new System.Drawing.Size(75, 23);
            this.bnt_add_pun.TabIndex = 27;
            this.bnt_add_pun.Text = "Agregar";
            this.bnt_add_pun.UseVisualStyleBackColor = true;
            this.bnt_add_pun.Click += new System.EventHandler(this.bnt_add_pun_Click);
            // 
            // lst_punto
            // 
            this.lst_punto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lst_punto.Enabled = false;
            this.lst_punto.GridLines = true;
            this.lst_punto.HideSelection = false;
            this.lst_punto.Location = new System.Drawing.Point(697, 131);
            this.lst_punto.Name = "lst_punto";
            this.lst_punto.Size = new System.Drawing.Size(129, 97);
            this.lst_punto.TabIndex = 26;
            this.lst_punto.UseCompatibleStateImageBehavior = false;
            this.lst_punto.View = System.Windows.Forms.View.Details;
            this.lst_punto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_punto_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Permisos";
            this.columnHeader4.Width = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Agregar Accion";
            // 
            // cbo_punto
            // 
            this.cbo_punto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_punto.Enabled = false;
            this.cbo_punto.FormattingEnabled = true;
            this.cbo_punto.Items.AddRange(new object[] {
            "Agregar",
            "Modificar",
            "Eliminar",
            "Consultar"});
            this.cbo_punto.Location = new System.Drawing.Point(695, 87);
            this.cbo_punto.Name = "cbo_punto";
            this.cbo_punto.Size = new System.Drawing.Size(121, 24);
            this.cbo_punto.TabIndex = 24;
            // 
            // bnt_add_prod
            // 
            this.bnt_add_prod.Enabled = false;
            this.bnt_add_prod.Location = new System.Drawing.Point(571, 88);
            this.bnt_add_prod.Name = "bnt_add_prod";
            this.bnt_add_prod.Size = new System.Drawing.Size(75, 23);
            this.bnt_add_prod.TabIndex = 23;
            this.bnt_add_prod.Text = "Agregar";
            this.bnt_add_prod.UseVisualStyleBackColor = true;
            this.bnt_add_prod.Click += new System.EventHandler(this.bnt_add_prod_Click);
            // 
            // lst_productos
            // 
            this.lst_productos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lst_productos.Enabled = false;
            this.lst_productos.GridLines = true;
            this.lst_productos.HideSelection = false;
            this.lst_productos.Location = new System.Drawing.Point(445, 132);
            this.lst_productos.Name = "lst_productos";
            this.lst_productos.Size = new System.Drawing.Size(129, 97);
            this.lst_productos.TabIndex = 22;
            this.lst_productos.UseCompatibleStateImageBehavior = false;
            this.lst_productos.View = System.Windows.Forms.View.Details;
            this.lst_productos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_productos_MouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Permisos";
            this.columnHeader3.Width = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Agregar Accion";
            // 
            // cbo_productos
            // 
            this.cbo_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_productos.Enabled = false;
            this.cbo_productos.FormattingEnabled = true;
            this.cbo_productos.Items.AddRange(new object[] {
            "Agregar",
            "Modificar",
            "Eliminar",
            "Consultar"});
            this.cbo_productos.Location = new System.Drawing.Point(443, 88);
            this.cbo_productos.Name = "cbo_productos";
            this.cbo_productos.Size = new System.Drawing.Size(121, 24);
            this.cbo_productos.TabIndex = 20;
            // 
            // bnt_add_usu
            // 
            this.bnt_add_usu.Enabled = false;
            this.bnt_add_usu.Location = new System.Drawing.Point(346, 88);
            this.bnt_add_usu.Name = "bnt_add_usu";
            this.bnt_add_usu.Size = new System.Drawing.Size(75, 23);
            this.bnt_add_usu.TabIndex = 19;
            this.bnt_add_usu.Text = "Agregar";
            this.bnt_add_usu.UseVisualStyleBackColor = true;
            this.bnt_add_usu.Click += new System.EventHandler(this.bnt_add_usu_Click);
            // 
            // lst_usuarios
            // 
            this.lst_usuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lst_usuarios.Enabled = false;
            this.lst_usuarios.GridLines = true;
            this.lst_usuarios.HideSelection = false;
            this.lst_usuarios.Location = new System.Drawing.Point(220, 132);
            this.lst_usuarios.Name = "lst_usuarios";
            this.lst_usuarios.Size = new System.Drawing.Size(129, 97);
            this.lst_usuarios.TabIndex = 18;
            this.lst_usuarios.UseCompatibleStateImageBehavior = false;
            this.lst_usuarios.View = System.Windows.Forms.View.Details;
            this.lst_usuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_usuarios_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Permisos";
            this.columnHeader2.Width = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Agregar Accion";
            // 
            // cbo_usuarios
            // 
            this.cbo_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_usuarios.Enabled = false;
            this.cbo_usuarios.FormattingEnabled = true;
            this.cbo_usuarios.Items.AddRange(new object[] {
            "Agregar",
            "Modificar",
            "Eliminar",
            "Consultar"});
            this.cbo_usuarios.Location = new System.Drawing.Point(218, 88);
            this.cbo_usuarios.Name = "cbo_usuarios";
            this.cbo_usuarios.Size = new System.Drawing.Size(121, 24);
            this.cbo_usuarios.TabIndex = 16;
            // 
            // bnt_add_rol
            // 
            this.bnt_add_rol.Enabled = false;
            this.bnt_add_rol.Location = new System.Drawing.Point(134, 88);
            this.bnt_add_rol.Name = "bnt_add_rol";
            this.bnt_add_rol.Size = new System.Drawing.Size(75, 23);
            this.bnt_add_rol.TabIndex = 15;
            this.bnt_add_rol.Text = "Agregar";
            this.bnt_add_rol.UseVisualStyleBackColor = true;
            this.bnt_add_rol.Click += new System.EventHandler(this.bnt_add_rol_Click);
            // 
            // lst_roles
            // 
            this.lst_roles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lst_roles.Enabled = false;
            this.lst_roles.GridLines = true;
            this.lst_roles.HideSelection = false;
            this.lst_roles.Location = new System.Drawing.Point(8, 132);
            this.lst_roles.Name = "lst_roles";
            this.lst_roles.Size = new System.Drawing.Size(129, 97);
            this.lst_roles.TabIndex = 14;
            this.lst_roles.UseCompatibleStateImageBehavior = false;
            this.lst_roles.View = System.Windows.Forms.View.Details;
            this.lst_roles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_roles_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Permisos";
            this.columnHeader1.Width = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Agregar Accion";
            // 
            // cbo_roles
            // 
            this.cbo_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_roles.Enabled = false;
            this.cbo_roles.FormattingEnabled = true;
            this.cbo_roles.Items.AddRange(new object[] {
            "Agregar",
            "Modificar",
            "Eliminar",
            "Consultar"});
            this.cbo_roles.Location = new System.Drawing.Point(6, 88);
            this.cbo_roles.Name = "cbo_roles";
            this.cbo_roles.Size = new System.Drawing.Size(121, 24);
            this.cbo_roles.TabIndex = 12;
            // 
            // chb_movimientos
            // 
            this.chb_movimientos.AutoSize = true;
            this.chb_movimientos.Location = new System.Drawing.Point(503, 350);
            this.chb_movimientos.Margin = new System.Windows.Forms.Padding(4);
            this.chb_movimientos.Name = "chb_movimientos";
            this.chb_movimientos.Size = new System.Drawing.Size(184, 21);
            this.chb_movimientos.TabIndex = 11;
            this.chb_movimientos.Text = "Bitacora de movimientos";
            this.chb_movimientos.UseVisualStyleBackColor = true;
            // 
            // chb_sesiones
            // 
            this.chb_sesiones.AutoSize = true;
            this.chb_sesiones.Location = new System.Drawing.Point(265, 350);
            this.chb_sesiones.Margin = new System.Windows.Forms.Padding(4);
            this.chb_sesiones.Name = "chb_sesiones";
            this.chb_sesiones.Size = new System.Drawing.Size(162, 21);
            this.chb_sesiones.TabIndex = 10;
            this.chb_sesiones.Text = "Bitacora de sesiones";
            this.chb_sesiones.UseVisualStyleBackColor = true;
            // 
            // chb_Punto_ventas
            // 
            this.chb_Punto_ventas.AutoSize = true;
            this.chb_Punto_ventas.Location = new System.Drawing.Point(695, 41);
            this.chb_Punto_ventas.Margin = new System.Windows.Forms.Padding(4);
            this.chb_Punto_ventas.Name = "chb_Punto_ventas";
            this.chb_Punto_ventas.Size = new System.Drawing.Size(288, 21);
            this.chb_Punto_ventas.TabIndex = 6;
            this.chb_Punto_ventas.Text = "Mantenimiento de Punto de venta-cliente";
            this.chb_Punto_ventas.UseVisualStyleBackColor = true;
            this.chb_Punto_ventas.CheckedChanged += new System.EventHandler(this.chb_Punto_ventas_CheckedChanged);
            // 
            // chb_productos
            // 
            this.chb_productos.AutoSize = true;
            this.chb_productos.Location = new System.Drawing.Point(445, 41);
            this.chb_productos.Margin = new System.Windows.Forms.Padding(4);
            this.chb_productos.Name = "chb_productos";
            this.chb_productos.Size = new System.Drawing.Size(209, 21);
            this.chb_productos.TabIndex = 4;
            this.chb_productos.Text = "Mantenimiento de productos";
            this.chb_productos.UseVisualStyleBackColor = true;
            this.chb_productos.CheckedChanged += new System.EventHandler(this.chb_funcionarios_CheckedChanged);
            // 
            // chb_usuarios
            // 
            this.chb_usuarios.AutoSize = true;
            this.chb_usuarios.Location = new System.Drawing.Point(220, 41);
            this.chb_usuarios.Margin = new System.Windows.Forms.Padding(4);
            this.chb_usuarios.Name = "chb_usuarios";
            this.chb_usuarios.Size = new System.Drawing.Size(202, 21);
            this.chb_usuarios.TabIndex = 2;
            this.chb_usuarios.Text = "Mantenimiento de Usuarios";
            this.chb_usuarios.UseVisualStyleBackColor = true;
            this.chb_usuarios.CheckedChanged += new System.EventHandler(this.chb_usuarios_CheckedChanged);
            // 
            // chb_Roles
            // 
            this.chb_Roles.AutoSize = true;
            this.chb_Roles.Location = new System.Drawing.Point(8, 41);
            this.chb_Roles.Margin = new System.Windows.Forms.Padding(4);
            this.chb_Roles.Name = "chb_Roles";
            this.chb_Roles.Size = new System.Drawing.Size(177, 21);
            this.chb_Roles.TabIndex = 0;
            this.chb_Roles.Text = "Mantenimiento de roles";
            this.chb_Roles.UseVisualStyleBackColor = true;
            this.chb_Roles.CheckedChanged += new System.EventHandler(this.chb_Roles_CheckedChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.BackgroundImage = global::SCR.Properties.Resources.Img_Cancelar__2_;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(934, 44);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(128, 111);
            this.btn_cancelar.TabIndex = 52;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackgroundImage = global::SCR.Properties.Resources.Img_Acept;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_aceptar.Location = new System.Drawing.Point(778, 44);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(128, 111);
            this.btn_aceptar.TabIndex = 51;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // Mantenimiento_Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1075, 703);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mantenimiento_Roles";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles y Permisos";
            this.Load += new System.EventHandler(this.Mantenimiento_Roles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_rol;
        private System.Windows.Forms.TextBox txt_nombre_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lst_roles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_roles;
        private System.Windows.Forms.CheckBox chb_movimientos;
        private System.Windows.Forms.CheckBox chb_sesiones;
        private System.Windows.Forms.CheckBox chb_Punto_ventas;
        private System.Windows.Forms.CheckBox chb_productos;
        private System.Windows.Forms.CheckBox chb_usuarios;
        private System.Windows.Forms.CheckBox chb_Roles;
        private System.Windows.Forms.Button bnt_add_usu;
        private System.Windows.Forms.ListView lst_usuarios;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_usuarios;
        private System.Windows.Forms.Button bnt_add_rol;
        private System.Windows.Forms.Button bnt_add_sup;
        private System.Windows.Forms.ListView lst_supervisores;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_supervisores;
        private System.Windows.Forms.CheckBox chb_supervisores;
        private System.Windows.Forms.Button bnt_add_pun;
        private System.Windows.Forms.ListView lst_punto;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_punto;
        private System.Windows.Forms.Button bnt_add_prod;
        private System.Windows.Forms.ListView lst_productos;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_productos;
        private System.Windows.Forms.CheckBox chb_vencimiento;
        private System.Windows.Forms.CheckBox chb_faltante_productos;
        private System.Windows.Forms.CheckBox chb_rep_punto;
        private System.Windows.Forms.CheckBox chb_rep_faltante;
        private System.Windows.Forms.CheckBox chb_rep_vencimiento;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
    }
}