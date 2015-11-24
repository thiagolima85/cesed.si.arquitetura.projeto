

using cesed.si.dotnet.projeto.dominio.Entidades;
using System.Collections.Generic;

namespace cesed.si.dotnet.projeto.dominio.Interfaces
{
    public interface IAtividadeRepository : IRepositoryBase<Atividade>
    {
        IEnumerable<Atividade> BuscarPorNome(string nome);
    }
}
