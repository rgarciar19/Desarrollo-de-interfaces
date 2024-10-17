using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    class ClaseAlumno
    {
        private String identificador;
        private String nombre;
        private String mail;
        private String ciclo;
        private int curso;
        private String imagen;

        public ClaseAlumno()
        {
        }

        public ClaseAlumno(string identificador, string nombre, string mail, string ciclo, int curso, string imagen)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.mail = mail;
            this.ciclo = ciclo;
            this.curso = curso;
            this.imagen = imagen;
        }

        public string Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }
        public int Curso { get => curso; set => curso = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }   
}
