

using System.ComponentModel.DataAnnotations;

namespace RealStateApplication.Models.ViewModels.Auth
{
    public class LoginViewModel
    {
        [Display(Name = "Correo Electronico *")]
        [Required(ErrorMessage = "El correo electronico es requerido")]
        [EmailAddress(ErrorMessage = "Correo electronico invalido")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Contraseña *")]
        [Required(ErrorMessage = "La contraseña es requerida")]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "La contraseña debe ser de 8 hasta 12 caracteres")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}