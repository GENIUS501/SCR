using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace SCR
{
    public partial class Menu : Form
    {
        Ingresos_Salidas ses;
        Gestor Negocios;
        Accesos Permi;
        public string Usuario { get; set; }
        public int Id_Rol { get; set; }
        public int id_sesion { get; set; }
        public Menu()
        {
            InitializeComponent();
        }

        private void mantenimientoDeRolesYPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Roles frm = new Lista_Roles();
                frm.Usuario = Usuario;
                frm.Id_Rol = Id_Rol;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ses = new Ingresos_Salidas();
                Negocios = new Gestor();
                Int32 FilasAfectadas;
                ses.Id = id_sesion;
                ses.Fecha_Hora_Salida = DateTime.Now;
                FilasAfectadas = Negocios.Salir(ses);
                if (FilasAfectadas > 0)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Error al cerrar session!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ses = new Ingresos_Salidas();
                Negocios = new Gestor();
                Int32 FilasAfectadas;
                ses.Id = id_sesion;
                ses.Fecha_Hora_Salida = DateTime.Now;
                FilasAfectadas = Negocios.Salir(ses);
                if (FilasAfectadas > 0)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Error al cerrar session!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Usuarios frm = new Lista_Usuarios();
                frm.Usuario=Usuario;
                frm.Id_Rol = Id_Rol;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimientoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Productos frm = new Lista_Productos();
                frm.Usuario = Usuario;
                frm.Id_Rol = Id_Rol;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                Negocios = new Gestor();
                Permi = new Accesos();
                #region Roles
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 1);
                if(Permi.Modulo>0)
                {
                    this.mantenimientoDeRolesYPermisosToolStripMenuItem.Visible = true;
                }else
                {
                    this.mantenimientoDeRolesYPermisosToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Usuarios
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 2);
                if (Permi.Modulo > 0)
                {
                    this.mantenimientoDeUsuariosToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.mantenimientoDeUsuariosToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Productos
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 3);
                if (Permi.Modulo > 0)
                {
                    this.mantenimientoProductosToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.mantenimientoProductosToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Punto-venta
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 4);
                if (Permi.Modulo > 0)
                {
                    this.mantenimientoPuntoventaToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.mantenimientoPuntoventaToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Supervisores
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 5);
                if (Permi.Modulo > 0)
                {
                    this.mantenimientoDeSupervisoresToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.mantenimientoDeSupervisoresToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Proceso Faltante Productos
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 6);
                if (Permi.Modulo > 0)
                {
                    this.faltanteDeProductosToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.faltanteDeProductosToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Proceso vencimiento Productos
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 7);
                if (Permi.Modulo > 0)
                {
                    this.vencimientoDeProductosToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.vencimientoDeProductosToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Reporte vencimiento Productos
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 8);
                if (Permi.Modulo > 0)
                {
                    this.reporteVencimientoDeProductoToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.reporteVencimientoDeProductoToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Reporte faltante de productos
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 9);
                if (Permi.Modulo > 0)
                {
                    this.reporteDeFaltanteDeProductosToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.reporteDeFaltanteDeProductosToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Reporte de Punto de venta
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 10);
                if (Permi.Modulo > 0)
                {
                    this.reporteDePuntoDeVentaClienteToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.reporteDePuntoDeVentaClienteToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Bitacora Sesiones
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 11);
                if (Permi.Modulo > 0)
                {
                    this.bitacoraDeIngresoYSalidaToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.bitacoraDeIngresoYSalidaToolStripMenuItem.Visible = false;
                }
                #endregion

                #region Bitacora Movimiento
                Permi = Negocios.Mostrar_Permisos_Unico(Id_Rol, 12);
                if (Permi.Modulo > 0)
                {
                    this.bitacoraDeMovimientosToolStripMenuItem.Visible = true;
                }
                else
                {
                    this.bitacoraDeMovimientosToolStripMenuItem.Visible = false;
                }
                #endregion
                this.lbl_Usuario.Text = Usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void faltanteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proceso_Faltante_Productos frm = new Proceso_Faltante_Productos();
                frm.Usuario = Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void vencimientoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Proceso_Vencimiento_Productos frm = new Proceso_Vencimiento_Productos();
                frm.Usuario = Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimientoPuntoventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Punto_Venta_Cliente frm = new Lista_Punto_Venta_Cliente();
                frm.Usuario = Usuario;
                frm.Id_Rol = Id_Rol;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimientoDeSupervisoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Supervisores frm = new Lista_Supervisores();
                frm.Usuario = Usuario;
                frm.Id_Rol = Id_Rol;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                About frm = new About();
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimientoDeZonasGeograficasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Zonas frm = new Lista_Zonas();
                frm.Usuario = Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bitacoraDeIngresoYSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitacora_Ingreso_Salida frm = new Bitacora_Ingreso_Salida();
                frm.Usuario = Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bitacoraDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitacora_Movimientos frm = new Bitacora_Movimientos();
                frm.Usuario = Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reporteVencimientoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte_Vencimiento_producto frm = new Reporte_Vencimiento_producto();
                frm.Usuario = Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reporteDeFaltanteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte_Faltante_Productos frm = new Reporte_Faltante_Productos();
                frm.Usuario = Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reporteDePuntoDeVentaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Reporte_Punto_Venta_Cliente frm = new Reporte_Punto_Venta_Cliente();
                frm.Usuario = Usuario;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
