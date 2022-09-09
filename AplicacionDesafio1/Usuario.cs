using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionDesafio1
{
    internal class Usuario
    {
        private string nombre;
        private string password;
        private string preferencia;

        public Usuario(string nombre, string password, string preferencia)
        {
            this.nombre = nombre;
            this.password = password;
            this.preferencia = preferencia;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getPreferencia()
        {
            return this.preferencia;
        }
    }
}
