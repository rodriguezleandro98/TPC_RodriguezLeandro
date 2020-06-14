using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tipousuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Tipousuario() { }
        public Tipousuario(int ID, string Nombre)
        {
            this.ID = ID;
            this.Nombre = Nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }

}
