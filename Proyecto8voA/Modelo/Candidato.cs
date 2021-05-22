using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8voA.Modelo
{
    class Candidato : BaseVotantes
    {
        public string can_rol;
        public byte[] can_foto;
        public Candidato()
        {

        }

        public Candidato(string can_rol, byte[] can_foto, string bas_cedula_identidad, string bas_nombres, string bas__apellidos)
        {
            this.can_rol = can_rol;
            this.can_foto = can_foto;
            this.bas_cedula_identidad = bas_cedula_identidad;
            this.bas_nombres = bas_nombres;
            this.bas__apellidos = bas__apellidos;
        }

        public string get_can_rol()
        {
            return can_rol;
        }
        public void set_can_rol(string can_rol)
        {
            this.can_rol = can_rol;
        }
        public byte[] get_can_foto()
        {
            return can_foto;
        }
        public void set_can_foto(byte[] can_foto)
        {
            this.can_foto = can_foto;
        }
    }
}
