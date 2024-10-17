using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayuela
{
    public partial class FormRayuela : Form
    {   
        List<ClaseAlumno> listaAlumnos;
        List<ClaseCursos> listaCursos;
       
        public FormRayuela()
        {
            InitializeComponent();
        }

        private void FormRayuela_Load(object sender, EventArgs e)
        {
            ClaseConectar cnx = new ClaseConectar();
            listaCursos=cnx.listarCursos();
            listaAlumnos=cnx.listarAlumnos();
            cargarAulas(listaCursos, listaAlumnos);
        }

        private void cargarAulas(List<ClaseCursos> listaCurso, List<ClaseAlumno> listaAlumno)
        {
            foreach (ClaseCursos curso in listaCurso)
            {
                TabPage tabP = new TabPage();
                tabP.Text = curso.IdCurso;
                tabCursos.Controls.Add(tabP);
                tabP.Click += TabP_Click;
                TableLayoutPanel tlp=new TableLayoutPanel();
                tlp.ColumnCount = 5;
                tlp.AutoScroll = true;
                tlp.AutoSize = true;
                tlp.BackColor = Color.Aquamarine;
                tabP.Controls.Add(tlp);
                //lo carga aqui los alumnos de todos los cursos
                foreach(ClaseAlumno clase in listaAlumno)
                {
                    if (clase.Ciclo == curso.Ciclo)
                    {
                        FlowLayoutPanel flp= new FlowLayoutPanel();
                        flp.BackColor = Color.Khaki;
                        flp.AutoSize = true;
                        flp.FlowDirection = FlowDirection.TopDown;
                        tlp.Controls.Add(flp);
                        Button btn= new Button();
                        btn.AutoSize = true;
                        btn.Image = Image.FromFile(clase.Imagen);
                        btn.Tag = clase;
                        btn.Click += Btn_Click;
                        Label lbl=new Label();
                        lbl.AutoSize = true;
                        lbl.Text = clase.Nombre;
                        flp.Controls.Add(btn);
                        flp.Controls.Add(lbl);
                    }
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Ficha ficha = new Ficha();
            Button btn=(Button)sender;
            ficha.Alumno = (ClaseAlumno)btn.Tag;
            ficha.ShowDialog();
        }

        private void TabP_Click(object sender, EventArgs e)
        {
            
        }

        private void BotonX_Click(object sender, EventArgs e)
        {
         
        }

        private void tabCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
