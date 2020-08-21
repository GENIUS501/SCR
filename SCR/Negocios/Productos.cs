using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Productos{
        #region Atributos 
          public int Codigo_Producto {get;set;}
          public string Nombre {get;set;}
          public string Descripcion {get;set;}
          public string Marca {get;set;}
#endregion
#region Constructor sin parametros
      public Productos()
{
Codigo_Producto= 0;
Nombre= "";
Descripcion= "";
Marca= "";
}
#endregion  
#region Constructor con parametros 
public Productos(int Codigo_Productop,string Nombrep,string Descripcionp,string Marcap){
Codigo_Producto=Codigo_Productop;
Nombre=Nombrep;
Descripcion=Descripcionp;
Marca=Marcap;
}
#endregion
}
}
