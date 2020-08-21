using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Punto_Venta_Cliente{
        #region Atributos 
          public string Nombre {get;set;}
          public string Direccion {get;set;}
          public int Telefono {get;set;}
          public string CorreoElectronico {get;set;}
          public int Cedula_juridica_fisica {get;set;}
#endregion
#region Constructor sin parametros
      public Punto_Venta_Cliente()
{
Nombre= "";
Direccion= "";
Telefono= 0;
CorreoElectronico= "";
Cedula_juridica_fisica= 0;
}
#endregion  
#region Constructor con parametros 
public Punto_Venta_Cliente(string Nombrep,string Direccionp,int Telefonop,string CorreoElectronicop,int Cedula_juridica_fisicap){
Nombre=Nombrep;
Direccion=Direccionp;
Telefono=Telefonop;
CorreoElectronico=CorreoElectronicop;
Cedula_juridica_fisica=Cedula_juridica_fisicap;
}
#endregion
}
}
