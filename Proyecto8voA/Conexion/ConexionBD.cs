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
        //datos para la base de datos, en caso de necesitar se cambian estos y no el string
        private static string USER = "root"; //static => Porque creara un puntero a memoria que no se va a mover
        private static string PASS = "ianrootpass";
        private static string NOMBREBD = "proyectopd2";
        private static string SERVIDOR = "localhost";

        //cadena necesaria para la conexion con el servidor // en esta se puede aumentar el puerto en caso de esatr trabajando con otros puertos 
        static string cadenaConexion = "Server ="+  SERVIDOR+"; Database="+NOMBREBD+";User Id = "+USER+"; Password="+ PASS+";";//debe ser este orden o morimos
        //ejemplo de como se va a conectar
       // conexion = new ConexionBD();//declaracion conexion
       // BaseVontantesCON baseVontantes = new BaseVontantesCON(conexion);//declaracion de otras clases 
       // baseVontantes.compararCedula("1321");//ejemplo de como pasar datos
        
        //el metodo mas importante ya que con este se realiza todas las conexiones
        public MySqlConnection cnx()
        {

            //siempre debe ir con un try para controlar de que haya conexion y en caso de no haber no se salga de la app
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
