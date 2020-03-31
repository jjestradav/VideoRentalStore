using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.UNKWOWN || customer.MembershipTypeId == MembershipType.PAY_AS_YOU_GO)            
                return ValidationResult.Success;

            if (!customer.Birthday.HasValue)
                return new ValidationResult("Birthdate is required");

            var today = DateTime.Now;
            int age = today.Year - customer.Birthday.GetValueOrDefault().Year;
            if (customer.Birthday.GetValueOrDefault() > today.AddYears(-age))
                age--;

            if (age < 18)
                return new ValidationResult("Custumer must be  at least 18 years old");

            return ValidationResult.Success;
            

        }
    }
}