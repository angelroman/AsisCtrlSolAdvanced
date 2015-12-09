using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsisCtrlSol.Models
{
    public class Enlistamiento
    {
        public int EnlistamientoID { get; set; }
        public int MateriaID { get; set; }
        public int EstudianteID { get; set; }

        public virtual Estudiante Estudiante { get; set; }
        public virtual Materia Materia { get; set; }
    }
}