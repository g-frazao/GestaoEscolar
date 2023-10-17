using GestaoEscolar.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoEscolar.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions<IESContext> options) : base(options) 
        {

        }

        public DbSet<Departamento> Departamentos { get; set; }
        
        public DbSet<Instituicao> Instituicao { get; set;}
    }
}
