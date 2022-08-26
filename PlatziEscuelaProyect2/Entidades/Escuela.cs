using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziEscuelaProyect2.Entidades
{
    public class Escuela : ObjetoEscuelaBase
    {
        //public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        ////propiedad muestra el nombre para identificar
        ////se crean las demas propiedades a usar esta es la manera CORRECTA y mas rapida 
        //// se hace un get donde se retona la variable, y se especifica que es una copia del nombre
        //string name;
        //public string Name
        //{
        //    get { return "Copia:" + name; }
        //    set { name = value.ToUpper(); }
        //}
       
        public int YearCreacion         { get; set; }
        public string Pais              { get; set; }
        public string Ciudad            { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        //se adiciona otra propiedad donde llama a la entidad Cursos[] la cual será usasa en el Program.cs
        // se cambia a lista 
        public List<Curso> Cursos        { get; set; }
        public Escuela( string name, int year ) => ( Name, YearCreacion ) = ( name, year );
        public Escuela( string name, int year,
                               TiposEscuela tipo,
                               string pais = "", string ciudad = "") : base()
        {
            ( Name, YearCreacion ) = ( name, year );
            Pais    = pais;
            Ciudad  = ciudad;
        }
        public override string ToString()
        {
            return $"Nombre: \"{ Name }\", Tipo: { TipoEscuela } { System.Environment.NewLine } Pais: { Pais }, Ciudad: { Ciudad }";
        }
    }
}
