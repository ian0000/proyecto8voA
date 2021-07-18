using MySql.Data.MySqlClient;
using Proyecto8voA.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8voA.Controladores
{
    class BaseVontantesCON
    {
        public ConexionBD conexion;

        //comenzamos con un constructor con el parametro de la bd para cuando se le llame se obtengan todas las conexiones
        public BaseVontantesCON(ConexionBD conexion)
        {
            this.conexion = conexion;
        }

        //con este metodo es con el que se va a crear el votante en bd, se llama de parametro al modelo baseVotantes para poder obtener los datos directamente de ahi
        public void Crear_votante(BaseVotantes baseVontantes)
        {
            //para controlar de que se cree correctamente el dato/valor se realiza un try controlando de que se guarde co
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();

                //inicio de la sentencia para bd insertar un nuevo votante//se obtienen los valores enviados al modelo
                MySqlCommand command = new MySqlCommand("INSERT INTO tbasevotantes VALUES('" + baseVontantes.Get_bas_cedula_identidad() + "','" + baseVontantes.Get_bas_nombres() + "', '" + baseVontantes.Get_bas__apellidos() + "')", con);
                
                //comando para executar la sentencia y cerrar la conexion
                command.ExecuteNonQuery();
                con.Close();
                
            }
            catch (MySqlException ex)
            {
                //para tener mas claro donde ocurrio el error se coloca un comentario de acuerdo a donde ocurre
                Console.WriteLine("Error al crear Votante " + ex);
            }
        }

        //se va a eliminar votantes con este metodo y de esta manera 
        public void Eliminar_votante(string cedula)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();
                //sentencia para eliminar un votante//al ser cedula un PK esta usamos para realizar las busquedas ya que es unica
                MySqlCommand command = new MySqlCommand("DELETE FROM tbasevotantes WHERE bas_cedula_identidad = '" + cedula + "'",con);

                //comando para executar la sentencia y cerrar la conexion
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
                //para tener mas claro donde ocurrio el error se coloca un comentario de acuerdo a donde ocurre
                Console.WriteLine("Error al eliminar Votante " + ex);
            }
        }

        public void Editar_votantes(BaseVotantes baseVotantes)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();

                //para modificar en caso de que fallo
                MySqlCommand command = new MySqlCommand("UPDATE tbasevotantes SET bas_nombres= '" + baseVotantes.Get_bas_nombres() +
                        "', bas__apellidos = '" + baseVotantes.Get_bas__apellidos()+"' WHERE bas_cedula_identidad = '" + baseVotantes.Get_bas_cedula_identidad() + "'", con);

                //comando para executar la sentencia y cerrar la conexion
                command.ExecuteNonQuery();

                //mensaje para asegurarnos de que se modifico corrrectamente
                MessageBox.Show("SE HAN MODIFICADOS DATOS EN LA BD", "Atencion");
                con.Close();
            }
            catch (MySqlException ex)
            {
                //para tener mas claro donde ocurrio el error se coloca un comentario de acuerdo a donde ocurre
                Console.WriteLine("Error al modificar Votante " + ex);


            }
        }

        public bool Comprobar_cedula(string cedula)
        {
            bool aux = false;
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT bas_cedula_identidad FROM tbasevotantes WHERE bas_cedula_identidad = '"+cedula+"'", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string verificador = reader.GetString(0);
                    if (verificador.Equals(cedula))
                    {
                        aux = true;
                    }
                }
                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {

                //para tener mas claro donde ocurrio el error se coloca un comentario de acuerdo a donde ocurre
                Console.WriteLine("Error al buscar Votante " + ex);
            }
            return aux;
        }

        public List<object> Obtener_datos(string cedula)
        {
            List<object> datos = new List<object>();
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tbasevotantes WHERE bas_cedula_identidad = '" + cedula + "'", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BaseVotantes baseVotantes = new BaseVotantes();
                    datos.Add (reader.GetString(1));
                    datos.Add (reader.GetString(2));

                }
                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                //para tener mas claro donde ocurrio el error se coloca un comentario de acuerdo a donde ocurre
                Console.WriteLine("Error al buscar Votante " + ex);
            }
            return datos;
        }
    }
}
