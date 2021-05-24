using MySql.Data.MySqlClient;
using Proyecto8voA.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8voA.Controladores
{
    class PartidoPoliticoCON
    {
        public ConexionBD conexion;

        public PartidoPoliticoCON(ConexionBD conexion)
        {
            this.conexion = conexion;
        }

        public void Crear_partido(PartidoPolitico partidoPolitico)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();
                //inicio de la sentencia para bd insertar un nuevo partido
                MySqlCommand command = new MySqlCommand("INSERT INTO tpartidopolitico(par_logo, par_nombre) VALUES(@par_logo, '" + partidoPolitico.get_par_nombre() + "')", con);
                command.Parameters.AddWithValue("@par_logo", partidoPolitico.get_par_logo());
                command.ExecuteNonQuery();
                MessageBox.Show("Se guardó correctamente");
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al crear Partido " + ex);
            }
        }

        public void Eliminar_partido(PartidoPolitico partidoPolitico)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();
                //inicio de la sentencia para bd eliminar un partido
                MySqlCommand command = new MySqlCommand("DELETE FROM tpartidopolitico WHERE par_nombre = '" + partidoPolitico.get_par_nombre()+"'", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Se eliminó correctamente");
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al BORRAR Partido " + ex);
            }
        }

        public void Modificar_partido(PartidoPolitico partidoPolitico)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();
                //inicio de la sentencia para bd modificar un = partido
                MySqlCommand command = new MySqlCommand("UPDATE tpartidopolitico SET par_logo = @par_logo WHERE par_nombre = '" + partidoPolitico.get_par_nombre() + "'", con);
                command.Parameters.AddWithValue("@par_logo", partidoPolitico.get_par_logo());
                command.ExecuteNonQuery();
                MessageBox.Show("Se actualizó correctamente");
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al MODIFICAR Partido " + ex);
            }
        }

        public List<object> Obtener_datos(string par_nombre)
        {
            List<object> datos = new List<object>();
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM tpartidopolitico WHERE par_nombre = '" + par_nombre + "'", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    MemoryStream ms = new MemoryStream((byte[])reader[1]);
                    BaseVotantes baseVotantes = new BaseVotantes();
                    datos.Add(reader.GetValue(0));
                    datos.Add(ms);
                    datos.Add(reader.GetString(2));

                }
                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al buscar Partido Politico " + ex);
            }
            return datos;
        }

        public bool Verificar_existencia(string nombre)
        {
            bool aux = false;
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT par_nombre FROM tpartidopolitico WHERE par_nombre = '" + nombre + "'", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string verificador = reader.GetString(0);
                    if (verificador.Equals(nombre))
                    {
                        aux = true;
                    }
                }
                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error al buscar partido " + ex);
            }
            return aux;
        }

        public int obtener_id(string nombre)
        {
            int aux = 0;
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT par_id FROM tpartidopolitico WHERE par_nombre = '" + nombre + "'", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    aux = reader.GetInt32(0);
                }
                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error al buscar partido " + ex);
            }
            return aux;
        }

        public string nombrePartido(string id)
        {
            string aux = "";
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT par_nombre FROM tpartidopolitico WHERE par_id = '" + id+"'", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    aux = reader.GetString(0);
                }
                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error al buscar partido " + ex);
                MessageBox.Show("Error al buscar partido " + ex);
            }
            return aux;
        }

        public int obtener_votos(string nombre)
        {
            int aux = 0;
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                int aux2 = obtener_id(nombre);
                MySqlCommand command = new MySqlCommand("SELECT COUNT(voto_id) FROM `tvoto` WHERE FK_partidopolitico_voto = '" + aux2 + "'", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    aux = reader.GetInt32(0);
                }
                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error al buscar partido " + ex);
            }
            return aux;
        }


        public int contador_Partidos()
        {
            int aux = 0;
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT COUNT(par_nombre) FROM tpartidopolitico ", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    aux = reader.GetInt32(0);
                }
                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error al buscar partido " + ex);
            }
            return aux;
        }

        public List<object> obtener_nombre()
        {

            List<object> datos = new List<object>();
            int aux = 0;
            try
            {
                aux = contador_Partidos();
                MySqlConnection con = conexion.cnx();
                con.Open();

                MySqlCommand command = new MySqlCommand("SELECT par_nombre FROM tpartidopolitico", con);
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {

                    datos.Add(reader.GetString(0));
                }
                
               
                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {

                Console.WriteLine("Error al buscar partido " + ex);
            }
            return datos;
        }
    }
}
