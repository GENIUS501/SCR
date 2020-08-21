using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Roles
    {
        #region Atributos 
          public int Id_Rol {get;set;}
          public string Nombre_Rol {get;set;}
#endregion
        #region Constructor sin parametros
      public Roles()
        {
            Id_Rol= 0;
            Nombre_Rol= "";
        }
#endregion  
        #region Constructor con parametros 
        public Roles(int Id_Rolp,string Nombre_Rolp)
        {
            Id_Rol=Id_Rolp;
            Nombre_Rol=Nombre_Rolp;
        }
#endregion
    }
}
