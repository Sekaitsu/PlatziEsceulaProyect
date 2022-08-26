using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziEscuelaProyect2.Entidades
{
    public class Evaluacion : ObjetoEscuelaBase
    {
        public Alumno Alumno            { get; set; }
        public Asignatura Asignatura    { get; set; }
        public float Nota               { get; set; } //float por que genera decimales

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Name}, {Asignatura.Name}";
        }
    }
}
