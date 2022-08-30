using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziEscuelaProyect2.Entidades
{
    public class Curso : ObjetoEscuelaBase //Curso hereda de ObjetoEscuelaBase
    {
        //<< Estas dos se van porque esto ya lo hace su padre que es ObjetoEscuelaBase
        //public string UniqueId              { get; private set; }
        ////<<cto es un constructor que permite construir un constructor :v
        ////<<guid es numero pero lo quiero converit en string 
        //public string Name                  { get; set; }
        //public Curso()
        //{
        //    UniqueId = Guid.NewGuid().ToString();
        //}
        public TiposJornada Jornada         { get; set; }
        //lista de asignaturas y alumnos
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos         { get; set; } 
        
    }
}
