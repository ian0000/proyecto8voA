using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8voA.Modelo
{
    class PartidoPolitico
    {
        public byte[] par_logo;
        public string par_nombre;

        public PartidoPolitico(byte[] par_logo, string par_nombre)
        {
            this.par_logo = par_logo;
            this.par_nombre = par_nombre;
        }

        public PartidoPolitico()
        {

        }

        public byte[] get_par_logo()
        {
            return par_logo;
        }
        public void set_par_logo(byte[] par_logo)
        {
            this.par_logo = par_logo;
        }

        public string get_par_nombre()
        {
            return par_nombre;
        }
        public void set_par_nombre(string par_nombre)
        {
            this.par_nombre = par_nombre;
        }
    }
}
