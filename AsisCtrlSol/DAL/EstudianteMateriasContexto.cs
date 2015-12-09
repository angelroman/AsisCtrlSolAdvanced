using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AsisCtrlSol.Models;

namespace AsisCtrlSol.DAL
{
    public class EstudianteMateriasContexto : DbContext
    {
        public EstudianteMateriasContexto():base("EstudianteMateriasContexto")
        {

        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Enlistamiento> Enlistamientos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) { modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); }

    }
}