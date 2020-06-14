using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public bool Estado { get; set; }
        public Tipousuario Tipodeusuario { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}
