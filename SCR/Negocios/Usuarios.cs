using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Usuarios{
        #region Atributos 
          public int Cedula {get;set;}
          public string Nombre_Usuario {get;set;}
          public string Nombre {get;set;}
          public string Primer_Apellido {get;set;}
          public string Segundo_Apellido {get;set;}
          public string Clave {get;set;}
          public string Sexo {get;set;}
          public int Id_Rol {get;set;}
#endregion
#region Constructor sin parametros
      public Usuarios()
{
Cedula= 0;
Nombre_Usuario= "";
Nombre= "";
Primer_Apellido= "";
Segundo_Apellido= "";
Clave= "";
Sexo= "";
Id_Rol= 0;
}
#endregion  
#region Constructor con parametros 
public Usuarios(int Cedulap,string Nombre_Usuariop,string Nombrep,string Primer_Apellidop,string Segundo_Apellidop,string Clavep,string Sexop,int Id_Rolp){
Cedula=Cedulap;
Nombre_Usuario=Nombre_Usuariop;
Nombre=Nombrep;
Primer_Apellido=Primer_Apellidop;
Segundo_Apellido=Segundo_Apellidop;
Clave=Clavep;
Sexo=Sexop;
Id_Rol=Id_Rolp;
}
#endregion
}
}
