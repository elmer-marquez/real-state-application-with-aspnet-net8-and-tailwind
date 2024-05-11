using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealStateApplication.Models.ViewModels.Auth
{
    public class RegisterViewModel
    {
        [Display(Name = "Nombre Completo *")]
        [Required(ErrorMessage = "El nombre completo es requerido")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Nombre completo debe estar entre 10 o 100 caracteres")]
        public string FullName { get; set; } = string.Empty;

        [Display(Name = "Correo Electronico *")]
        [Required(ErrorMessage = "El correo electronico es requerido")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Contraseña *")]
        [Required(ErrorMessage = "La contraseña es requerida")]
        [StringLength(12, MinimumLength = 8, ErrorMessage = "La contraseña debe ser de 8 hasta 12 caracteres")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Confirmar Contraseña *")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contraseñas son diferentes")]
        public string ConfirmPassword { get; set; } = string.Empty;
        
    }
}