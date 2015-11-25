using cesed.si.dotnet.projeto.dominio.Entidades;
using cesed.si.dotnet.projeto.dominio.Interfaces;
using cesed.si.dotnet.projeto.dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesed.si.dotnet.projeto.dominio.Serviços
{
    public class AtividadeService : ServiceBase<Atividade>, IAtividadeService
    {
        private readonly IAtividadeRepository _atividadeRepository;

        public AtividadeService(IAtividadeRepository atividadeRepository)
            : base (atividadeRepository)
        {
            _atividadeRepository = atividadeRepository;
        }

        public IEnumerable<Atividade> BuscarPorNome(string nome)
        {
            return _atividadeRepository.BuscarPorNome(nome);
        }
    }
}
