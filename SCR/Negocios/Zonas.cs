using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Zonas{
        #region Atributos 
          public int Id_Zona {get;set;}
          public string Nombre_Zona {get;set;}
#endregion
#region Constructor sin parametros
      public Zonas()
{
Id_Zona= 0;
Nombre_Zona= "";
}
#endregion  
#region Constructor con parametros 
public Zonas(int Id_Zonap,string Nombre_Zonap){
Id_Zona=Id_Zonap;
Nombre_Zona=Nombre_Zonap;
}
#endregion
}
}
