using cesed.si.dotnet.projeto.dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesed.si.dotnet.projeto.aplicacao.Interfaces
{
    public interface IAtividadeAppService : IAppServiceBase<Atividade>
    {
        IEnumerable<Atividade> BuscarPorNome(string nome);
    }
}
