using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Video_Rental_App_Asp.net.MVC_Web_API.Models
{
    public class AgeValidationRequirement:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birth date is required");
            }
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer should be at least 18 years old");

        }
    }
}