using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Supervisor
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public bool Estado { get; set; }
        public Tipousuario Tipodeusuario { get; set; }
    }
}
