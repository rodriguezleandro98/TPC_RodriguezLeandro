using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Solicitud
    {
        public int ID { get; set; }
        public Cliente Cliente { get; set; }
        public Operador Operador { get; set; }
        public Sintomas Sintoma { get; set; }
        public string Titulo { get; set; }
        public string Desc { get; set; }
        public string Coment { get; set; }
        public Estados Estado { get; set; }
        public string Solucion { get; set; }


    }
}
