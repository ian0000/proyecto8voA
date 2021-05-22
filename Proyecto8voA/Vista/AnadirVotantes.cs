using Proyecto8voA.Controladores;
using Proyecto8voA.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto8voA.Vista
{
    public partial class AnadirVotantes : Form
    {
        Controlador controlador;
        public AnadirVotantes()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            Btn_Guardar.Enabled = false;
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <=64))
            {
                e.Handled = true;
            }
            
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64))
            {
                e.Handled = true;
            }
        }
        
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string cedula = TxtCedula.Text, nombre = TxtNombre.Text, apellido =TxtApellidos.Text;

            controlador = new Controlador();
            List<TextBox> campos = new List<TextBox>();
            campos.Add(TxtCedula);
            campos.Add(TxtNombre);
            campos.Add(TxtApellidos);

            if (!controlador.Verificar_campos_vacios(campos))
            {
                if (!controlador.Comprobar_cedula_votante(cedula))
                {
                    controlador.Modificar_votantes(cedula, nombre, apellido, 1);//1 para activar el campo guardar en controlador
                    MessageBox.Show("SE HAN GUARDADO DATOS EN LA BD", "Atencion");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("NO SE HAN GUARDADO DATOS EN LA BD, LA CEDULA ESTA REPETIDA", "Atencion");
                }
            }
            else
            {
                MessageBox.Show("HAY CAMPOS VACIOS QUE NECESITAN SER LLENADOS", "Atencion");
            }

        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            string cedula = TxtCedula.Text;
            string nombre = TxtNombre.Text;
            string apellido = TxtApellidos.Text;

            controlador = new Controlador();
            List<TextBox> campos = new List<TextBox>();
            campos.Add(TxtCedula);
            campos.Add(TxtNombre);
            campos.Add(TxtApellidos);

            if (!controlador.Verificar_campos_vacios(campos))
            {
                if (controlador.Comprobar_cedula_votante(cedula))
                {
                    controlador.Modificar_votantes(cedula, nombre, apellido, 2);//2 para activar el campo modificar en controlador
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("NO SE HAN GUARDADO DATOS EN LA BD, LA CEDULA ESTA REPETIDA", "Atencion");
                }
            }
            else
            {
                MessageBox.Show("HAY CAMPOS VACIOS QUE NECESITAN SER LLENADOS", "Atencion");
            }
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            //crear mensaje para confirmar eliminar
            const string mensaje = "¿DESEA BORRAR ESTE DATO ?";
            const string titulo = "CONFIRMACION";
            var resultado = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //se debe agregar un mensaje de pantalla para confirmar
            if(resultado == DialogResult.Yes)
            {
                string cedula = TxtCedula.Text;
                controlador = new Controlador();
                controlador.Modificar_votantes(cedula, "","", 3);//3 para activar el campo eliminar en controlador
                MessageBox.Show("SE HAN ELIMINADOS DATOS EN LA BD", "Atencion");
                this.Dispose();
            }
        }

        private void txtchanged(object sender, EventArgs e)
        {
            if (TxtCedula.Text.Length.Equals(10))
            {
                string buscar_ced = TxtCedula.Text;
                controlador = new Controlador();
                bool aux = controlador.Comprobar_cedula_votante(buscar_ced);//aqui debe ser comparar ese es el fallo
                if (aux)
                {
                    //poner que se llene en caso de que si existan y que el boton sea visible o no
                    List<object> datos = new List<object>();
                    datos = controlador.Llenar_campos(buscar_ced,1);
                    TxtNombre.Text = datos[0].ToString();
                    TxtApellidos.Text = datos[1].ToString();
                    if(TxtNombre.Text!="Master" && TxtApellidos.Text != "Root")
                    {
                        button2.Enabled = true;
                        button3.Enabled = true;
                        Btn_Guardar.Enabled = false;
                    }
                    else
                    {
                        button2.Enabled = false;
                        button3.Enabled = false;
                        Btn_Guardar.Enabled = false;
                    }
                    
                }
                else
                {
                    Btn_Guardar.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    

                }
            }
            else
            {
                Btn_Guardar.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                TxtNombre.Text = "";
                TxtApellidos.Text = "";
            }
        }
    }
}
