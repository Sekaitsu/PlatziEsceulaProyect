using System;
using PlatziEscuelaProyect2.App.Entidades;
using PlatziEscuelaProyect2.Util;
using PlatziEscuelaProyect2.Entidades;
using static System.Console;

namespace PlatziEscuelaProyect2
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine(); //() significa que no recibe parametros
            engine.Inicializar(); //se inicializa
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            //Printer.Beep(10000, cantidad: 10);
            ImprimirCursosEscuela(engine.Escuela); //Imprime
            var listadeObjetos = engine.GetObjetosEscuela();

            //var obj = new ObjetoEscuelaBase;
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.WriteTitle("Pruebas de Poliformismo");

            var alumnoTest = new Alumno { Name = "Claire Underwood" };

            Printer.WriteTitle("Alumno Con la variable alumnoTest");
            WriteLine($"Alumno:         {alumnoTest.Name}");
            WriteLine($"AlumnoId:       {alumnoTest.UniqueId}");
            WriteLine($"Alumno GetType: {alumnoTest.GetType()}");

            ObjetoEscuelaBase obj = alumnoTest;

            Printer.WriteTitle("Alumno con ObjetoEscuela con obj");
            WriteLine($"Alumno:         {obj.Name}");
            WriteLine($"AlumnoId:       {obj.UniqueId}");
            WriteLine($"Alumno GetType: {obj.GetType()}");

            var objDummy = new ObjetoEscuelaBase() { Name = " Frank Underwood" };

            Printer.WriteTitle("Alumno con objDummy");
            WriteLine($"Alumno:         {objDummy.Name}");
            WriteLine($"AlumnoId:       {objDummy.UniqueId}");
            WriteLine($"Alumno GetType: {objDummy.GetType()}");

            var evaluacion = new Evaluacion() { Name = "Evaluacion de mate", Nota = 4.5f };
            Printer.WriteTitle("Alumno con evaluación");
            WriteLine($"Alumno:         {evaluacion.Name}");
            WriteLine($"AlumnoNota:     {evaluacion.Nota}");
            WriteLine($"AlumnoId:       {evaluacion.UniqueId}");
            WriteLine($"Alumno GetType: {evaluacion.GetType()}");

            obj = evaluacion;
            Printer.WriteTitle("ObjetoEscuela");
            WriteLine($"Alumno:         {obj.Name}");
            WriteLine($"AlumnoId:       {obj.UniqueId}");
            WriteLine($"Alumno GetType: {obj.GetType()}");
            
            //obj = evaluacion;
            if( obj is Alumno )
            {
                Alumno alumnoRecuperado = (Alumno)obj;
            }
            obj = evaluacion;
            Alumno? alumnoRecuperado2 = obj as Alumno;
        }
        private static void ImprimirCursosEscuela(Escuela escuela) //FUNCIONA POR QUE  USA escuela.Cursos
        {
            Printer.WriteTitle("Cursos Escuela Platzi");
            if (escuela?.Cursos != null)
            {
                foreach (var Curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {Curso.Name}, Id {Curso.UniqueId}");
                }
            }
        }
    }
}