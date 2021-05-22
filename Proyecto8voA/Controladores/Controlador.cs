using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8voA.Controladores
{
    class Controlador
    {

        ConexionBD conexion;
        BaseVontantesCON baseVotantesCON;
        PartidoPoliticoCON partidoPoliticoCON;
        CandidatoCON candidatoCON;
        VotacionesCON votaciones;

        public Controlador()
        {
            this.conexion = conexion;
        }

        //crear votante
        public void Modificar_votantes(string bas_cedula_identidad, string bas_nombres, string bas_apellidos, int selector)
        {
            
            Modelo.BaseVotantes baseVotantes = new Modelo.BaseVotantes(bas_cedula_identidad, bas_nombres, bas_apellidos);
            conexion = new ConexionBD();
            baseVotantesCON = new BaseVontantesCON(conexion);
            if(selector == 1)
            {
                baseVotantesCON.Crear_votante(baseVotantes);
            }else if(selector == 2)
            {
                baseVotantesCON.Editar_votantes(baseVotantes);
            }
            else if(selector == 3)
            {
                baseVotantesCON.Eliminar_votante(bas_cedula_identidad);
            }
        }

        //crear partido politico
        public void Modificar_partidos(byte[] par_logo, string par_nombre, int selector)
        {
            Modelo.PartidoPolitico partidoPolitico = new Modelo.PartidoPolitico(par_logo, par_nombre);
            conexion = new ConexionBD();
            partidoPoliticoCON = new PartidoPoliticoCON(conexion);
            if (selector == 1)
            {
                partidoPoliticoCON.Crear_partido(partidoPolitico);
            }
            else if (selector == 2)
            {
                partidoPoliticoCON.Modificar_partido(partidoPolitico);
            }
            else if (selector == 3)
            {
                partidoPoliticoCON.Eliminar_partido(partidoPolitico);
            }
        }
        //comprobar cedula votantes en bd
        public bool Comprobar_cedula_votante(string cedula)
        {
            conexion = new ConexionBD();
            MySqlConnection con = conexion.cnx();
            baseVotantesCON = new BaseVontantesCON(conexion);
            return baseVotantesCON.Comprobar_cedula(cedula);
        }

        //falta comparador de cedula

        //comprobar que los campos esten llenos y no se queden vacios
        public bool Verificar_campos_vacios(List<TextBox> campos)
        {
            bool aux = false;
            for (int i = 0; i < campos.Count; i++)
            {
                TextBox txt = campos.ElementAt(i);
                if (txt.Text.Equals(""))
                {
                    aux = true;
                }
            }
            return aux;
        }

        public List<object> Llenar_campos(string cedula,int seleccion)
        {
            List<object> datos = new List<object>(); 
            conexion = new ConexionBD();
            if (seleccion == 1)
            {
                baseVotantesCON = new BaseVontantesCON(conexion);
                datos = baseVotantesCON.Obtener_datos(cedula);
            }
            else if (seleccion == 2)
            {
                candidatoCON = new CandidatoCON(conexion);
                datos = candidatoCON.Obtener_datos(cedula);
            }
            else if(seleccion == 3)
            {
                partidoPoliticoCON = new PartidoPoliticoCON(conexion);
                datos = partidoPoliticoCON.Obtener_datos(cedula);
            }


            return datos;
        }
        public string nombrepartido(string id)
        {
            conexion = new ConexionBD();
            partidoPoliticoCON = new PartidoPoliticoCON(conexion);
            string aux= partidoPoliticoCON.nombrePartido(id);
            return aux;
        }

        public bool Verificar_existe_partido(string nombre)
        {

            conexion = new ConexionBD();
            MySqlConnection con = conexion.cnx();
            partidoPoliticoCON = new PartidoPoliticoCON(conexion);
            return partidoPoliticoCON.Verificar_existencia(nombre);
        }
        
        //Miguel
        //Control Candidato Inser Update Delete
        public void modificar_Candidato(string bas_cedula_identidad, int partido, string rol, byte[] imagen, int selector, string bas_nombre,string bas_apellido,string id_partido)
        {
            Modelo.Candidato MCandidato = new Modelo.Candidato(rol,imagen, bas_cedula_identidad,  bas_nombre,bas_apellido);
            partidoPoliticoCON = new PartidoPoliticoCON(conexion);
            conexion = new ConexionBD();
            candidatoCON = new CandidatoCON(conexion);
            int id = partidoPoliticoCON.obtener_id(id_partido);
            if (selector == 1)
            {
                candidatoCON.crearCandidato(MCandidato,id);
            }
            else if (selector == 2)
            {
                candidatoCON.EditarCandidato(MCandidato,id);
            }
            else if (selector == 3)
            {
                candidatoCON.EliminarCandidato(MCandidato);
            }
        }
        public bool Comprobar_cedula_Candidato(string cedula)
        {
            conexion = new ConexionBD();
            MySqlConnection con = conexion.cnx();
            candidatoCON = new CandidatoCON(conexion);
            return candidatoCON.Comprobar_cedula(cedula);
        }

        //Llenar combobox Partido
        public List<String> ComBoxPartidos()
        {
            List<string> datos = new List<string>();
            conexion = new ConexionBD();
            candidatoCON = new CandidatoCON(conexion);
            datos = candidatoCON.comboxPartido();
            return datos;
        }

        //Llenar la informacion de presidente y vice
        public List<object> Llenar_campos_votaciones(string rol,string partido)
        {
            List<object> datos = new List<object>();
            conexion = new ConexionBD();
            partidoPoliticoCON = new PartidoPoliticoCON(conexion);
            int id = partidoPoliticoCON.obtener_id(partido);
            //1 presidente
                candidatoCON = new CandidatoCON(conexion);
                datos = candidatoCON.Obtener_Presidente(rol,id);
            return datos;
        }

        public bool Comprobar_canditato_PresiVice(string Rol,string partido)
        {
            conexion = new ConexionBD();
            MySqlConnection con = conexion.cnx();
            partidoPoliticoCON = new PartidoPoliticoCON(conexion);
            int id = partidoPoliticoCON.obtener_id(partido);
            candidatoCON = new CandidatoCON(conexion);
            return candidatoCON.Comprobar_Rol(Rol,id);
        }

        public void GuardarVotacion(string Cedula,string Partido)
        {
            conexion = new ConexionBD();
            MySqlConnection con = conexion.cnx();
            partidoPoliticoCON = new PartidoPoliticoCON(conexion);
            votaciones = new VotacionesCON(conexion);
            int id = partidoPoliticoCON.obtener_id(Partido);
            votaciones.Crear_votante(Cedula, id);
        }


        public bool Comprobar_votante(string cedula)
        {
            conexion = new ConexionBD();
            MySqlConnection con = conexion.cnx();
            VotacionesCON votaciones = new VotacionesCON(conexion);
            return votaciones.Comparar_cedula(cedula);
        }


        public int contador_partido()
        {
            Modelo.PartidoPolitico partidoPolitico = new Modelo.PartidoPolitico();
            conexion = new ConexionBD();
            partidoPoliticoCON = new PartidoPoliticoCON(conexion);
            return partidoPoliticoCON.contador_Partidos();
        }

        public List<object> obtener_nombre()
        {
            List<object> datos = new List<object>();
            conexion = new ConexionBD();
            partidoPoliticoCON = new PartidoPoliticoCON(conexion);
            datos = partidoPoliticoCON.obtener_nombre();
            
            return datos;
        }

        public int obtener_votos(string nombre)
        {
            conexion = new ConexionBD();
            partidoPoliticoCON = new PartidoPoliticoCON(conexion);
            return partidoPoliticoCON.obtener_votos(nombre);
        }
    }

}
