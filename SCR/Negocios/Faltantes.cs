using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Faltantes{
        #region Atributos 
          public int Id_Registro {get;set;}
          public int Codigo_Producto {get;set;}
          public int Cedula {get;set;}
          public string Sugeridos {get;set;}
          public string Fecha_Mes {get;set;}
          public int Cantidad {get;set;}
          public string Usuario {get;set;}
#endregion
#region Constructor sin parametros
      public Faltantes()
{
Id_Registro= 0;
Codigo_Producto= 0;
Cedula= 0;
Sugeridos= "";
Fecha_Mes= "";
Cantidad= 0;
Usuario= "";
}
#endregion  
#region Constructor con parametros 
public Faltantes(int Id_Registrop,int Codigo_Productop,int Cedulap,string Sugeridosp,string Fecha_Mesp,int Cantidadp,string Usuariop){
Id_Registro=Id_Registrop;
Codigo_Producto=Codigo_Productop;
Cedula=Cedulap;
Sugeridos=Sugeridosp;
Fecha_Mes=Fecha_Mesp;
Cantidad=Cantidadp;
Usuario=Usuariop;
}
#endregion
}
}
