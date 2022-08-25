using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//using static PlatziEscuelaProyect2.Program;

namespace PlatziEscuelaProyect2.Util
{
    public static class Printer
    {
        public static void DrawLine( int tam = 10 )
        {
            WriteLine( "".PadLeft( tam, '=' ) );
        }
        public static void WriteTitle( string titulo )
        {
            var tamaño = titulo.Length + 4;
            DrawLine( tamaño );
            WriteLine( $"| { titulo } |" );
            DrawLine( tamaño );
        }
        public static void Beep( int hz = 2000, int tiempo = 500, int cantidad = 1 )
        {
            while ( cantidad-- > 0 )
            {
                System.Console.Beep( hz, tiempo );
            }
        }
    }
}