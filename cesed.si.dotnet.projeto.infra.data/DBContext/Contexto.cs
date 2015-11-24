
using cesed.si.dotnet.projeto.dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace cesed.si.dotnet.projeto.infra.data.DBContext
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Atividade> Atividades { get; set; }

        public Contexto() : base("ProjetoArquitetura")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
