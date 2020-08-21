using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Ingresos_Salidas{
        #region Atributos 
          public int Id {get;set;}
          public DateTime Fecha_Hora_Ingreso {get;set;}
          public DateTime Fecha_Hora_Salida {get;set;}
          public string Nombre_Usuario {get;set;}
#endregion
#region Constructor sin parametros
      public Ingresos_Salidas()
{
Id= 0;
Fecha_Hora_Ingreso= DateTime.Now;
Fecha_Hora_Salida= DateTime.Now;
Nombre_Usuario= "";
}
#endregion  
#region Constructor con parametros 
public Ingresos_Salidas(int Idp,DateTime Fecha_Hora_Ingresop,DateTime Fecha_Hora_Salidap,string Nombre_Usuariop){
Id=Idp;
Fecha_Hora_Ingreso=Fecha_Hora_Ingresop;
Fecha_Hora_Salida=Fecha_Hora_Salidap;
Nombre_Usuario=Nombre_Usuariop;
}
#endregion
}
}
