﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    class ClaseCalificaciones
    {
        private int Indice;
        private String IdentificadorAlumno;
        private String Modulo;
        private int Curso;
        private String Ciclo;
        private int Puntos;

        public ClaseCalificaciones()
        {
        }

        public ClaseCalificaciones(int indice, string identificadorAlumno, string modulo, int curso, string ciclo, int puntos)
        {
            Indice1 = indice;
            IdentificadorAlumno1 = identificadorAlumno;
            Modulo1 = modulo;
            Curso1 = curso;
            Ciclo1 = ciclo;
            Puntos1 = puntos;
        }

        public int Indice1 { get => Indice; set => Indice = value; }
        public string IdentificadorAlumno1 { get => IdentificadorAlumno; set => IdentificadorAlumno = value; }
        public string Modulo1 { get => Modulo; set => Modulo = value; }
        public int Curso1 { get => Curso; set => Curso = value; }
        public string Ciclo1 { get => Ciclo; set => Ciclo = value; }
        public int Puntos1 { get => Puntos; set => Puntos = value; }
    }
}
