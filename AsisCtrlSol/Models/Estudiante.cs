using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsisCtrlSol.Models
{
    public class Estudiante
    {
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Fecha_Nacimiento { get; set; }

        public virtual ICollection<Enlistamiento> Enlistamientos { get; set; }
        
        //comentario

    }
}
