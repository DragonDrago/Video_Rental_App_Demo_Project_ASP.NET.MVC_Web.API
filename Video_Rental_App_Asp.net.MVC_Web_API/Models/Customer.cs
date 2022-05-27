using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Video_Rental_App_Asp.net.MVC_Web_API.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="The lenght should be between 1 and 255 char")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Required (ErrorMessage ="Please enter membership type")]
        [Display(Name = "Membership Type")]
        public string MembershipType { get; set; }

        [Required(ErrorMessage ="Please enter date of birth !")]
        [Display(Name = "Date of Birth")]
        [AgeValidationRequirement]
        public DateTime? Birthdate { get; set; }
    }
}