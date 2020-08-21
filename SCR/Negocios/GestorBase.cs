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
    public class GestorBase
    {
        string vCadenaConexion = Database.connectionString;

        #region Agregar

        #region rol
        public Int32 Agregar_Rol(Roles obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Roles (Id_Rol,Nombre_Rol) values(@Id_Rol,@Nombre_Rol)";
                Parameter[] parametros = {
                                                     new Parameter("@Id_Rol",obj.Id_Rol),
                                                     new Parameter("@Nombre_Rol",obj.Nombre_Rol),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Roles", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region permisos
        public Int32 Agregar_Permisos(Accesos obj/*, string usuario*/)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Accesos (Id_Rol,Modulo,Accion) values(@Id_Rol,@Modulo,@Accion)";
                Parameter[] parametros = {
                                                     new Parameter("@Id_Rol",obj.Id_Rol),
                                                     new Parameter("@Modulo",obj.Modulo),
                                                     new Parameter("@Accion",obj.Accion),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return FilasAfectadas;
                //return Registrar(FilasAfectadas, usuario, "Rol", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Usuario
        public Int32 Agregar_Usuario(Usuarios obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Usuarios (Nombre,Cedula,Nombre_Usuario,Primer_Apellido,Segundo_Apellido,Clave,Sexo,Id_Rol) values(@Nombre,@Cedula,@Nombre_Usuario,@Primer_Apellido,@Segundo_Apellido,@Clave,@Sexo,@Id_Rol)";
                Parameter[] parametros = {
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Nombre_Usuario",obj.Nombre_Usuario),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Primer_Apellido",obj.Primer_Apellido),
                                                     new Parameter("@Segundo_Apellido",obj.Segundo_Apellido),
                                                     new Parameter("@Clave",obj.Clave),
                                                     new Parameter("@Sexo",obj.Sexo),
                                                     new Parameter("@Id_Rol",obj.Id_Rol),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Usuarios", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Productos
        public Int32 Agregar_Producto(Productos obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Productos (Codigo_Producto,Nombre,Marca,Descripcion) values(@Codigo_Producto,@Nombre,@Marca,@Descripcion)";
                Parameter[] parametros = {
                                                     new Parameter("@Codigo_Producto",obj.Codigo_Producto),
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Marca",obj.Marca),
                                                     new Parameter("@Descripcion",obj.Descripcion),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Productos", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Punto venta
        public Int32 Agregar_Punto_Venta(Punto_Venta_Cliente obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Punto_Venta_Cliente (Cedula_juridica_fisica,CorreoElectronico,Direccion,Nombre,Telefono) values(@Cedula_juridica_fisica,@CorreoElectronico,@Direccion,@Nombre,@Telefono)";
                Parameter[] parametros = {
                                                     new Parameter("@Cedula_juridica_fisica",obj.Cedula_juridica_fisica),
                                                     new Parameter("@CorreoElectronico",obj.CorreoElectronico),
                                                     new Parameter("@Direccion",obj.Direccion),
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Telefono",obj.Telefono),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Punto de venta", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Zona
        public Int32 Agregar_Zona(Zonas obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Zonas (Nombre_Zona) values(@Nombre_Zona)";
                Parameter[] parametros = {
                                                     new Parameter("@Nombre_Zona",obj.Nombre_Zona),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Zonas", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Supervisores
        public Int32 Agregar_Supervisor(Supervisores obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Supervisores (Cedula,Nombre,Primer_Apellido,Segundo_Apellido,Telefono,Correo) values(@Cedula,@Nombre,@Primer_Apellido,@Segundo_Apellido,@Telefono,@Correo)";
                Parameter[] parametros = {
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Primer_Apellido",obj.Primer_Apellido),
                                                     new Parameter("@Segundo_Apellido",obj.Segundo_Apellido),
                                                     new Parameter("@Telefono",obj.Telefono),
                                                     new Parameter("@Correo",obj.Correo),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Supervisores", "Agrego");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Faltante
        public Int32 Agregar_Faltante(Faltantes obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Faltantes (Cantidad,Cedula,Codigo_Producto,Fecha_Mes,Sugeridos,Usuario) values(@Cantidad,@Cedula,@Codigo_Producto,@Fecha_Mes,@Sugeridos,@Usuario)";
                Parameter[] parametros = {
                                                     new Parameter("@Cantidad",obj.Cantidad),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Codigo_Producto",obj.Codigo_Producto),
                                                     new Parameter("@Fecha_Mes",obj.Fecha_Mes),
                                                     new Parameter("@Sugeridos",obj.Sugeridos),
                                                     new Parameter("@Usuario",obj.Usuario),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                if(Registrar(FilasAfectadas, usuario, "Faltante productos", "Genero") > 0)
                {
                    return ObteneridFaltante();
                }else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private Int32 ObteneridFaltante()
        {
            Int32 Respuesta = 0;

            string sentencia;
            DataSet data = null;
            sentencia = "SELECT TOP 1 * FROM Faltantes ORDER BY Id_Registro DESC";
            Parameter[] parametros = { new Parameter("",0)
                                         };
            data = Database.executeDataset(sentencia, parametros);
            foreach (DataRow row in data.Tables[0].Rows)
            {
                Respuesta = (Int32)row["Id_Registro"];
            }
            return Respuesta;
        }
        #endregion

        #region Vencimientos
        public Int32 Agregar_Vencimiento(Vencimiento_Productos obj, string usuario)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                string sentencia;
                sentencia = "insert into Vencimiento_Productos (Cedula_Supervisor,Cliente,Descripcion_SKU,Fecha_reporte_vencimiento,Fecha_vencimiento_producto,Observaciones,Seguimiento_3_meses,Seguimiento_5_meses,tiempo_reaccion,UnidadesxSKU,Zona,Usuario) values (@Cedula_Supervisor,@Cliente,@Descripcion_SKU,@Fecha_reporte_vencimiento,@Fecha_vencimiento_producto,@Observaciones,@Seguimiento_3_meses,@Seguimiento_5_meses,@tiempo_reaccion,@UnidadesxSKU,@Zona,@Usuario)";
                Parameter[] parametros = {
                                                     new Parameter("@Cedula_Supervisor",obj.Cedula_Supervisor),
                                                     new Parameter("@Cliente",obj.Cliente),
                                                     new Parameter("@Descripcion_SKU",obj.Descripcion_SKU),
                                                     new Parameter("@Fecha_reporte_vencimiento",obj.Fecha_reporte_vencimiento),
                                                     new Parameter("@Fecha_vencimiento_producto",obj.Fecha_vencimiento_producto),
                                                     new Parameter("@Observaciones",obj.Observaciones),
                                                     new Parameter("@Seguimiento_3_meses",obj.Seguimiento_3_meses),
                                                     new Parameter("@Seguimiento_5_meses",obj.Seguimiento_5_meses),
                                                     new Parameter("@tiempo_reaccion",obj.tiempo_reaccion),
                                                     new Parameter("@UnidadesxSKU",obj.UnidadesxSKU),
                                                     new Parameter("@Zona",obj.Zona),
                                                     new Parameter("@Usuario",obj.Usuario),
                                              };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                if (Registrar(FilasAfectadas, usuario, "Vencimiento productos", "Genero") > 0)
                {
                    return ObteneridVencimiento();
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private Int32 ObteneridVencimiento()
        {
            Int32 Respuesta = 0;

            string sentencia;
            DataSet data = null;
            sentencia = "SELECT TOP 1 * FROM Vencimiento_Productos ORDER BY Id DESC";
            Parameter[] parametros = { new Parameter("",0)
                                         };
            data = Database.executeDataset(sentencia, parametros);
            foreach (DataRow row in data.Tables[0].Rows)
            {
                Respuesta = (Int32)row["Id"];
            }
            return Respuesta;
        }
        #endregion

        #endregion

        #region Modificar

        #region Rol
        public Int32 Actualizar_Rol(Roles uRegistro, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Roles SET Nombre_Rol = @Nombre_Rol WHERE Id_Rol = @Id_Rol";
                Parameter[] parametros = {
                                         new Parameter("@Nombre_Rol",uRegistro.Nombre_Rol),
                                         new Parameter("@Id_Rol",uRegistro.Id_Rol),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Roles", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Usuarios
        public Int32 Actualizar_Usuario_pass(Usuarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Usuarios SET Nombre = @Nombre,Primer_Apellido = @Primer_Apellido,Segundo_Apellido = @Segundo_Apellido,Id_Rol = @Id_Rol,Cedula = @Cedula,Sexo = @Sexo,Clave = @Clave WHERE Nombre_Usuario = @Nombre_Usuario";
                Parameter[] parametros = {
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Nombre_Usuario",obj.Nombre_Usuario),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Primer_Apellido",obj.Primer_Apellido),
                                                     new Parameter("@Segundo_Apellido",obj.Segundo_Apellido),
                                                     new Parameter("@Clave",obj.Clave),
                                                     new Parameter("@Sexo",obj.Sexo),
                                                     new Parameter("@Id_Rol",obj.Id_Rol),
                                       };
                 FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                 return Registrar(FilasAfectadas, usuario, "Usuarios", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 Actualizar_Usuario(Usuarios obj, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Usuarios SET Nombre = @Nombre,Primer_Apellido = @Primer_Apellido,Segundo_Apellido = @Segundo_Apellido,Id_Rol = @Id_Rol,Cedula = @Cedula,Sexo = @Sexo WHERE Nombre_Usuario = @Nombre_Usuario";
                Parameter[] parametros = {
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Nombre_Usuario",obj.Nombre_Usuario),
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Primer_Apellido",obj.Primer_Apellido),
                                                     new Parameter("@Segundo_Apellido",obj.Segundo_Apellido),
                                                     new Parameter("@Clave",obj.Clave),
                                                     new Parameter("@Sexo",obj.Sexo),
                                                     new Parameter("@Id_Rol",obj.Id_Rol),
                                       };
               return FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                //return Registrar(FilasAfectadas, usuario, "Usuarios", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Productos
        public Int32 Actualizar_Producto(Productos obj, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Productos SET Nombre = @Nombre,Marca = @Marca,Descripcion = @Descripcion  WHERE Codigo_Producto = @Codigo_Producto";
                Parameter[] parametros = {
                                            new Parameter("@Codigo_Producto",obj.Codigo_Producto),
                                            new Parameter("@Nombre",obj.Nombre),
                                            new Parameter("@Marca",obj.Marca),
                                            new Parameter("@Descripcion",obj.Descripcion),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Productos", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Supervisores
        public Int32 Actualizar_Supervisor(Supervisores obj, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Supervisores SET Nombre=@Nombre,Primer_Apellido=@Primer_Apellido,Segundo_Apellido=@Segundo_Apellido,Telefono=@Telefono,Correo=@Correo  WHERE Cedula=@Cedula";
                Parameter[] parametros = {
                                                     new Parameter("@Cedula",obj.Cedula),
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Primer_Apellido",obj.Primer_Apellido),
                                                     new Parameter("@Segundo_Apellido",obj.Segundo_Apellido),
                                                     new Parameter("@Telefono",obj.Telefono),
                                                     new Parameter("@Correo",obj.Correo),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Supervisores", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Punto-Venta
        public Int32 Actualizar_Punto(Punto_Venta_Cliente obj, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Punto_Venta_Cliente SET Nombre = @Nombre,CorreoElectronico = @CorreoElectronico,Direccion=@Direccion,Telefono=@Telefono  WHERE Cedula_juridica_fisica = @Cedula_juridica_fisica";
                Parameter[] parametros = {
                                                     new Parameter("@Cedula_juridica_fisica",obj.Cedula_juridica_fisica),
                                                     new Parameter("@CorreoElectronico",obj.CorreoElectronico),
                                                     new Parameter("@Direccion",obj.Direccion),
                                                     new Parameter("@Nombre",obj.Nombre),
                                                     new Parameter("@Telefono",obj.Telefono),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Punto de venta", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Zona
        public Int32 Actualizar_Zona(Zonas obj, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Zonas SET Nombre_Zona = @Nombre_Zona WHERE Id_Zona = @Id_Zona";
                Parameter[] parametros = {
                                            new Parameter("@Id_Zona",obj.Id_Zona),
                                            new Parameter("@Nombre_Zona",obj.Nombre_Zona),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Zonas", "Modifico");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region Eliminar

        #region Rol
        public Int32 EliminarRol(Int32 Id_Rol, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Roles WHERE Id_Rol = @Id_Rol";
                Parameter[] parametros = {
                                         new Parameter("@Id_Rol",Id_Rol),
                                       };
               FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
               return Registrar(FilasAfectadas, usuario, "Roles", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #region Permisos
        public Int32 EliminarPermisos(Int32 Id_Rol)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Accesos WHERE Id_Rol = @Id_Rol";
                Parameter[] parametros = {
                                         new Parameter("@Id_Rol",Id_Rol),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return FilasAfectadas;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion

        #region Usuario
        public Int32 EliminarUsuario(string Usuario, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Usuarios WHERE Nombre_Usuario = @Nombre_Usuario";
                Parameter[] parametros = {
                                         new Parameter("@Nombre_Usuario",Usuario),
                                       };
                EliminarMovimientos(Usuario);
                EliminarSessiones(Usuario);
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Usuarios", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar Movimientos
        public Int32 EliminarMovimientos(string User)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Acciones_Realizadas WHERE Nombre_Usuario = @Usuario";
                Parameter[] parametros = {
                                         new Parameter("@Usuario",User),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FilasAfectadas;
        }
        #endregion

        #region Eliminar Sessiones
        public Int32 EliminarSessiones(string User)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Ingresos_Salidas WHERE Nombre_Usuario = @Usuario";
                Parameter[] parametros = {
                                         new Parameter("@Usuario",User),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FilasAfectadas;
        }
        #endregion

        #region Producto
        public Int32 EliminarProductos(int Codigo, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Productos WHERE Codigo_Producto = @Codigo_Producto";
                Parameter[] parametros = {
                                         new Parameter("@Codigo_Producto",Codigo),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Productos", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Zona
        public Int32 EliminarZonas(int Codigo, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Zonas WHERE Id_Zona = @Id_Zona";
                Parameter[] parametros = {
                                         new Parameter("@Id_Zona",Codigo),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Zonas", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Supervisor
        public Int32 EliminarSupervisor(int Codigo, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Supervisores WHERE Cedula = @Cedula";
                Parameter[] parametros = {
                                         new Parameter("@Cedula",Codigo),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Supervisores", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Punto
        public Int32 EliminarPunto(int Codigo, string usuario)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "DELETE FROM Punto_Venta_Cliente WHERE Cedula_juridica_fisica = @Cedula_juridica_fisica";
                Parameter[] parametros = {
                                         new Parameter("@Cedula_juridica_fisica",Codigo),
                                       };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                return Registrar(FilasAfectadas, usuario, "Productos", "Elimino");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region Mostrar

        #region Mostrar_Roles
        public DataTable llenar_Roles()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Roles";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Roles_Nombre
        public DataTable llenar_Roles(string Nombre)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Roles WHERE Nombre_Rol LIKE '%" + Nombre + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Usuarios
        public DataTable llenar_Usuarios()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Usuarios";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Usuarios(int cedula)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Usuarios WHERE Cedula LIKE '%" + cedula + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Usuarios(string nombre)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Usuarios WHERE Nombre LIKE '%" + nombre + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Productos
        public DataTable llenar_Productos()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Productos";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Productos(int codigo)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Productos WHERE Codigo_Producto LIKE '%" + codigo + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Productos(string nombre)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Productos WHERE Nombre LIKE '%" + nombre + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Supervisor
        public DataTable llenar_Supervisores()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Supervisores";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Supervisores(int codigo)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Supervisores WHERE Cedula LIKE '%" + codigo + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Supervisores(string nombre)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Supervisores WHERE Nombre LIKE '%" + nombre + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Punto_venta_cliente
        public DataTable llenar_Punto()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Punto_Venta_Cliente";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Punto(int codigo)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Punto_Venta_Cliente WHERE Cedula_juridica_fisica LIKE '%" + codigo + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Punto(string nombre)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Punto_Venta_Cliente WHERE Nombre LIKE '%" + nombre + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar_Zonas
        public DataTable llenar_Zonas()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Zonas";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Sessiones 
        public DataTable llenar_Bitacora_IS(string Usuario)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Ingresos_Salidas WHERE Nombre_Usuario LIKE '%" + Usuario + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable llenar_Bitacora_IS(DateTime fecha_ini, DateTime fecha_fin)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT*FROM Ingresos_Salidas WHERE Fecha_Hora_Ingreso BETWEEN '" + fecha_ini.ToString() + "' AND '" + fecha_fin.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Movimientos
        public DataTable llenar_Bitacora_Mov(string Usuario)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Acciones_Realizadas WHERE Nombre_Usuario LIKE '%" + Usuario + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Bitacora_Movv(string Movimiento)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Acciones_Realizadas WHERE Accion = '"+Movimiento+"'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Bitacora_Mov(DateTime fecha_ini, DateTime fecha_fin)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT*FROM Acciones_Realizadas WHERE Fecha BETWEEN '" + fecha_ini.ToString() + "' AND '" + fecha_fin.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Vencimientos
        public DataTable llenar_Vencimiento(DateTime Fecha)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Vencimiento_Productos WHERE Fecha_vencimiento_producto = '"+Fecha+"'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Vencimientov(DateTime Fecha)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Vencimiento_Productos where (DATEPART(yy, Fecha_reporte_vencimiento) = "+Fecha.Year+" AND DATEPART(mm, Fecha_reporte_vencimiento) = "+Fecha.Month+" AND DATEPART(dd, Fecha_reporte_vencimiento) = "+Fecha.Day+")";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Vencimiento( int supervisor)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Vencimiento_Productos WHERE Cedula_Supervisor = " + supervisor;
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Faltantes
        public DataTable llenar_Faltante(string Fecha)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Faltantes WHERE Fecha_Mes LIKE '%" + Fecha + "%'";
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Faltantev(int Cedula)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Faltantes WHERE Cedula = " + Cedula;
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable llenar_Faltante(int Codigo)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(vCadenaConexion))
                {

                    string query = "SELECT * FROM Faltantes WHERE Codigo_Producto = " + Codigo;
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region Mostrar Unico

        #region Rol
        public Roles Mostrar_rol(Int32 pCodigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Roles vRegistro = new Roles();

                string commandText = "SELECT * FROM [dbo].[Roles] WHERE [Id_Rol] =  " + pCodigo;
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Nombre_Rol = dtConsulta.Rows[0]["Nombre_Rol"].ToString();
                    vRegistro.Id_Rol = Convert.ToInt32(dtConsulta.Rows[0]["Id_Rol"]);

                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Permisos
        public Accesos Mostrar_Permisos_Unico(Int32 id_perfil, Int32 modulo,string Accion)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Accesos vRegistro = new Accesos();

                string commandText = "SELECT * FROM [dbo].[Accesos] WHERE [Id_Rol] =  " + id_perfil + " and [Modulo] = " + modulo + " and [Accion] = '"+Accion+"'";
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Id_Rol = int.Parse(dtConsulta.Rows[0]["Id_Rol"].ToString());
                    vRegistro.Modulo = int.Parse(dtConsulta.Rows[0]["Modulo"].ToString());
                    vRegistro.Accion = dtConsulta.Rows[0]["Accion"].ToString();
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Accesos Mostrar_Permisos_Unico(Int32 id_perfil, Int32 modulo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Accesos vRegistro = new Accesos();

                string commandText = "SELECT TOP 1 Id_Rol,Modulo,Accion  FROM dbo.Accesos WHERE [Id_Rol] =  " + id_perfil + " and [Modulo] = " + modulo;
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Id_Rol = int.Parse(dtConsulta.Rows[0]["Id_Rol"].ToString());
                    vRegistro.Modulo = int.Parse(dtConsulta.Rows[0]["Modulo"].ToString());
                    vRegistro.Accion = dtConsulta.Rows[0]["Accion"].ToString();
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Usuario
        public Usuarios Mostrar_Usuario_Unico(string Usuario)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Usuarios vRegistro = new Usuarios();

                string commandText = "SELECT * FROM [dbo].[Usuarios] WHERE [Nombre_Usuario] =  '" + Usuario+"'";
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Cedula = int.Parse(dtConsulta.Rows[0]["Cedula"].ToString());
                    vRegistro.Primer_Apellido = dtConsulta.Rows[0]["Primer_Apellido"].ToString();
                    vRegistro.Segundo_Apellido = dtConsulta.Rows[0]["Segundo_Apellido"].ToString();
                    vRegistro.Clave = dtConsulta.Rows[0]["Clave"].ToString();
                    vRegistro.Sexo = dtConsulta.Rows[0]["Sexo"].ToString();
                    vRegistro.Id_Rol = int.Parse(dtConsulta.Rows[0]["Id_Rol"].ToString());
                    vRegistro.Nombre = dtConsulta.Rows[0]["Nombre"].ToString();
                    vRegistro.Nombre_Usuario = dtConsulta.Rows[0]["Nombre_Usuario"].ToString();

                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Productos
        public Productos Mostrar_Productos_Unico(int Codigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Productos vRegistro = new Productos();

                string commandText = "SELECT * FROM [dbo].[Productos] WHERE [Codigo_Producto] = " + Codigo;
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Codigo_Producto = int.Parse(dtConsulta.Rows[0]["Codigo_Producto"].ToString());
                    vRegistro.Nombre = dtConsulta.Rows[0]["Nombre"].ToString();
                    vRegistro.Marca = dtConsulta.Rows[0]["Marca"].ToString();
                    vRegistro.Descripcion = dtConsulta.Rows[0]["Descripcion"].ToString();
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Punto
        public Punto_Venta_Cliente Mostrar_Puntos_Unico(int Codigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Punto_Venta_Cliente vRegistro = new Punto_Venta_Cliente();

                string commandText = "SELECT * FROM [dbo].[Punto_Venta_Cliente] WHERE [Cedula_juridica_fisica] = " + Codigo;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Cedula_juridica_fisica = int.Parse(dtConsulta.Rows[0]["Cedula_juridica_fisica"].ToString());
                    vRegistro.Nombre = dtConsulta.Rows[0]["Nombre"].ToString();
                    vRegistro.CorreoElectronico = dtConsulta.Rows[0]["CorreoElectronico"].ToString();
                    vRegistro.Direccion = dtConsulta.Rows[0]["Direccion"].ToString();
                    vRegistro.Telefono = int.Parse(dtConsulta.Rows[0]["Telefono"].ToString());
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Supervisores
        public Supervisores Mostrar_Supervisores_Unico(int Codigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Supervisores vRegistro = new Supervisores();

                string commandText = "SELECT * FROM [dbo].[Supervisores] WHERE [Cedula] = " + Codigo;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Cedula = int.Parse(dtConsulta.Rows[0]["Cedula"].ToString());
                    vRegistro.Nombre = dtConsulta.Rows[0]["Nombre"].ToString();
                    vRegistro.Correo = dtConsulta.Rows[0]["Correo"].ToString();
                    vRegistro.Primer_Apellido = dtConsulta.Rows[0]["Primer_Apellido"].ToString();
                    vRegistro.Segundo_Apellido = dtConsulta.Rows[0]["Segundo_Apellido"].ToString();
                    vRegistro.Telefono = int.Parse(dtConsulta.Rows[0]["Telefono"].ToString());
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Login
        public Usuarios Login(string User, string Pass)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Usuarios vRegistro = new Usuarios();

                string commandText = "SELECT * FROM [dbo].[Usuarios] WHERE [Nombre_Usuario] = '" + User + "' AND [Clave] = '" + Pass + "'";
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Cedula = int.Parse(dtConsulta.Rows[0]["Cedula"].ToString());
                    vRegistro.Id_Rol = int.Parse(dtConsulta.Rows[0]["Id_Rol"].ToString());
                    vRegistro.Nombre_Usuario = dtConsulta.Rows[0]["Nombre_Usuario"].ToString();
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Zonas
        public Zonas Mostrar_Zonas_Unico(int Codigo)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Zonas vRegistro = new Zonas();

                string commandText = "SELECT * FROM [dbo].[Zonas] WHERE [Id_Zona] = " + Codigo;
                //string commandText = commandTexta;

                using (SqlConnection connection = new SqlConnection(vCadenaConexion))
                {
                    SqlCommand command = new SqlCommand(commandText, connection);

                    SqlDataAdapter DataAdapter = new SqlDataAdapter(command);
                    DataAdapter.Fill(dtConsulta);
                }

                if (dtConsulta.Rows.Count != 0)
                {
                    vRegistro.Id_Zona = int.Parse(dtConsulta.Rows[0]["Id_Zona"].ToString());
                    vRegistro.Nombre_Zona = dtConsulta.Rows[0]["Nombre_Zona"].ToString();
                }


                return vRegistro;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region Registrar
        public Int32 Registrar(Int32 FilasAfectadas, string usuario, string Tabla, string Accion)
        {
            if (FilasAfectadas > 0)
            {
                Int32 f2 = 0;
                string sentencia;
                sentencia = "INSERT INTO Acciones_Realizadas (Accion,Fecha,Tabla,Nombre_Usuario) VALUES(@Accion,getdate(),@modulo,@Usuario);";
                Parameter[] parametrosa = {
                                                     new Parameter("@Usuario",usuario),
                                                     new Parameter("@Accion",Accion),
                                                     new Parameter("@modulo",Tabla),
                                              };
                f2 = Database.exectuteNonQuery(sentencia, parametrosa);
                if (f2 > 0)
                {

                }
                else
                {
                    FilasAfectadas = -1;
                }
            }
            else
            {
                FilasAfectadas = 0;
            }
            return FilasAfectadas;
        }
        #endregion

        #region Metodo Ingresar Sesion
        public Int32 Ingresar(Ingresos_Salidas obj)
        {
            try
            {
                Int32 FilasAfectadas = 0;
                Int32 Id_Session = 0;
                string sentencia;
                sentencia = "insert into Ingresos_Salidas (Nombre_Usuario,Fecha_Hora_Ingreso) values(@Nombre_Usuario,@Fecha_Hora_Ingreso)";
                Parameter[] parametros = {
                                                     new Parameter("@Nombre_Usuario",obj.Nombre_Usuario),
                                                     new Parameter("@Fecha_Hora_Ingreso",obj.Fecha_Hora_Ingreso),
                                                    // new Parameter("@Salida",obj.Salida),
                };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
                if (FilasAfectadas > 0)
                {
                    Id_Session = Obtenerid();
                }
                return Id_Session;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Int32 Obtenerid()
        {
            Int32 Respuesta = 0;

            string sentencia;
            DataSet data = null;
            sentencia = "SELECT TOP 1 * FROM Ingresos_Salidas ORDER BY Id DESC";
            Parameter[] parametros = { new Parameter("",0)
                                         };
            data = Database.executeDataset(sentencia, parametros);
            foreach (DataRow row in data.Tables[0].Rows)
            {
                Respuesta = (Int32)row["Id"];
            }
            return Respuesta;
        }

        #endregion

        #region Salida Sesion
        public Int32 Salir(Ingresos_Salidas obj)
        {
            Int32 FilasAfectadas = 0;

            try
            {
                string sentencia;
                sentencia = "UPDATE Ingresos_Salidas SET Fecha_Hora_Salida=@Fecha_Hora_Salida WHERE Id = @Id";
                Parameter[] parametros = {
                                                     new Parameter("@Fecha_Hora_Salida",obj.Fecha_Hora_Salida),
                                                     new Parameter("@Id",obj.Id),
                };
                FilasAfectadas = Database.exectuteNonQuery(sentencia, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return FilasAfectadas;
        }
        #endregion

    }
}
