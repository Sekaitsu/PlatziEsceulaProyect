using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatziEscuelaProyect2.Entidades;

namespace PlatziEscuelaProyect2.App.Entidades
{
    public sealed class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {

        }
        //se crea un metodo donde se va a inicializar el listado del curso
        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar, ciudad: "Bogotá", pais: "Colombia");
            CargarCursos        ();
            CargarAsignaturas   ();
            CargarEvaluaciones  ();
        }
        private void CargarEvaluaciones()
        {
            //se recorren curso, asignaturas y alumnos
            var lista = new List<Evaluacion>();
            foreach (var curso in Escuela.Curso)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        //se hace un bucle donde a cada alumno se le crean 5 evaluaciones
                        for (int i = 0; i < 5; i++)
                        {
                            var eva = new Evaluacion
                            {
                                Asignatura = asignatura,
                                Name = $"{asignatura.Name} Ev#( i + 1 )",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(eva); //Add es adicionar y se hace al alumno
                        }
                    }
                }
            }
        }
        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Curso)
            {
                //se puede adicionar cualquier tipo de asignaturas
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura { Name = "Matematicas"         },
                    new Asignatura { Name = "Educación Fisica"    },
                    new Asignatura { Name = "Castellano"          },
                    new Asignatura { Name = "Ciencias Naturales"  }
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }
        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 =      { "Alba", "Felipa", "Esubio", "Frayd", "Donald", "Alvaro", "Nicolás" };
            string[] nombre2 =      { "Freddy", "Anabel", "Rick", "Muerty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            string[] apellido1 =    { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            //lenguaje integrado de consultas Linq
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Name = $"{n1},{n2},{a1}" };
            return listaAlumnos.OrderBy((alum) => alum.UniqueId).Take(cantidad).ToList();
        }
        private void CargarCursos()
        {
            Escuela.Curso = new List<Curso>()
       {
           new Curso() {Name = "101", Jornada = TiposJornada.Mañana },
           new Curso() {Name = "201", Jornada = TiposJornada.Mañana },
           new Curso   {Name = "301", Jornada = TiposJornada.Tarde  },
           new Curso() {Name = "401", Jornada = TiposJornada.Tarde  },
           new Curso() {Name = "501", Jornada = TiposJornada.Noche  },
       };
            Random random = new Random();
            foreach (var curso in Escuela.Curso)
            {
                int cantRandom = random.Next(5, 25);
                curso.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
        }
    }

}
