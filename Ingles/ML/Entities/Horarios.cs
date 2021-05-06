using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Entities
{
    public class Horarios
    {
        public int Id_Horarios { get; set; }
        public string Hora { get; set; }
        public string Nivel { get; set; }
        public string Grupo { get; set; }
        public ML.Entities.Alumnos Alumnos { get; set; }



    }
}
