using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8voA.Modelo
{
    public class BaseVotantes
    {
        public string bas_cedula_identidad;
        public string bas_nombres;
        public string bas__apellidos;

        public BaseVotantes()
        {
        }
       
        public BaseVotantes(string bas_cedula_identidad, string bas_nombres, string bas__apellidos)
        {
            this.bas_cedula_identidad = bas_cedula_identidad;
            this.bas_nombres = bas_nombres;
            this.bas__apellidos = bas__apellidos;
        }

        public string Get_bas_cedula_identidad()
        {
            return bas_cedula_identidad;
        }
        public void Set_bas_cedula_identidad(string bas_cedula_identidad)
        {
            this.bas_cedula_identidad = bas_cedula_identidad;
        }

        public string Get_bas_nombres()
        {
            return bas_nombres;
        }
        public void Set_bas_nombres(string bas_nombres)
        {
            this.bas_nombres = bas_nombres;
        } 
        
        public string Get_bas__apellidos()
        {
            return bas__apellidos;
        }
        public void Set_bas__apellidos(string bas__apellidos)
        {
            this.bas__apellidos = bas__apellidos;
        }
    }
}
