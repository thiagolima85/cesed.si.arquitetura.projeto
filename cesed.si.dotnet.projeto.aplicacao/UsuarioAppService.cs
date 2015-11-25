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
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService)
            : base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

    }
}
