using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Domain.Models
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class CheckQuantityAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var cartItem = (CartItem)validationContext.ObjectInstance;

            if (cartItem.Product == null)
            {
                return new ValidationResult("Product must be loaded to validate quantity.");
            }

            if (cartItem.Quantity > cartItem.Product.Quantity)
            {
                return new ValidationResult($"Quantity cannot exceed the available quantity of {cartItem.Product.Quantity}.");
            }

            return ValidationResult.Success;
        }
    }
}
