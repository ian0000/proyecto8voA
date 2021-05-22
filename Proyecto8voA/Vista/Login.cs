using Proyecto8voA.Controladores;
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
    public partial class Login : Form
    {
        Controlador controlador;
        public Login()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private string guardarnombre(string buscar_cedula)
        {
            List<object> datos = new List<object>();
            datos = controlador.Llenar_campos(buscar_cedula, 1);
            string nombre = datos[0].ToString();
            return nombre; 
        }

        private string guardarapellido(string buscar_cedula)
        {
            List<object> datos = new List<object>();
            datos = controlador.Llenar_campos(buscar_cedula, 1);
            string apellido = datos[1].ToString();
            return apellido;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string cedula=Txt_Cedula.Text;
            string nombre = guardarnombre(cedula);
            string apellido = guardarapellido(cedula);
            if ((nombre == "Master") && (apellido == "Root"))
            {
                Inicio v_inicio = new Inicio();
                v_inicio.Visible = true;
            }
            else
            {
                Votaciones v_votaciones = new Votaciones();
                v_votaciones.Txt_Cedula.Text = cedula;
                v_votaciones.Visible = true;
                
            }
            this.Visible=false;
        }

        private void Txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void Txt_Cedula_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Cedula.Text.Length.Equals(10))
            {
                controlador = new Controlador();
                string buscar_cedula = Txt_Cedula.Text;
                bool aux= controlador.Comprobar_cedula_votante(buscar_cedula);
                if (aux)
                {
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cedula no registrada");
                    button1.Enabled = false;
                }

            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
