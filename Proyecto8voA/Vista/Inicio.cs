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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Btn_ACandidato_Click(object sender, EventArgs e)
        {
            Form1 anadir_candidato = new Form1();
            anadir_candidato.Visible = true;
        }

        private void Btn_AVotantes_Click(object sender, EventArgs e)
        {
            AnadirVotantes anadir_votantes = new AnadirVotantes();
            anadir_votantes.Visible = true;
        }

        private void Btn_APartidoPolitico_Click(object sender, EventArgs e)
        {
            AnadirPartidosPoliticos anadirPartidos = new AnadirPartidosPoliticos();
            anadirPartidos.Visible = true;
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login v_login = new Login();
            v_login.Visible = true;
        }
    }
}
