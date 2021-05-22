using AForge.Video;
using AForge.Video.DirectShow;
using Proyecto8voA.Controladores;
using Proyecto8voA.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8voA
{
    public partial class Form1 : Form
    {
        Controlador controlador;
        MemoryStream ms;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice webcam;
        public Form1()
        {
            InitializeComponent();
            labelObtenerNombreCandidato.Visible = false;
            Btn_Guardar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            LlenarPartido();
            Btn_CargarFoto.Enabled = true;
            CerrarCamara();
            comboBox1.Enabled = false;
            CargarDispositivos();
        }

        //Identifica los dispositivos instalados de video
        public void CargarDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                
                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    comboBox1.Items.Add(MisDispositivos[i].Name.ToString());
                }
                comboBox1.SelectedItem = null;
            }
        }

        private void LlenarPartido()
        {
            controlador = new Controlador();
            List<String> partidos = new List<string>();
             partidos = controlador.ComBoxPartidos();
            Combox_Partido.DataSource = new BindingSource(partidos, null);
            Combox_Partido.DisplayMember = "Partidos";
            //Combox_Partido.Items.Add(partidos);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CargarFoto_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Ver_Imagen.Image = Ver_Imagen.Image;
                CerrarCamara();
                checkBox1.Checked = false;
            }
            else
            {
                OpenFileDialog Ventana_seleccionar = new OpenFileDialog();
                Ventana_seleccionar.Filter = "Imagenes|*.jpg;*.png;*.jpeg";
                Ventana_seleccionar.Title = "Seleccionar imagen";
                if (Ventana_seleccionar.ShowDialog() == DialogResult.OK)
                {
                    Ver_Imagen.Image = Image.FromFile(Ventana_seleccionar.FileName);

                }
            }
        }

        private void Txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void Combox_Rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            controlador = new Controlador();
            ms = new MemoryStream();
            byte[] abyte;
            Ver_Imagen.Image.Save(ms, ImageFormat.Jpeg);
            abyte = ms.ToArray();
            string cedula = Txt_Cedula.Text, rol = Combox_Rol.SelectedItem.ToString();
            string nombrepartido = Combox_Partido.SelectedItem.ToString(); 
            bool rolexiste = controlador.Comprobar_canditato_PresiVice(rol, nombrepartido);
            if (rolexiste)
            {
                MessageBox.Show("Ese puesto ya esta registrado");
            }
            else
            {
                bool isNullOrEmpty = Ver_Imagen == null || Ver_Imagen.Image == null;//esto puede ser un metodo pero no entiendo tbh
                if (!isNullOrEmpty)//si esta lleno !true pasa caso contrario no
                {
                    List<TextBox> campos = new List<TextBox>();
                    campos.Add(Txt_Cedula);
                    if (!controlador.Verificar_campos_vacios(campos))
                    {
                        List<object> nombrescompleto = new List<object>();
                        nombrescompleto = controlador.Llenar_campos(cedula, 1);
                        controlador.modificar_Candidato(cedula, 0, rol, abyte, 1, nombrescompleto[0].ToString(), nombrescompleto[1].ToString(), nombrepartido);
                        Txt_Cedula.Text = "";
                        Combox_Partido.SelectedIndex = 0;
                        Combox_Rol.SelectedIndex = 0;
                        Ver_Imagen.Image = null;
                        CerrarCamara();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("HAY CAMPOS VACIOS QUE NECESITAN SER LLENADOS", "Atencion");
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Cedula_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Cedula.Text.Length.Equals(10))
            {
                controlador = new Controlador();
                string buscar_cedula = Txt_Cedula.Text;
                bool aux = controlador.Comprobar_cedula_Candidato(buscar_cedula);
                //Si existe en candidato
                if (aux)
                {
                    List<object> datos = new List<object>();
                    datos = controlador.Llenar_campos(buscar_cedula, 2); //modificar bien
                    string nombrecompleto = datos[4].ToString() +" " + datos[5].ToString(); 
                    labelObtenerNombreCandidato.Text = nombrecompleto;
                    labelObtenerNombreCandidato.Visible = true;
                    Combox_Partido.SelectedIndex =(int) datos[3]-1;
                    Combox_Rol.SelectedItem = datos[0];
                    // genero memory stram
                    ms = new MemoryStream();
                    //Genero que mi datos sea tipo memory Stream
                    ms = (MemoryStream)datos[1];
                    //Cambio a Bitmap
                    Bitmap bp = new Bitmap(ms);
                    Ver_Imagen.Image = bp; 
                    Btn_Modificar.Enabled = true;
                    Btn_Guardar.Enabled = false;
                    Btn_Eliminar.Enabled = true;
                }
                else
                {
                    aux = controlador.Comprobar_cedula_votante(buscar_cedula);
                    //si existe en votantes
                    if (aux)
                    {
                       
                            //poner que se llene en caso de que si existan y que el boton sea visible o no
                            List<object> datos = new List<object>();
                            datos = controlador.Llenar_campos(buscar_cedula, 1);
                            string nombrecompleto = datos[0].ToString() + " " + datos[1].ToString();
                            if(nombrecompleto!="Master Root")
                        {
                            labelObtenerNombreCandidato.Text = nombrecompleto;
                            labelObtenerNombreCandidato.Visible = true;
                            Btn_Guardar.Enabled = true;
                            Btn_Modificar.Enabled = false;
                            Btn_Eliminar.Enabled = false;
                        }
                        else
                        {
                            Btn_Guardar.Enabled = false;
                            Btn_Modificar.Enabled = false;
                            Btn_Eliminar.Enabled = false;
                        }

                    }
                    //si no existe en candidatos ni votantes
                    else
                    {
                        DialogResult op = MessageBox.Show("¿Desea ingrsar los datos?", "Votante nuevo", MessageBoxButtons.YesNo);
                        if (op == DialogResult.Yes)
                        {
                            AnadirVotantes V_votantes = new AnadirVotantes();
                            this.Dispose();
                            V_votantes.TxtCedula.Text = buscar_cedula;
                            V_votantes.Visible = true;
                            
                        }
                    }
                }
            }
            else
            {
                labelObtenerNombreCandidato.Text="";
                labelObtenerNombreCandidato.Visible = false;
                Btn_Modificar.Enabled = false;
                Btn_Guardar.Enabled = false;
                Btn_Eliminar.Enabled = false;
                Ver_Imagen.Image = null;
                Combox_Partido.SelectedItem = null;
                Combox_Rol.SelectedIndex = 0;
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            controlador = new Controlador();
            ms = new MemoryStream();
            byte[] abyte;
            Ver_Imagen.Image.Save(ms, ImageFormat.Jpeg);
            abyte = ms.ToArray();
            string cedula = Txt_Cedula.Text, rol = Combox_Rol.SelectedItem.ToString();
            string nompartido = Combox_Partido.SelectedItem.ToString(); 
            List<TextBox> campos = new List<TextBox>();
            campos.Add(Txt_Cedula);
            
                bool isNullOrEmpty = Ver_Imagen == null || Ver_Imagen.Image == null;//esto puede ser un metodo pero no entiendo tbh
                if (!isNullOrEmpty)//si esta lleno !true pasa caso contrario no
                {
                    if (!controlador.Verificar_campos_vacios(campos))
                    {
                        List<object> nombrescompleto = new List<object>();
                        nombrescompleto = controlador.Llenar_campos(cedula, 1);
                        controlador.modificar_Candidato(cedula, 0, rol, abyte, 2, nombrescompleto[0].ToString(), nombrescompleto[1].ToString(), nompartido);
                        Txt_Cedula.Text = "";
                        Combox_Partido.SelectedIndex = 0;
                        Combox_Rol.SelectedIndex = 0;
                        Ver_Imagen.Image = null;
                        CerrarCamara();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("HAY CAMPOS VACIOS QUE NECESITAN SER LLENADOS", "Atencion");
                        this.Dispose();
                    }
                }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            controlador = new Controlador();
            ms = new MemoryStream();
            byte[] abyte;
            Ver_Imagen.Image.Save(ms, ImageFormat.Jpeg);
            abyte = ms.ToArray();
            string nompartido = Combox_Partido.SelectedText;
            List<object> nombrescompleto = new List<object>();
            string cedula = Txt_Cedula.Text, rol = Combox_Rol.SelectedItem.ToString();
            nombrescompleto = controlador.Llenar_campos(cedula, 1);
            DialogResult op = MessageBox.Show("¿Seguro que quieres eliminar a"+nombrescompleto[0].ToString()+" "+nombrescompleto[1].ToString()+" ?","Eliminar",MessageBoxButtons.YesNo);
            if (op == DialogResult.Yes)
            {
                controlador.modificar_Candidato(cedula, 0, rol, abyte, 3, nombrescompleto[0].ToString(), nombrescompleto[1].ToString(), nompartido);
                Txt_Cedula.Text = "";
                Combox_Partido.SelectedIndex = 0;
                Combox_Rol.SelectedIndex = 0;
                Ver_Imagen.Image = null;
                CerrarCamara();
                this.Dispose();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Btn_CargarFoto.Enabled = false;
                comboBox1.Enabled = true;
                Ver_Imagen.Image = null;
                Btn_CargarFoto.Text = "Capturar";
            }
            else
            {
                Btn_CargarFoto.Text = "Seleccionar foto";
                CerrarCamara();
                Btn_CargarFoto.Enabled = true;
                comboBox1.Enabled = false;
                comboBox1.SelectedItem = null;
            }
        }

        //apago la camara si no se tiene esto la camara se queda activa y no se podra usar en otros programas
        private void CerrarCamara()
        {
            if (webcam != null && webcam.IsRunning)
            {
                webcam.SignalToStop();
                webcam = null;
            }
        }

        //captura los movimientos
        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap ImagenCamara = (Bitmap)eventArgs.Frame.Clone();
            Ver_Imagen.Image = ImagenCamara;

        }

        

        private void BtnCaptura_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CerrarCamara();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CerrarCamara();
            Ver_Imagen.Image = null;
            int camarabox = comboBox1.SelectedIndex;
            String nombrecamara = MisDispositivos[camarabox].MonikerString;
            webcam = new VideoCaptureDevice(nombrecamara);
            //aqui se integra el capturando
            webcam.NewFrame += new NewFrameEventHandler(Capturando);
            webcam.Start();
            if (webcam.IsRunning) { 
            
                Btn_CargarFoto.Enabled = true;

            }
            else
            {
                Btn_CargarFoto.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
