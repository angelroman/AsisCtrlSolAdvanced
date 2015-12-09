using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AsisCtrlSol.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AsisCtrlSol.DAL
{
    public class EstudianteMateriasInicializador:System.Data.Entity.DropCreateDatabaseIfModelChanges<EstudianteMateriasContexto>
    {
        protected override void Seed(EstudianteMateriasContexto context)
        {
            var Estudiante = new List<Estudiante>
            {
                new Estudiante{ EstudianteID =10100282, Nombre="Luis",Apellido_Materno="Romero",Apellido_Paterno="Reyes",Fecha_Nacimiento="08/04/91"},
                new Estudiante { EstudianteID =10100283, Nombre="Angel",Apellido_Materno="Roman",Apellido_Paterno="Camacho",Fecha_Nacimiento="08/04/91"}
            };
            Estudiante.ForEach(u => context.Estudiantes.Add(u));
            context.SaveChanges();
            

            var Materia = new List<Materia>
            {
                new Materia{ Nombre_Materia = "Ingles", Creditos_Materia = 5, ID = 1 },
                new Materia{ Nombre_Materia = "Fisica", Creditos_Materia = 4, ID = 2 },
                new Materia{ Nombre_Materia = "Quimica", Creditos_Materia = 5, ID = 3 }
            };
            Materia.ForEach(m => context.Materias.Add(m));
            context.SaveChanges();

            var Enlistar = new List<Enlistamiento>
            {
                new Enlistamiento { EnlistamientoID = 08122015, EstudianteID = 10100282, MateriaID = 1 },
                new Enlistamiento { EnlistamientoID = 08122016, EstudianteID = 10100283, MateriaID = 1 },
            };

            var usuarios = new List<Usuario>
            {
                new Usuario { usuarioID = 1, username = "admin", password = "123" },
                new Usuario { usuarioID = 2, username = "invitado", password = "321" }
            };
            usuarios.ForEach(u => context.Usuarios.Add(u));

            context.SaveChanges();


        }
    }
}