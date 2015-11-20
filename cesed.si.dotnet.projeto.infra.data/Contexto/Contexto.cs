

using cesed.si.dotnet.projeto.dominio.Entidades;
using System.Data.Entity;

namespace cesed.si.dotnet.projeto.infra.data.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("ProjetoDotNet")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
