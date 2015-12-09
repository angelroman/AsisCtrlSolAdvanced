using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsisCtrlSol.Models
{
    public class Materia
    {
        public int ID { get; set; }
        public string Nombre_Materia { get; set; }
        public int Creditos_Materia { get; set; }

        public virtual ICollection<Enlistamiento> Enlistamientos { get; set; }
    }
}