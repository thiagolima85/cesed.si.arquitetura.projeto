using System.Collections.Generic;

namespace cesed.si.dotnet.projeto.dominio.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string UsuarioNome { get; set; }

        public string Email { get; set; }

        public IEnumerable<Atividade> Atividades { get; set; }

    }
}
