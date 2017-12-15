using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TORRES.CLASES
{
    public static class globales
    {

      // static public string server = "JF-HP\\SQLSE";
     static public string server = "LAPTOP-00G5RV3I\\HUMBERTO";
      // static public string server = "SERVIDOR2017\\ADMINISTRADOR";
        //static public string server = "FACTURACION\\FACTURACION";
        static public string dbn = "TORRES";
        static public string seguridad = "Integrated Security=True";
        //    static public string UserID = "sa";
        //
    //    static public string UserID = "Administrador";
        //  static public string UserID = "sa";
        static public byte nivel = 0; //agregado el 11/04/2017
        static public String lusuario = ""; //agregado el 11/04/2017
        static public String lcontra = ""; //agregado el 11/04/2017
        //static public string Password = "Torres2016";
        static public string Password = "torres2016";
        static public string version = "";
        static public int nr; // Número de Reporte
        static public decimal totalaccesorios;
        static public Boolean planfia;
        static public int pidisan = -1;
        // static public string miconexion = @"Data Source = INFORMATICA-PC; Initial Catalog = TORRES; Persist Security Info = True; User ID = Administrador; Password = torres2016";
        //
       // static public string miconexion = @"Data Source = LAPTOP-00G5RV3I\HUMBERTO; Initial Catalog = TORRES; Persist Security Info = True; User ID = SA; Password = torres2016";
         static public string miconexion = @"Data Source = SERVIDOR2017\ADMINISTRADOR; Initial Catalog = TORRES; Persist Security Info = True; User ID = Administrador; Password = torres2016";
         // static public string miconexion = @"Data Source = JF-HP\SQLSE; Initial Catalog = TORRES; Persist Security Info = True; User ID = Administrador; Password = torres2016";
        // static public string miconexion = @"Data Source = FACTURACION\FACTURACION; Initial Catalog = TORRES; Persist Security Info = True; User ID = sa; Password = torres2016";
        static public string err_mensaje = "";
        static public string err_linea = "";
        static public string err_origen = "";
        static public string err_imagen = "";
        public static void grabaerror()
        {
            DateTime dt = DateTime.Now;
            CLASES.CLERROR err = new CLASES.CLERROR(err_mensaje, err_linea, err_origen, dt, "", 1);
            CLASES.CONEXIONcs c = new CONEXIONcs(err.GRABAR());
            c.EJECUTAR();


        }
    }
}
