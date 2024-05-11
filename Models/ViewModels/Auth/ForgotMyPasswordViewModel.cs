using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealStateApplication.Models.ViewModels.Auth
{
    public class ForgotMyPasswordViewModel
    {
        [Display(Name = "Correo Electronico *")]
        [Required(ErrorMessage = "El correo electronico es requerido")]
        [EmailAddress(ErrorMessage = "Correo electronico invalido")]
        public string Email { get; set; } = string.Empty;
    }
}