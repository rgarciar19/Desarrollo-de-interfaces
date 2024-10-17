using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Rayuela
{
    class ClaseConectar
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader datos;
        List<ClaseAlumno> listaAlumno = new List<ClaseAlumno>();
        List<ClaseCursos> listaCurso = new List<ClaseCursos>();
        List<ClaseModulos> listaModulos = new List<ClaseModulos>();
        List<ClaseCalificaciones> listaClasificaciones = new List<ClaseCalificaciones>();
        List<ClaseFaltas> listaFaltas = new List<ClaseFaltas>();
        public ClaseConectar()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=di.cvccx1va9pol.us-east-1.rds.amazonaws.com;Database=dam2025;Uid=admin;pwd=Pilukina_2024;old guids=true";


        }
        public List<ClaseCursos> listarCursos()
        {
            conexion.Open();

            String cadena = "select * from cursos";
            comando=new MySqlCommand(cadena,conexion);
            datos=comando.ExecuteReader();
            while (datos.Read())
            {
                ClaseCursos curso = new ClaseCursos();
                curso.IdCurso = (string)datos["idCurso"];
                curso.NombreCompleto = (string)datos["NombreCompleto"];
                curso.Curso = (int)datos["Curso"];
                curso.Ciclo = (string)datos["Ciclo"];
                listaCurso.Add(curso);
            }

            conexion.Close();
            return listaCurso;
        }

        public List<ClaseAlumno> listarAlumnos()
        {
            conexion.Open();

            String cadena = "select * from alumnos where activo=1";
            comando = new MySqlCommand(cadena, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                ClaseAlumno clase=new ClaseAlumno();
                clase.Identificador = (string)datos["identificador"];
                clase.Nombre = (string)datos["Nombre"];
                clase.Curso = (int)datos["Curso"];
                clase.Ciclo = (string)datos["Ciclo"];
                clase.Imagen = (string)datos["Foto"];
                clase.Mail = (string)datos["Mail"];
               
                listaAlumno.Add(clase);
            }

            conexion.Close();
            return listaAlumno;
        }

        internal List<ClaseModulos> listarModulos(String ciclo,int curso)
        {
            conexion.Open();

            String cadena = "select * from modulos where ciclo=?c and curso=?u";
            comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("?c", ciclo);
            comando.Parameters.AddWithValue("?u", curso);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                ClaseModulos modulos = new ClaseModulos();
                modulos.IdModulo = (string)datos["idModulo"];
                modulos.Ciclo = (string)datos["ciclo"];
                modulos.Curso = (int)datos["curso"];
                modulos.NombreCompleto = (string)datos["NombreCompleto"];

                listaModulos.Add(modulos);
            }

            conexion.Close();
            return listaModulos;
        }

        internal int insertarFalta(string idAlumno, string idModulo)
        {
            int cod = 0;
            conexion.Open();

            DateTime fechaActual=DateTime.Now;
            String cadena = "insert into faltasasistencia values(null,?id,?f,?m)";
            comando = new MySqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("?id", idAlumno);
            comando.Parameters.AddWithValue("?f", fechaActual);
            comando.Parameters.AddWithValue("?m", idModulo);
            cod=comando.ExecuteNonQuery();

            conexion.Close();
            return cod;
        }
    }
}
