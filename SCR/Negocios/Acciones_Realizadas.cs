using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Acciones_Realizadas{
        #region Atributos 
          public DateTime Fecha {get;set;}
          public int Id_Accion {get;set;}
          public string Accion {get;set;}
          public string Tabla {get;set;}
          public string Nombre_Usuario {get;set;}
#endregion
#region Constructor sin parametros
      public Acciones_Realizadas()
{
Fecha= DateTime.Now;
Id_Accion= 0;
Accion= "";
Tabla= "";
Nombre_Usuario= "";
}
#endregion  
#region Constructor con parametros 
public Acciones_Realizadas(DateTime Fechap,int Id_Accionp,string Accionp,string Tablap,string Nombre_Usuariop){
Fecha=Fechap;
Id_Accion=Id_Accionp;
Accion=Accionp;
Tabla=Tablap;
Nombre_Usuario=Nombre_Usuariop;
}
#endregion
}
}
