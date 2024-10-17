using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayuela
{
    public partial class Ficha : Form
    {
        ClaseAlumno alumno=new ClaseAlumno();
        List<ClaseModulos> listaModulos= new List<ClaseModulos>(); 
        public Ficha()
        {
            InitializeComponent();
        }

        internal ClaseAlumno Alumno { get => alumno; set => alumno = value; }

        private void Ficha_Load(object sender, EventArgs e)
        {
            ClaseConectar cnx=new ClaseConectar(); 
            this.Text = alumno.Nombre;
            lblId.Text=alumno.Identificador.ToString();
            lblNombre.Text=alumno.Nombre;
            lblNum.Text = alumno.Curso.ToString();
            lblCurso.Text = alumno.Ciclo;
            lblCorreo.Text = alumno.Mail.ToString();
            pctImagen.Image=Image.FromFile(alumno.Imagen);
            listaModulos = cnx.listarModulos(alumno.Ciclo,alumno.Curso);
            foreach(ClaseModulos cm in listaModulos)
            {
                cmbFaltas.Items.Add(cm.NombreCompleto.ToString());

            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInformar_Click(object sender, EventArgs e)
        {
            FormInformes form = new FormInformes();
            form.ShowDialog();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            if (cmbFaltas.Text.Length > 0)
            {
                ClaseConectar cnx = new ClaseConectar();
                cnx.insertarFalta(alumno.Identificador, cmbFaltas.Text);
            }
            else
            {
                MessageBox.Show("Debes seleccionar algún módulo");
            }
            
        }
    }
}
