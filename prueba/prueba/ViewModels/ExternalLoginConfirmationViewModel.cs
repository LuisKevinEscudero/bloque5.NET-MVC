using System.ComponentModel.DataAnnotations;

namespace prueba.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; } 
    }
}
