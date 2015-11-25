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
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
            : base (usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
