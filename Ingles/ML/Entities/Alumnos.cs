using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Entities
{
    public class Alumnos
    {
        public int Id_Alumnos { get; set; }
        [Required (ErrorMessage ="Este campo es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string APaterno { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string AMaterno { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Curp { get; set; }
        public string RFC { get; set; }
        public string Genero { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Carrera { get; set; }
        public string Grupo { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Tel_Casa { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Tel_Celular { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Correo { get; set; }
        public string Fecha_Nacimiento { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Id_Tipo_Alumno { get; set; }

    }
}
