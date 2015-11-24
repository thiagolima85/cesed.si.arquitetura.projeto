using System;

namespace cesed.si.dotnet.projeto.dominio.Entidades
{
    public class Atividade
    {
        public int AtividadeId { get; set; }

        public string AtividadeNome { get; set; }
        
        public string Local { get; set; }

        public DateTime DataInicio { get; set; }

        public string TipoDeAtividade { get; set; }

        public string Descricao { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public Atividade()
        {

        }
    }
}
