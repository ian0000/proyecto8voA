using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8voA.Controladores
{
    class VotacionesCON
    {
        public ConexionBD conexion;


        public VotacionesCON(ConexionBD conexion)
        {
            this.conexion = conexion;
        }

        public void Crear_votante(string CedulaVotantes,int Partido)
        {
            try
            {
                //conexion a la bd
                MySqlConnection con = conexion.cnx();

                {
                    con.Open();
                    //inicio de la sentencia para bd insertar un nuevo votante
                    MySqlCommand command = new MySqlCommand("INSERT INTO  tvoto (FK_partidopolitico_voto, FK_votantes_voto) VALUES ('" + Partido + "','" + CedulaVotantes + "')", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Se guardo el voto correctamente");
                    con.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al crear Votante " + ex);
            }
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
                MySqlCommand command = new MySqlCommand("SELECT * FROM tvoto WHERE FK_votantes_voto = '" + cedula + "' ", con);
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





    }
}
