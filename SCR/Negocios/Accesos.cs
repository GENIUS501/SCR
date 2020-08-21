using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Accesos{
        #region Atributos 
          public int Id_Rol {get;set;}
          public int Modulo {get;set;}
          public string Accion {get;set;}
#endregion
#region Constructor sin parametros
      public Accesos()
{
Id_Rol= 0;
Modulo= 0;
Accion= "";
}
#endregion  
#region Constructor con parametros 
public Accesos(int Id_Rolp,int Modulop,string Accionp){
Id_Rol=Id_Rolp;
Modulo=Modulop;
Accion=Accionp;
}
#endregion
}
}
