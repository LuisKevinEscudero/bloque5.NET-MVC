using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prueba.Models
{
    public class minTodayDateForMovie : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;
            if (movie.ReleaseDate == null)
                return new ValidationResult("Release Date is required.");
            if (movie.ReleaseDate < DateTime.Today)
                return new ValidationResult("Release Date must be today or later.");
            return ValidationResult.Success;
        }
    }
}