using System.ComponentModel.DataAnnotations;

namespace MVCProject.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public long id { get; set; }

        [Required(ErrorMessage = "Preeencha o campo Login")]
        [Display(Name = "Login")]
        public string login { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Preencha o campo Senha")]
        [Display(Name = "Senha")]
        public string senha { get; set; }

    }
}