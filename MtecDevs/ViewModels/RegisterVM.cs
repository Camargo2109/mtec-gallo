using System.ComponentModel.DataAnnotations;
namespace MtecDevs.ViewModels;

public class RegisterVM
{
    [Display(Name = "Nome", Prompt = "Informe seu Nome")]
    [Required(ErrorMessage = "Por favor, informe seu nome")]
    public string Nome { get; set; }



    [Display(Name = "Email ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuário")]
    
    public string Email { get; set; }




    [Display(Name = "Data de Nascimento", Prompt = "Informe sua Data de Nascimento")]
    [Required(ErrorMessage = "Por favor, informe sua data de nascimento")]
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }


    
    [Display(Name = "Senha de Acesso", Prompt = "Informe sua Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }


    [Display(Name = "Tipo de Desenvolvedor")]
    [Required(ErrorMessage = "Por favor, informe o tipo de desenvolvedor")]
    public byte TipoDevId { get; set; }


    [Display(Name = "Foto")]
    public string Foto { get; set; }


    
    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; } = false;


    
    public string UrlRetorno { get; set; }
}
