using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatziEscuelaProyect2.Entidades
{
    //todos nuestrosobjetos hereden de objetoescuelabase
    public class ObjetoEscuelaBase
    {
        public string UniqueId  { get; private set; }
        public string Name      { get; set; }
        public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
        public override string ToString()
        {
            return $"{Name}, {UniqueId}";
        }
    }
}
