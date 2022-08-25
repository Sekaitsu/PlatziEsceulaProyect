using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziEscuelaProyect2.Entidades
{
    public class Alumno : ObjetoEscuelaBase //al poner : se pone el nombre de la clase la cual quiero heredar
    {
        //se agrega una lista de evaluaciones para que cada alumno sea portador de su lista de evaluaciones
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
    }
}
