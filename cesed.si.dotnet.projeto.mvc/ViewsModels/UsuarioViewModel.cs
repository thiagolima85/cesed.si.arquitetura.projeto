using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace cesed.si.dotnet.projeto.mvc.ViewsModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [DisplayName("Usuário")]
        public string UsuarioNome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public IEnumerable<AtividadeViewModel> Atividades { get; set; }
    }
}