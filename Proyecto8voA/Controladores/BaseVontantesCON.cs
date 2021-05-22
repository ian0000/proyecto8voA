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


        public BaseVontantesCON(ConexionBD conexion)
        {
            this.conexion = conexion;
        }

        public bool Comparar_cedula(string cedula)
        {
            bool aux = false;
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();
                //inicio de la sentencia para bd
                MySqlCommand command = new MySqlCommand("SELECT * FROM tbasevotantes WHERE bas_cedula_identidad = '" + cedula + "' ", con);
                MySqlDataReader lector = command.ExecuteReader();
                if (lector.Read())
                {
                    aux = true;
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                aux = false;
            }
            return aux;
        }

        public void Crear_votante(BaseVotantes baseVontantes)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();

                {
                    con.Open();
                    //inicio de la sentencia para bd insertar un nuevo votante
                    MySqlCommand command = new MySqlCommand("INSERT INTO tbasevotantes VALUES('" + baseVontantes.Get_bas_cedula_identidad() + "','" + baseVontantes.Get_bas_nombres() + "', '" + baseVontantes.Get_bas__apellidos() + "')", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al crear Votante " + ex);
            }
        }

        public void Eliminar_votante(string cedula)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();
                //sentencia para eliminar un votante
                MySqlCommand command = new MySqlCommand("DELETE FROM tbasevotantes WHERE bas_cedula_identidad = '" + cedula + "'",con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
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
                command.ExecuteNonQuery();
                MessageBox.Show("SE HAN MODIFICADOS DATOS EN LA BD", "Atencion");
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al modificar Votante " + ex);
                MessageBox.Show("Error al modificar votante"+ex, "Atencion");


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
                Console.WriteLine("Error al buscar Votante " + ex);
            }
            return datos;
        }
    }
}
