using Proyecto8voA.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8voA.Vista
{
    public partial class Votaciones : Form
    {
        Controlador controlador;
        MemoryStream msPresidente;
        MemoryStream msVicepresidente;
        MemoryStream msPartido;

        public Votaciones()
        {
            InitializeComponent();
            LlenarPartido();
            CB_Partido.SelectedItem = null;
            button1.Enabled = false;
        }

        private void LlenarPartido()
        {
            controlador = new Controlador();
            List<String> partidos = new List<string>();
            partidos = controlador.ComBoxPartidos();
            CB_Partido.DataSource = new BindingSource(partidos, null);
            CB_Partido.DisplayMember = "Partidos";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login V_login = new Login();
            controlador = new Controlador();
            string cedula = Txt_Cedula.Text;
                if (CheckNulo.Checked)
                {
                    DialogResult op = MessageBox.Show("¿Seguro que votaras por: Nulo ?", "Confirmar Votacion", MessageBoxButtons.YesNo);
                    if (op == DialogResult.Yes)
                    {
                        controlador.GuardarVotacion(cedula, "Nulo");
                        Dispose();
                        V_login.Visible = true;
                    }
                }
                else
                {
                    string nombre_partido = CB_Partido.SelectedItem.ToString();
                    DialogResult op = MessageBox.Show("¿Seguro que votaras por: " + nombre_partido + " ?", "Confirmar Votacion", MessageBoxButtons.YesNo);
                    if (op == DialogResult.Yes)
                    {
                        controlador.GuardarVotacion(cedula, nombre_partido);
                        Dispose();
                        V_login.Visible = true;
                    }
                }
        }

        private void Votaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login v_login = new Login();
            v_login.Visible = true;
        }

        private void CB_Partido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            controlador = new Controlador();
            //Control de presidente
            string nomPartido = CB_Partido.SelectedItem.ToString();

            bool auxPresi = controlador.Comprobar_canditato_PresiVice("Presidente",nomPartido);
            bool auxVice = controlador.Comprobar_canditato_PresiVice("Vicepresidente", nomPartido);
            if (auxPresi && auxVice)
            {
                List<object> Presidente = new List<object>();
                Presidente = controlador.Llenar_campos_votaciones("Presidente", nomPartido);
                string nombrePresidente = Presidente[2].ToString() + " " + Presidente[3].ToString();
                //Nombre Presidente
                Txt_Presidente.Text = nombrePresidente;
                //Imagen Presidente
                msPresidente = new MemoryStream();
                //Genero que mi datos sea tipo memory Stream
                msPresidente = (MemoryStream)Presidente[1];
                //Cambio a Bitmap
                Bitmap bpPresidente = new Bitmap(msPresidente);
                Imagen_Presidente.Image = bpPresidente;
                //Controlar Vicepresidente
                List<object> Vicepresidente = new List<object>();
                Vicepresidente = controlador.Llenar_campos_votaciones("Vicepresidente", nomPartido);
                string nombreVicepresidente = Vicepresidente[2].ToString() + " " + Vicepresidente[3].ToString();
                //Nombre Viceresidente
                Txt_Vice.Text = nombreVicepresidente;
                //Imagen Viceresidente
                msVicepresidente = new MemoryStream();
                //Genero que mi datos sea tipo memory Stream
                msVicepresidente = (MemoryStream)Vicepresidente[1];
                //Cambio a Bitmap
                Bitmap bpVicepresidente = new Bitmap(msVicepresidente);
                ImagenVice.Image = bpVicepresidente;
                button1.Enabled = true;
                //PARTIDO POLITICO
                List<object> PartidoPolitico = new List<object>();
                string buscar_partido = CB_Partido.SelectedItem.ToString();
                PartidoPolitico = controlador.Llenar_campos(buscar_partido, 3);
                msPartido = new MemoryStream();
                msPartido = (MemoryStream)PartidoPolitico[1];
                Bitmap bp = new Bitmap(msPartido);
                Imagen_Partido.Image = bp;
            }
            else
            {
                MessageBox.Show("Partido Incompleto");
                button1.Enabled = false;
                Txt_Presidente.Text = null;
                Txt_Vice.Text = null;
                Imagen_Presidente.Image = null;
                ImagenVice.Image = null;
            }
        }

        private void CheckNulo_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckNulo.Checked)
            {
                CB_Partido.SelectedItem = null;
                CB_Partido.Enabled = false;
                ImagenVice.Image = null;
                Imagen_Partido.Image = null;
                Imagen_Presidente.Image = null;
                Txt_Presidente.Text = null;
                Txt_Vice.Text = null;
                button1.Enabled = true;
            }else
            {
                
                CB_Partido.Enabled = true;
                ImagenVice.Image = null;
                Imagen_Partido.Image = null;
                Imagen_Presidente.Image = null;
                Txt_Presidente.Text = null;
                Txt_Vice.Text = null;
                button1.Enabled = false;
            }
        }

        private void Votaciones_Load(object sender, EventArgs e)
        {
            string cedulatxt = Txt_Cedula.Text;
            controlador = new Controlador();
            bool aux = controlador.Comprobar_votante(cedulatxt);
            if (aux)
            {
                Login v_login = new Login();
                MessageBox.Show("Esta cedula ya voto y no se puede duplicar");
                Dispose();
                v_login.Visible = true;
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
