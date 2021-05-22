using Proyecto8voA.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8voA.Vista
{
    public partial class AnadirPartidosPoliticos : Form
    {
        OpenFileDialog Ventana_seleccionar;
        Controlador controlador;
        MemoryStream ms;
        public AnadirPartidosPoliticos()
        {
            InitializeComponent();
            Ver_Imagen.Image = null;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Guardar.Enabled = false;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            //obtener imagen guardarla y convertirla en byte
            ms = new MemoryStream();
            byte[] aByte;
            Ver_Imagen.Image.Save(ms, ImageFormat.Jpeg);
            controlador = new Controlador();
            aByte = ms.ToArray();
            string nombre = Txt_Nombre_p.Text;
            
            //verifica que el campo de imagen no este vacio 
            bool isNullOrEmpty = Ver_Imagen == null || Ver_Imagen.Image == null;//esto puede ser un metodo pero no entiendo tbh
            Console.WriteLine(isNullOrEmpty + "maldicioooon");
            if (!isNullOrEmpty)//si esta lleno !false pasa caso contrario no
            {
                List<TextBox> campos = new List<TextBox>();
                campos.Add(Txt_Nombre_p);
                if (!controlador.Verificar_campos_vacios(campos))
                {
                    controlador.Modificar_partidos(aByte, nombre, 1);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("HAY CAMPOS VACIOS QUE NECESITAN SER LLENADOS", "Atencion");
                }
            }

            this.Dispose();
            /*
                pbimage.image = null//vaciar campo
            */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnadirPartidosPoliticos_Load(object sender, EventArgs e)
        {

        }

        private void Btn_CargarFoto_Click(object sender, EventArgs e)
        {
            //este codigo es para obtener una imagen
            Ventana_seleccionar = new OpenFileDialog();
            Ventana_seleccionar.Filter = "Imagenes|*.jpg;*.png;*.jpeg";
            Ventana_seleccionar.Title = "Seleccionar imagen";//agregar enviroment.getfolderpath(enviroment.specialfolder.mypicture)??//para que comience directo de una carpeta?
            if (Ventana_seleccionar.ShowDialog() == DialogResult.OK)
            {
              Ver_Imagen.Image = Image.FromFile(Ventana_seleccionar.FileName);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            //crear mensaje para confirmar eliminar
            const string mensaje = "¿DESEA BORRAR ESTE DATO ?";
            const string titulo = "CONFIRMACION";
            var resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //se debe agregar un mensaje de pantalla para confirmar
            if (resultado == DialogResult.Yes)
            {
                string nombre = Txt_Nombre_p.Text;
                controlador = new Controlador();
                controlador.Modificar_partidos(null, nombre, 3);//3 para activar el campo eliminar en controlador
               // MessageBox.Show("SE HAN ELIMINADOS DATOS EN LA BD", "Atencion");
                this.Dispose();
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

            controlador = new Controlador();
            ms = new MemoryStream();
            byte[] abyte;
            Ver_Imagen.Image.Save(ms, ImageFormat.Jpeg);
            abyte = ms.ToArray();
            string nombre = Txt_Nombre_p.Text;
            bool isNullOrEmpty = Ver_Imagen == null || Ver_Imagen.Image == null;//esto puede ser un metodo pero no entiendo tbh
            if (!isNullOrEmpty)//si esta lleno !true pasa caso contrario no
            {
                DialogResult op = MessageBox.Show("¿Seguro que quieres modificar a "+nombre+"?", "MODIFICAR", MessageBoxButtons.YesNo);
                if (op == DialogResult.Yes)
                {
                    controlador.Modificar_partidos(abyte, nombre, 2); ;
                    Dispose();
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA IMAGEN", "Atencion");
            }
            
        }

        private void Txt_change_nombre(object sender, EventArgs e)
        {
            string buscar_nombre = Txt_Nombre_p.Text;
            controlador = new Controlador();
            bool aux = controlador.Verificar_existe_partido(buscar_nombre);
            Console.WriteLine("eooooooo" + aux);
            if (buscar_nombre.Equals("Nulo") || buscar_nombre.Equals("NULO"))
            {
                Ver_Imagen.Image = null;
                Btn_Modificar.Enabled = false;
                Btn_Eliminar.Enabled = false;
                Btn_Guardar.Enabled = false;
            }
            else
            {

                if (aux)//si existe que se llene caso contrario no
                {
                    List<object> datos = new List<object>();
                    datos = controlador.Llenar_campos(buscar_nombre, 3);
                    ms = new MemoryStream();
                    ms = (MemoryStream)datos[1];
                    Bitmap bp = new Bitmap(ms);
                    Ver_Imagen.Image = bp;
                    Btn_Modificar.Enabled = true;
                    Btn_Eliminar.Enabled = true;
                    Btn_Guardar.Enabled = false;
                }
                else
                {
                    Ver_Imagen.Image = null;
                    Btn_Modificar.Enabled = false;
                    Btn_Eliminar.Enabled = false;
                    Btn_Guardar.Enabled = true;
                }
            }
        }
    }
}
