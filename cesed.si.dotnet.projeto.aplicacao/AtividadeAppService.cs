using cesed.si.dotnet.projeto.aplicacao.Interfaces;
using cesed.si.dotnet.projeto.dominio.Entidades;
using cesed.si.dotnet.projeto.dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesed.si.dotnet.projeto.aplicacao
{
    public class AtividadeAppService : AppServiceBase<Atividade>, IAtividadeAppService
    {
        private readonly IAtividadeService _atividadeService;
        
        public AtividadeAppService(IAtividadeService atividadeService)
            : base(atividadeService)
        {
            _atividadeService = atividadeService;
        }

        public IEnumerable<Atividade> BuscarPorNome(string nome)
        {
            return _atividadeService.BuscarPorNome(nome);
        }
    }
}
