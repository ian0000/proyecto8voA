using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8voA
{
    public class ConexionBD
    {
        private static string USER = "root"; //static => Porque creara un puntero a memoria que no se va a mover
        private static string PASS = "alejo";
        private static string NOMBREBD = "proyectopda";
        private static string SERVIDOR = "localhost";

        static string cadenaConexion = "Server ="+  SERVIDOR+"; Database="+NOMBREBD+";User Id = "+USER+"; Password="+ PASS+";";//debe ser este orden o morimos
        //ejemplo de como se va a conectar
       // conexion = new ConexionBD();//declaracion conexion
       // BaseVontantesCON baseVontantes = new BaseVontantesCON(conexion);//declaracion de otras clases 
       // baseVontantes.compararCedula("1321");//ejemplo de como pasar datos
        public MySqlConnection cnx()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cadenaConexion);
                return con;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

    }
}
