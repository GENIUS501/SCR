using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Negocios
{ 
   public class Supervisores{
        #region Atributos 
          public int Cedula {get;set;}
          public string Nombre {get;set;}
          public string Primer_Apellido {get;set;}
          public string Segundo_Apellido {get;set;}
          public int Telefono { get; set; }
          public string Correo { get; set; }
#endregion
#region Constructor sin parametros
      public Supervisores()
        {
            Cedula= 0;
            Nombre= "";
            Primer_Apellido= "";
            Segundo_Apellido= "";
            Telefono = 0;
            Correo = "";
        }
#endregion  
#region Constructor con parametros 
public Supervisores(int Cedulap,string Nombrep,string Primer_Apellidop,string Segundo_Apellidop,string Correop,int Telefonop){
Cedula=Cedulap;
Nombre=Nombrep;
Primer_Apellido=Primer_Apellidop;
Segundo_Apellido=Segundo_Apellidop;
            Correo = Correop;
            Telefono = Telefonop;
}

        public Supervisores(Supervisores Supp )
        {
            Cedula = Supp.Cedula;
            Nombre = Supp.Nombre;
            Primer_Apellido = Supp.Primer_Apellido;
            Segundo_Apellido = Supp.Segundo_Apellido;
            Telefono = Supp.Telefono;
            Correo = Supp.Correo;
        }
        #endregion
    }
}
