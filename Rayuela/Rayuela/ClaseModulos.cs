using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
     
    class ClaseModulos
    {
        private String idModulo;
        private int curso;
        private String ciclo;
        private String nombreCompleto;

        public ClaseModulos()
        {
        }

        public ClaseModulos(string idModulo, int curso, string ciclo, string nombreCompleto)
        {
            this.IdModulo = idModulo;
            this.Curso = curso;
            this.Ciclo = ciclo;
            this.NombreCompleto = nombreCompleto;
        }

        public string IdModulo { get => idModulo; set => idModulo = value; }
        public int Curso { get => curso; set => curso = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
    }
}
