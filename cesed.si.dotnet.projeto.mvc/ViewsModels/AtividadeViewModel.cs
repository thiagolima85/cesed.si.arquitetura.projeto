using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace cesed.si.dotnet.projeto.mvc.ViewsModels
{
    public class AtividadeViewModel
    {
        [Key]
        public int AtividadeId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Atividade")]
        [DisplayName("Atividade")]
        public string AtividadeNome { get; set; }

        public string Local { get; set; }

        [DisplayName("Data de Início")]
        public DateTime DataInicio { get; set; }

        [DisplayName("Tipo de Atividade")]
        public string TipoDeAtividade { get; set; }

        [DisplayName("Descrição da Atividade")]
        public string Descricao { get; set; }

        public int UsuarioId { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }
    }
}