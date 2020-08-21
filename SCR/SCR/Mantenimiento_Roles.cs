using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCR
{
    public partial class Mantenimiento_Roles : Form
    {
        public string Accion { get; set; }
        public int Id_Rol { get; set; }
        public string Usuario { get; set; }
        Gestor Negocios;
        Accesos Permi;
        Roles Rol;
        public Mantenimiento_Roles()
        {
            InitializeComponent();
        }

        #region llenar Permisos
        private void Llenar()
        {
            try
            {
                Negocios = new Gestor();
                Rol = new Roles();
                Rol = Negocios.Mostrar_Rol(Id_Rol);
                this.txt_id_rol.Text = Rol.Id_Rol.ToString();
                this.txt_nombre_rol.Text = Rol.Nombre_Rol;
                int numero_modulo = 0;
                Permi = new Accesos();
                #region Roles 1
                numero_modulo = 1;
                ////////Roles//1////////////////////////////////////
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.cbo_roles.Enabled = true;
                    this.bnt_add_rol.Enabled = true;
                    this.lst_roles.Enabled = true;
                    this.chb_Roles.Checked = true;
                    Permi = new Accesos();
                    //Agregar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol,numero_modulo,"Agregar");
                    if(Permi.Modulo>0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_roles.Items.Add(lista);
                    }
                    //Modificar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Modificar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_roles.Items.Add(lista);
                    }
                    //Eliminar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Eliminar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_roles.Items.Add(lista);
                    }
                    //Consultar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Consultar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_roles.Items.Add(lista);
                    }
                }
                #endregion

                #region Usuarios 2
                ////////Usuarios//2////////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 2;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.cbo_usuarios.Enabled = true;
                    this.bnt_add_usu.Enabled = true;
                    this.lst_usuarios.Enabled = true;
                    this.chb_usuarios.Checked = true;
                    Permi = new Accesos();
                    //Agregar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Agregar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_usuarios.Items.Add(lista);
                    }
                    //Modificar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Modificar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_usuarios.Items.Add(lista);
                    }
                    //Eliminar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Eliminar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_usuarios.Items.Add(lista);
                    }
                    //Consultar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Consultar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_usuarios.Items.Add(lista);
                    }
                }
                #endregion

                #region Productos 3
                ////////Productos//3////////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 3;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.cbo_productos.Enabled = true;
                    this.bnt_add_prod.Enabled = true;
                    this.lst_productos.Enabled = true;
                    this.chb_productos.Checked = true;
                    Permi = new Accesos();
                    //Agregar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Agregar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_productos.Items.Add(lista);
                    }
                    //Modificar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Modificar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_productos.Items.Add(lista);
                    }
                    //Eliminar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Eliminar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_productos.Items.Add(lista);
                    }
                    //Consultar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Consultar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_productos.Items.Add(lista);
                    }
                }
                #endregion

                #region Punto_Venta 4
                ////////Punto_Venta//4////////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 4;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.cbo_punto.Enabled = true;
                    this.bnt_add_pun.Enabled = true;
                    this.lst_punto.Enabled = true;
                    this.chb_Punto_ventas.Checked = true;
                    Permi = new Accesos();
                    //Agregar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Agregar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_punto.Items.Add(lista);
                    }
                    //Modificar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Modificar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_punto.Items.Add(lista);
                    }
                    //Eliminar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Eliminar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_punto.Items.Add(lista);
                    }
                    //Consultar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Consultar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_punto.Items.Add(lista);
                    }
                }
                #endregion

                #region Supervisores 5 
                ////////Supervisores//5////////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 5;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.cbo_supervisores.Enabled = true;
                    this.bnt_add_sup.Enabled = true;
                    this.lst_supervisores.Enabled = true;
                    this.chb_supervisores.Checked = true;
                    Permi = new Accesos();
                    //Agregar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Agregar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_supervisores.Items.Add(lista);
                    }
                    //Modificar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Modificar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_supervisores.Items.Add(lista);
                    }
                    //Eliminar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Eliminar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_supervisores.Items.Add(lista);
                    }
                    //Consultar
                    Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo, "Consultar");
                    if (Permi.Modulo > 0)
                    {
                        ListViewItem lista = new ListViewItem(Permi.Accion);
                        lst_supervisores.Items.Add(lista);
                    }
                }
                #endregion

                #region Proceso Faltante Productos 6 
                ////////Proceso Faltante Productos//6////////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 6;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.chb_faltante_productos.Checked = true;
                }
                else
                {

                }
                #endregion

                #region Proceso vencimiento Productos 7
                ////////Proceso vencimiento Productos//7////////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 7;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.chb_vencimiento.Checked = true;
                }
                else
                {

                }
                #endregion

                #region Reporte vencimiento Productos 8
                ////////Reporte vencimiento Productos//8////////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 8;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.chb_rep_vencimiento.Checked = true;
                }
                else
                {

                }
                #endregion

                #region Reporte faltante de productos 9
                ////////Reporte faltante de productos//9////////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 9;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.chb_rep_faltante.Checked = true;
                }
                else
                {

                }
                #endregion

                #region Reporte de Punto de venta 10
                ////////Reporte de Punto de venta//10////////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 10;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.chb_rep_punto.Checked = true;
                }
                else
                {

                }
                #endregion

                #region Bitacora Sesiones 11
                ////////Bitacora Sesiones//11///////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 11;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.chb_sesiones.Checked = true;
                }
                else
                {

                }
                #endregion

                #region Bitacora Movimiento 12
                ////////Bitacora Movimiento//12///////////////////////////////////
                Permi = new Accesos();
                numero_modulo = 12;
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, numero_modulo);
                if (Permi.Modulo > 0)
                {
                    this.chb_movimientos.Checked = true;
                }
                else
                {

                }
                #endregion

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        private void Mantenimiento_Roles_Load(object sender, EventArgs e)
        {
            try
            {
                if(Accion == "M"||Accion=="E" || Accion == "C")
                {
                    this.txt_id_rol.Enabled = false;
                    Llenar();
                    if(Accion == "E" || Accion == "C")
                    {
                        this.txt_nombre_rol.Enabled = false;
                        this.chb_faltante_productos.Enabled = false;
                        this.chb_movimientos.Enabled = false;
                        this.chb_productos.Enabled = false;
                        this.chb_Punto_ventas.Enabled = false;
                        this.chb_rep_faltante.Enabled = false;
                        this.chb_rep_punto.Enabled = false;
                        this.chb_rep_vencimiento.Enabled = false;
                        this.chb_Roles.Enabled = false;
                        this.chb_sesiones.Enabled = false;
                        this.chb_supervisores.Enabled = false;
                        this.chb_usuarios.Enabled = false;
                        this.chb_vencimiento.Enabled = false;
                        this.lst_productos.Enabled = true;
                        this.lst_punto.Enabled = true;
                        this.lst_roles.Enabled = true;
                        this.lst_supervisores.Enabled = true;
                        this.lst_usuarios.Enabled = true;
                        this.bnt_add_prod.Enabled = false;
                        this.bnt_add_pun.Enabled = false;
                        this.bnt_add_rol.Enabled = false;
                        this.bnt_add_sup.Enabled = false;
                        this.bnt_add_usu.Enabled = false;
                        this.cbo_productos.Enabled = false;
                        this.cbo_punto.Enabled = false;
                        this.cbo_roles.Enabled = false;
                        this.cbo_supervisores.Enabled = false;
                        this.cbo_usuarios.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void chb_Roles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_Roles.Checked == true)
                {
                    this.cbo_roles.Enabled = true;
                    this.lst_roles.Enabled = true;
                    this.bnt_add_rol.Enabled = true;
                }
                else if (this.chb_Roles.Checked == false)
                {
                    this.cbo_roles.Enabled = false;
                    this.lst_roles.Enabled = false;
                    this.bnt_add_rol.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void chb_usuarios_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_usuarios.Checked == true)
                {
                    this.cbo_usuarios.Enabled = true;
                    this.lst_usuarios.Enabled = true;
                    this.bnt_add_usu.Enabled = true;
                }
                else if (this.chb_usuarios.Checked == false)
                {
                    this.cbo_usuarios.Enabled = false;
                    this.lst_usuarios.Enabled = false;
                    this.bnt_add_usu.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_funcionarios_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_productos.Checked == true)
                {
                    this.cbo_productos.Enabled = true;
                    this.lst_productos.Enabled = true;
                    this.bnt_add_prod.Enabled = true;
                }
                else if (this.chb_productos.Checked == false)
                {
                    this.cbo_productos.Enabled = false;
                    this.lst_productos.Enabled = false;
                    this.bnt_add_prod.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_Punto_ventas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_Punto_ventas.Checked == true)
                {
                    this.cbo_punto.Enabled = true;
                    this.lst_punto.Enabled = true;
                    this.bnt_add_pun.Enabled = true;
                }
                else if (this.chb_Punto_ventas.Checked == false)
                {
                    this.cbo_punto.Enabled = false;
                    this.lst_punto.Enabled = false;
                    this.bnt_add_pun.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chb_supervisores_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chb_supervisores.Checked == true)
                {
                    this.cbo_supervisores.Enabled = true;
                    this.lst_supervisores.Enabled = true;
                    this.bnt_add_sup.Enabled = true;
                }
                else if (this.chb_supervisores.Checked == false)
                {
                    this.cbo_supervisores.Enabled = false;
                    this.lst_supervisores.Enabled = false;
                    this.bnt_add_sup.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Agregar listas
        private void bnt_add_rol_Click(object sender, EventArgs e)
        {
            try
            {
                bool Agregar = false;
                bool Consultar = false;
                bool Eliminar = false;
                bool Modificar = false;

                foreach (ListViewItem lista in lst_roles.Items)
                {
                    switch (lista.SubItems[0].Text)
                    {
                        case "Agregar":
                            Agregar = true;
                        break;

                        case "Modificar":
                            Modificar = true;
                        break;

                        case "Consultar":
                            Consultar = true;
                        break;

                        case "Eliminar":
                            Eliminar = true;
                        break;
                        
                    }
                }
                if (Agregar == false && cbo_roles.SelectedItem.ToString() == "Agregar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_roles.SelectedItem.ToString());
                    lst_roles.Items.Add(lista);
                }
                if (Modificar == false && cbo_roles.SelectedItem.ToString() == "Modificar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_roles.SelectedItem.ToString());
                    lst_roles.Items.Add(lista);
                }
                if (Consultar == false && cbo_roles.SelectedItem.ToString() == "Consultar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_roles.SelectedItem.ToString());
                    lst_roles.Items.Add(lista);
                }
                if (Eliminar == false && cbo_roles.SelectedItem.ToString() == "Eliminar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_roles.SelectedItem.ToString());
                    lst_roles.Items.Add(lista);
                }
                Agregar = false;
                Modificar = false;
                Consultar = false;
                Eliminar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void bnt_add_usu_Click(object sender, EventArgs e)
        {
            try
            {
                bool Agregar = false;
                bool Consultar = false;
                bool Eliminar = false;
                bool Modificar = false;

                foreach (ListViewItem lista in lst_usuarios.Items)
                {
                    switch (lista.SubItems[0].Text)
                    {
                        case "Agregar":
                            Agregar = true;
                            break;

                        case "Modificar":
                            Modificar = true;
                            break;

                        case "Consultar":
                            Consultar = true;
                            break;

                        case "Eliminar":
                            Eliminar = true;
                            break;

                    }
                }
                if (Agregar == false && cbo_usuarios.SelectedItem.ToString() == "Agregar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_usuarios.SelectedItem.ToString());
                    lst_usuarios.Items.Add(lista);
                }
                if (Modificar == false && cbo_usuarios.SelectedItem.ToString() == "Modificar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_usuarios.SelectedItem.ToString());
                    lst_usuarios.Items.Add(lista);
                }
                if (Consultar == false && cbo_usuarios.SelectedItem.ToString() == "Consultar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_usuarios.SelectedItem.ToString());
                    lst_usuarios.Items.Add(lista);
                }
                if (Eliminar == false && cbo_usuarios.SelectedItem.ToString() == "Eliminar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_usuarios.SelectedItem.ToString());
                    lst_usuarios.Items.Add(lista);
                }
                Agregar = false;
                Modificar = false;
                Consultar = false;
                Eliminar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnt_add_prod_Click(object sender, EventArgs e)
        {
            try
            {
                bool Agregar = false;
                bool Consultar = false;
                bool Eliminar = false;
                bool Modificar = false;

                foreach (ListViewItem lista in lst_productos.Items)
                {
                    switch (lista.SubItems[0].Text)
                    {
                        case "Agregar":
                            Agregar = true;
                            break;

                        case "Modificar":
                            Modificar = true;
                            break;

                        case "Consultar":
                            Consultar = true;
                            break;

                        case "Eliminar":
                            Eliminar = true;
                            break;

                    }
                }
                if (Agregar == false && cbo_productos.SelectedItem.ToString() == "Agregar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_productos.SelectedItem.ToString());
                    lst_productos.Items.Add(lista);
                }
                if (Modificar == false && cbo_productos.SelectedItem.ToString() == "Modificar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_productos.SelectedItem.ToString());
                    lst_productos.Items.Add(lista);
                }
                if (Consultar == false && cbo_productos.SelectedItem.ToString() == "Consultar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_productos.SelectedItem.ToString());
                    lst_productos.Items.Add(lista);
                }
                if (Eliminar == false && cbo_productos.SelectedItem.ToString() == "Eliminar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_productos.SelectedItem.ToString());
                    lst_productos.Items.Add(lista);
                }
                Agregar = false;
                Modificar = false;
                Consultar = false;
                Eliminar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnt_add_pun_Click(object sender, EventArgs e)
        {
            try
            {
                bool Agregar = false;
                bool Consultar = false;
                bool Eliminar = false;
                bool Modificar = false;

                foreach (ListViewItem lista in lst_punto.Items)
                {
                    switch (lista.SubItems[0].Text)
                    {
                        case "Agregar":
                            Agregar = true;
                            break;

                        case "Modificar":
                            Modificar = true;
                            break;

                        case "Consultar":
                            Consultar = true;
                            break;

                        case "Eliminar":
                            Eliminar = true;
                            break;

                    }
                }
                if (Agregar == false && cbo_punto.SelectedItem.ToString() == "Agregar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_punto.SelectedItem.ToString());
                    lst_punto.Items.Add(lista);
                }
                if (Modificar == false && cbo_punto.SelectedItem.ToString() == "Modificar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_punto.SelectedItem.ToString());
                    lst_punto.Items.Add(lista);
                }
                if (Consultar == false && cbo_punto.SelectedItem.ToString() == "Consultar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_punto.SelectedItem.ToString());
                    lst_punto.Items.Add(lista);
                }
                if (Eliminar == false && cbo_punto.SelectedItem.ToString() == "Eliminar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_punto.SelectedItem.ToString());
                    lst_punto.Items.Add(lista);
                }
                Agregar = false;
                Modificar = false;
                Consultar = false;
                Eliminar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bnt_add_sup_Click(object sender, EventArgs e)
        {
            try
            {
                bool Agregar = false;
                bool Consultar = false;
                bool Eliminar = false;
                bool Modificar = false;

                foreach (ListViewItem lista in lst_supervisores.Items)
                {
                    switch (lista.SubItems[0].Text)
                    {
                        case "Agregar":
                            Agregar = true;
                            break;

                        case "Modificar":
                            Modificar = true;
                            break;

                        case "Consultar":
                            Consultar = true;
                            break;

                        case "Eliminar":
                            Eliminar = true;
                            break;

                    }
                }
                if (Agregar == false && cbo_supervisores.SelectedItem.ToString() == "Agregar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_supervisores.SelectedItem.ToString());
                    lst_supervisores.Items.Add(lista);
                }
                if (Modificar == false && cbo_supervisores.SelectedItem.ToString() == "Modificar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_supervisores.SelectedItem.ToString());
                    lst_supervisores.Items.Add(lista);
                }
                if (Consultar == false && cbo_supervisores.SelectedItem.ToString() == "Consultar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_supervisores.SelectedItem.ToString());
                    lst_supervisores.Items.Add(lista);
                }
                if (Eliminar == false && cbo_supervisores.SelectedItem.ToString() == "Eliminar")
                {
                    ListViewItem lista = new ListViewItem(this.cbo_supervisores.SelectedItem.ToString());
                    lst_supervisores.Items.Add(lista);
                }
                Agregar = false;
                Modificar = false;
                Consultar = false;
                Eliminar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                if(this.txt_id_rol.Text!=""&&this.txt_nombre_rol.Text!="")
                {
                   if(Accion=="A"||Accion=="M" ||Accion=="E" )
                    {
                        Roles obj = new Roles(int.Parse(this.txt_id_rol.Text),this.txt_nombre_rol.Text);
                        Int32 FilasAfectadas = 0;
                       
                        #region Agregar
                        if (Accion=="A")
                        {
                            FilasAfectadas = Negocios.AgregarRol(obj, Usuario);
                            if (FilasAfectadas>0)
                            {
                                Permisos(obj.Id_Rol);
                                MessageBox.Show("Rol agregado exitosamente!!!","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                this.Close();
                            }else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("Rol agregado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MessageBox.Show("Error al registrar la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al agregar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Modificar
                        if (Accion=="M")
                        {
                            FilasAfectadas = Negocios.ModificarRol(obj, Usuario);
                            if (FilasAfectadas > 0)
                            {
                                Negocios.EliminarPermisos(Id_Rol);
                                Permisos(Convert.ToInt32(this.txt_id_rol.Text));
                                MessageBox.Show("Rol modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                if (FilasAfectadas == -1)
                                {
                                    MessageBox.Show("Rol modificado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MessageBox.Show("Error al registrar la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al modificar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        #endregion

                        #region Eliminar
                        if (Accion=="E")
                        {
                            DialogResult dr = MessageBox.Show("Realmente desea eliminar rol?", "Eliminar el rol", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                Negocios.EliminarPermisos(Id_Rol);
                                FilasAfectadas = Negocios.EliminarRol(Id_Rol, Usuario);
                                if (FilasAfectadas > 0)
                                {
                                    MessageBox.Show("Rol Eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    if (FilasAfectadas == -1)
                                    {
                                        MessageBox.Show("Rol Eliminado exitosamente!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        MessageBox.Show("Error al registrar la transaccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al eliminar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        #endregion

                    }
                    if (Accion=="C")
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha llenado uno o varios campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #region Agregar Permisos
        private void Permisos(int id_rol)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                Negocios = new Gestor();
                Permi = new Accesos();
                Permi.Id_Rol = id_rol;
                ///////////////////Roles////////1/////////////////////////////////////////////////////////////////////
                if (this.chb_Roles.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Modulo = 1;
                    foreach (ListViewItem lista in lst_roles.Items)
                    {
                        Permi.Accion = lista.SubItems[0].Text;
                        FilasAfectadas = Negocios.AgregarPermisos(Permi);
                        if (FilasAfectadas > 0)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el permiso sobre el modulo Roles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                /////////Usuarios//////2///////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                Permi.Id_Rol = id_rol;
                if (this.chb_usuarios.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Modulo = 2;
                    foreach (ListViewItem lista in lst_usuarios.Items)
                    {
                        Permi.Accion = lista.SubItems[0].Text;
                        FilasAfectadas = Negocios.AgregarPermisos(Permi);
                        if (FilasAfectadas > 0)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el permiso sobre el modulo Roles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                /////////Productos//////3///////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                if (this.chb_productos.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Rol = id_rol;
                    Permi.Modulo = 3;
                    foreach (ListViewItem lista in lst_productos.Items)
                    {
                        Permi.Accion = lista.SubItems[0].Text;
                        FilasAfectadas = Negocios.AgregarPermisos(Permi);
                        if (FilasAfectadas > 0)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el permiso sobre el modulo Roles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                /////////Punto-Venta//////4///////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                if (this.chb_Punto_ventas.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Rol = id_rol;
                    Permi.Modulo = 4;
                    foreach (ListViewItem lista in lst_punto.Items)
                    {
                        Permi.Accion = lista.SubItems[0].Text;
                        FilasAfectadas = Negocios.AgregarPermisos(Permi);
                        if (FilasAfectadas > 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el permiso sobre el modulo Roles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                /////////Supervisores/////5////////////////////////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                if (this.chb_supervisores.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Rol = id_rol;
                    Permi.Modulo = 5;
                    foreach (ListViewItem lista in lst_supervisores.Items)
                    {
                        Permi.Accion = lista.SubItems[0].Text;
                        FilasAfectadas = Negocios.AgregarPermisos(Permi);
                        if (FilasAfectadas > 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el permiso sobre el modulo Roles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                ////////Faltante_Productos////6//////////////////////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                if (this.chb_faltante_productos.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Rol = id_rol;
                    Permi.Modulo = 6;
                    Permi.Accion = "Modulo";
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo bitacora movimientos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ////////Proceso vencimiento Productos////7//////////////////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                if (this.chb_vencimiento.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Rol = id_rol;
                    Permi.Modulo = 7;
                    Permi.Accion = "Modulo";
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo bitacora movimientos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ////////Reporte vencimiento Productos////8//////////////////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                if (this.chb_rep_vencimiento.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Rol = id_rol;
                    Permi.Modulo = 8;
                    Permi.Accion = "Modulo";
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo bitacora movimientos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ////////Reporte faltante de productos////9//////////////////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                if (this.chb_rep_faltante.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Rol = id_rol;
                    Permi.Modulo = 9;
                    Permi.Accion = "Modulo";
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo bitacora movimientos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ////////Reporte de Punto de venta////10//////////////////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                if (this.chb_rep_punto.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Rol = id_rol;
                    Permi.Modulo = 10;
                    Permi.Accion = "Modulo";
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo bitacora movimientos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ////////Bitacora Sesiones////11//////////////////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                if (this.chb_sesiones.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Rol = id_rol;
                    Permi.Modulo = 11;
                    Permi.Accion = "Modulo";
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo bitacora movimientos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ////////Bitacora Movimiento////12//////////////////////////////////////////////////////////////////////////////////
                Permi = new Accesos();
                if (this.chb_movimientos.Checked == true)
                {
                    FilasAfectadas = 0;
                    Permi.Id_Rol = id_rol;
                    Permi.Modulo = 12;
                    Permi.Accion = "Modulo";
                    FilasAfectadas = Negocios.AgregarPermisos(Permi);
                    if (FilasAfectadas > 0)
                    {

                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el permiso sobre el modulo bitacora movimientos ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_id_rol_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void lst_roles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (ListViewItem lista in lst_roles.SelectedItems)
                {
                    lista.Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_usuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (ListViewItem lista in lst_usuarios.SelectedItems)
                {
                    lista.Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_productos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (ListViewItem lista in lst_productos.SelectedItems)
                {
                    lista.Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_punto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (ListViewItem lista in lst_punto.SelectedItems)
                {
                    lista.Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lst_supervisores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (ListViewItem lista in lst_supervisores.SelectedItems)
                {
                    lista.Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
