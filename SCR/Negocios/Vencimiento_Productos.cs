using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Vencimiento_Productos{
        #region Atributos 
          public DateTime Fecha_reporte_vencimiento {get;set;}
          public DateTime Fecha_vencimiento_producto {get;set;}
          public float tiempo_reaccion {get;set;}
          public int Cedula_Supervisor {get;set;}
          public int Zona {get;set;}
          public int Id { get; set; }
          public int Cliente {get;set;}
          public string Descripcion_SKU {get;set;}
          public int UnidadesxSKU {get;set;}
          public string Observaciones {get;set;}
          public string Usuario { get; set; }
          public string Seguimiento_3_meses {get;set;}
          public string Seguimiento_5_meses {get;set;}
#endregion
#region Constructor sin parametros
      public Vencimiento_Productos()
{
Fecha_reporte_vencimiento= DateTime.Now;
Fecha_vencimiento_producto= DateTime.Now;
tiempo_reaccion= 0;
Cedula_Supervisor= 0;
Zona= 0;
Cliente= 0;
Descripcion_SKU= "";
UnidadesxSKU= 0;
Observaciones= "";
Seguimiento_3_meses= "";
Seguimiento_5_meses= "";
            Id = 0;
}
#endregion  
#region Constructor con parametros 
public Vencimiento_Productos(DateTime Fecha_reporte_vencimientop,DateTime Fecha_vencimiento_productop,float tiempo_reaccionp,int Cedula_Supervisorp,int Zonap,int Clientep,string Descripcion_SKUp,int UnidadesxSKUp,string Observacionesp,string Seguimiento_3_mesesp,string Seguimiento_5_mesesp){
Fecha_reporte_vencimiento=Fecha_reporte_vencimientop;
Fecha_vencimiento_producto=Fecha_vencimiento_productop;
tiempo_reaccion=tiempo_reaccionp;
Cedula_Supervisor=Cedula_Supervisorp;
Zona=Zonap;
Cliente=Clientep;
Descripcion_SKU=Descripcion_SKUp;
UnidadesxSKU=UnidadesxSKUp;
Observaciones=Observacionesp;
Seguimiento_3_meses=Seguimiento_3_mesesp;
Seguimiento_5_meses=Seguimiento_5_mesesp;
}
#endregion
}
}
