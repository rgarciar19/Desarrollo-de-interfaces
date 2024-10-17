using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    class ClaseCursos
    {
         private String idCurso;
        private String nombreCompleto;
        private String ciclo;
        private int curso;

        public ClaseCursos()
        {

        }

        public ClaseCursos(string idCurso, string nombreCompleto, string ciclo, int curso)
        {
            this.idCurso = idCurso;
            this.nombreCompleto = nombreCompleto;
            this.ciclo = ciclo;
            this.curso = curso;
        }

        public string IdCurso { get => idCurso; set => idCurso = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }
        public int Curso { get => curso; set => curso = value; }
    }
}
