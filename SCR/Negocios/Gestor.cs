using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Gestor
    {

        #region Agregar

        #region rol
        public Int32 AgregarRol(Roles rol, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Rol(rol, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region permisos
        public Int32 AgregarPermisos(Accesos permi/*, string usuario*/)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Permisos(permi/*, usuario*/);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Usuarios
        public Int32 AgregarUsuarios(Usuarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Usuario(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Productos
        public Int32 AgregarProducto(Productos obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Producto(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Supervisores
        public Int32 AgregarSupervisor(Supervisores obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Supervisor(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Punto-venta
        public Int32 AgregarPunto(Punto_Venta_Cliente obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Punto_Venta(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Zona
        public Int32 AgregarZona(Zonas obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Zona(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Faltante
        public Int32 AgregarFaltante(Faltantes obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Faltante(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Vencimientos
        public Int32 AgregarVencimiento(Vencimiento_Productos obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Agregar_Vencimiento(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #endregion

        #region Modificar

        #region Rol
        public Int32 ModificarRol(Roles rol, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Rol(rol, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Usuario
        public Int32 Modificar_Usuario_pass(Usuarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Usuario_pass(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }

        public Int32 Modificar_Usuario(Usuarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Usuario(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Productos
        public Int32 Modificar_Productos(Productos obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Producto(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Supervisores
        public Int32 Modificar_Supervisores(Supervisores obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Supervisor(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Punto
        public Int32 Modificar_Punto(Punto_Venta_Cliente obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Punto(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Zonas
        public Int32 Modificar_Zonas(Zonas obj, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.Actualizar_Zona(obj, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #endregion

        #region Eliminar

        #region Rol
        public Int32 EliminarRol(Int32 id_rol, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarRol(id_rol, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Permisos
        public Int32 EliminarPermisos(Int32 id_rol)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarPermisos(id_rol);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Usuario
        public Int32 Eliminar_Usuario(string Usuario, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarUsuario(Usuario, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Producto
        public Int32 Eliminar_Producto(int Codigo, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarProductos(Codigo, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Supervisores
        public Int32 Eliminar_Supervisor(int Codigo, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarSupervisor(Codigo, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Punto
        public Int32 Eliminar_Punto(int Codigo, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarPunto(Codigo, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Zona
        public Int32 Eliminar_Zona(int Codigo, string usuario)
        {
            Int32 FilasAfectadas = 0;
            try
            {
                GestorBase BD = new GestorBase();
                FilasAfectadas = BD.EliminarZonas(Codigo, usuario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return FilasAfectadas;
        }
        #endregion

        #endregion

        #region Mostrar varios

        #region Rol
        public DataTable llenar_Roles()
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Roles();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region Rol con nombre
        public DataTable llenar_Roles(string Nombre)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Roles(Nombre);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region Usuario
        public DataTable llenar_Usuarios()
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Usuarios();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Usuarios(int cedula)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Usuarios(cedula);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Usuarios(string nombre)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Usuarios(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region Productos
        public DataTable llenar_Productos()
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Productos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Productos(int codigo)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Productos(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Productos(string nombre)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Productos(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region Supervisores
        public DataTable llenar_Supervisores()
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Supervisores();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Supervisores(int codigo)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Supervisores(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Supervisores(string nombre)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Supervisores(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region Punto venta cliente
        public DataTable llenar_Puntos()
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Punto();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Puntos(int codigo)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Punto(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Puntos(string nombre)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Punto(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region Zonas
        public DataTable llenar_Zonas()
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Zonas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }
        #endregion

        #region Sesiones
        public DataTable llenar_Bitacora_Sesiones(string Usuario)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Bitacora_IS(Usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Bitacora_Sesiones(DateTime fecha_ini, DateTime fecha_fin)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Bitacora_IS(fecha_ini,fecha_fin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        #endregion

        #region Movimiento
        public DataTable llenar_Bitacora_Movimientos(string Usuario)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Bitacora_Mov(Usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Bitacora_Movimientosv(string Movimiento)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Bitacora_Movv(Movimiento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Bitacora_Movimientos(DateTime fecha_ini, DateTime fecha_fin)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Bitacora_Mov(fecha_ini, fecha_fin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        #endregion

        #region Vencimiento
        public DataTable llenar_Vencimiento(DateTime Fecha)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Vencimiento(Fecha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Vencimiento(int Supervisor)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Vencimiento(Supervisor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Vencimientov(DateTime Fecha)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Vencimientov(Fecha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        #endregion

        #region Faltante
        public DataTable llenar_Faltante(string Fecha)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Faltante(Fecha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Faltante(int Codigo)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Faltante(Codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        public DataTable llenar_Faltantev(int Cedula)
        {
            DataTable dt = new DataTable();


            try
            {
                GestorBase BD = new GestorBase();
                dt = BD.llenar_Faltantev(Cedula);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return dt;
        }

        #endregion

        #endregion

        #region Mostrar Unico

        #region Rol
        public Roles Mostrar_Rol(Int32 pCodigo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_rol(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Permisos
        public Accesos Mostrar_Permisos_Unico(Int32 id_perfil, Int32 modulo,string Accion)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_Permisos_Unico(id_perfil, modulo,Accion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Accesos Mostrar_Permisos_Unico(Int32 id_perfil, Int32 modulo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_Permisos_Unico(id_perfil, modulo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Usuario
        public Usuarios Mostrar_Usuario_Unico(string pCodigo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_Usuario_Unico(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Productos
        public Productos Mostrar_Productos_Unico(int pCodigo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_Productos_Unico(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Puntos
        public Punto_Venta_Cliente Mostrar_Puntos_Unico(int pCodigo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_Puntos_Unico(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Supervisores
        public Supervisores Mostrar_Supervisores_Unico(int pCodigo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_Supervisores_Unico(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Zonas
        public Zonas Mostrar_Zonas_Unico(int pCodigo)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Mostrar_Zonas_Unico(pCodigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Login
        public Usuarios Login(string User, string Pass)
        {
            try
            {
                GestorBase BD = new GestorBase();
                return BD.Login(User, Pass);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #endregion

        #region Sessiones

        #region Ingreso
        public Int32 Ingreso(Ingresos_Salidas data)
        {
            Int32 Id_Session = 0;
            try
            {
                GestorBase BD = new GestorBase();
                Id_Session = BD.Ingresar(data);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Id_Session;
        }
        #endregion

        #region Salida
        public Int32 Salir(Ingresos_Salidas Data)
        {
            Int32 FilasAfectadas = 0;
            GestorBase BD;

            try
            {
                BD = new GestorBase();
                FilasAfectadas = BD.Salir(Data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return FilasAfectadas;
        }
        #endregion

        #endregion

    }
}
