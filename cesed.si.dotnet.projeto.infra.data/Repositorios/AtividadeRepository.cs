using System;
using System.Collections.Generic;
using cesed.si.dotnet.projeto.dominio.Entidades;
using cesed.si.dotnet.projeto.dominio.Interfaces;
using System.Linq;

namespace cesed.si.dotnet.projeto.infra.data.Repositorios
{
    public class AtividadeRepository : RepositoryBase<Atividade>, IAtividadeRepository
    {
        public IEnumerable<Atividade> BuscarPorNome(string nome)
        {
            return Db.Atividades.Where(p => p.Nome == nome);
        }
    }
}
