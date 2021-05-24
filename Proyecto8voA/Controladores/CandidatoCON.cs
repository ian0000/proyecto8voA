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
    class CandidatoCON
    {
        private ConexionBD conexion;

        public CandidatoCON(ConexionBD conexion)
        {
            this.conexion = conexion;
        }

        //Miguel 
        public bool comprobarCedula(string cedula)
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

        //Funciona
        public void crearCandidato(Candidato entrada,int idpartido)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();
                //inicio de la sentencia para bd insertar un nuevo candidato
                MySqlCommand command = new MySqlCommand("INSERT INTO tcandidato (can_rol,can_foto,FK_votantes_candidato,FK_partidopolitico_candidato) VALUES('" + entrada.get_can_rol() + "',@imagen,'"+entrada.Get_bas_cedula_identidad()+"',"+idpartido+")", con);
                command.Parameters.AddWithValue("@imagen",entrada.get_can_foto());
                command.ExecuteNonQuery();
                MessageBox.Show("Se guardó correctamente");
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al crear candidato " + ex);
                MessageBox.Show("Error al crear candidato "+ex);
            }
        }

        public void EditarCandidato(Candidato entrada,int idpartido)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();
                //inicio de la sentencia para bd insertar un nuevo votante
                MySqlCommand command = new MySqlCommand("UPDATE tcandidato SET can_rol = '"+entrada.get_can_rol()+"' , can_foto = @imagen , FK_partidopolitico_candidato = " + idpartido + " WHERE FK_votantes_candidato = '" + entrada.Get_bas_cedula_identidad()+"' ", con);
                command.Parameters.AddWithValue("@imagen", entrada.get_can_foto());
                command.ExecuteNonQuery();
                MessageBox.Show("Se actualizó correctamente");
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al editar Votante " + ex);
            }
        }
        public void EliminarCandidato(Candidato entrada)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();
                con.Open();
                //inicio de la sentencia para bd insertar un nuevo votante
                MySqlCommand command = new MySqlCommand("DELETE FROM tcandidato WHERE FK_votantes_candidato ='"+entrada.Get_bas_cedula_identidad()+"'", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Se eleminó correctamente");
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al editar Votante " + ex);
                MessageBox.Show("Error ");
            }
        }
        
        public bool Comprobar_cedula(string cedula)
        {
            bool aux = false;
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT FK_votantes_candidato FROM tcandidato WHERE FK_votantes_candidato= '" + cedula + "'", con);
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

        //Editar y entender el codigo
        public List<object> Obtener_datos(string cedula)
        {
            List<object> datos = new List<object>();
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT tcan.*,tbv.bas_nombres,tbv.bas__apellidos FROM tcandidato tcan inner join tbasevotantes tbv on tcan.FK_votantes_candidato=tbv.bas_cedula_identidad WHERE FK_votantes_candidato= '" + cedula + "'", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MemoryStream ms = new MemoryStream((byte[])reader[2]);
                    
                    //string can_rol, byte[] can_foto, string bas_cedula_identidad, string bas_nombres, string bas__apellidos
                    datos.Add(reader.GetString(1));
                    datos.Add(ms);
                    datos.Add(reader.GetString(3));
                    datos.Add(reader.GetInt32(4));
                    datos.Add(reader.GetString(5));
                    datos.Add(reader.GetString(6));
                }
                reader.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al buscar Candidato " + ex);
            }
            return datos;
        }
        public List<string> comboxPartido()
        {
            List<string> datos = new List<string>();
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT par_nombre FROM tpartidopolitico WHERE par_id>1 ORDER BY par_id", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BaseVotantes baseVotantes = new BaseVotantes();
                    datos.Add(reader.GetString("par_nombre"));
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

        public List<object> Obtener_Presidente(string rol, int partido)
        {
            List<object> datos = new List<object>();
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT tcan.can_rol, tcan.can_foto,tbv.bas_nombres,tbv.bas__apellidos,FK_partidopolitico_candidato from tcandidato tcan inner join tbasevotantes tbv on tcan.FK_votantes_candidato=tbv.bas_cedula_identidad inner join tpartidopolitico tpp on tcan.FK_partidopolitico_candidato=tpp.par_id where tcan.FK_partidopolitico_candidato = "+partido+" and tcan.can_rol='"+rol+"'", con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MemoryStream ms = new MemoryStream((byte[])reader[1]); //imagen base

                    //string can_rol, byte[] can_foto, string bas_cedula_identidad, string bas_nombres, string bas__apellidos
                    datos.Add(reader.GetString(0));// can rol
                    datos.Add(ms); //imagen ms 1
                    datos.Add(reader.GetString(2));//nombre 2
                    datos.Add(reader.GetString(3));//apellido 3
                    datos.Add(reader.GetInt32(4));//Partido
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

        public bool Comprobar_Rol(string Rol,int partido)
        {
            bool aux = false;
            try
            {
                MySqlConnection con = conexion.cnx();
                con.Open();
                MySqlCommand command = new MySqlCommand("SELECT can_rol FROM tcandidato WHERE can_rol = '" + Rol + "' and FK_partidopolitico_candidato ="+partido, con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string verificador = reader.GetString(0);
                    if (verificador.Equals(Rol))
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
    }
}
