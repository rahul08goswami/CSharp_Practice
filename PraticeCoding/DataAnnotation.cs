using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeCoding
{
    internal class DataAnnotation
    {
        public void callAnnotation()
        {
            Customer customer = new Customer();
            customer.Name = "Testt";
            customer.Address = "Kolkata";
            var Result = new List<ValidationResult>();
            var context = new ValidationContext(customer);
            var isValid = Validator.TryValidateObject(customer,context,Result,true);
            Console.WriteLine("Is valid: " + isValid);
            foreach (var validationResult in Result)
            {
                Console.WriteLine(validationResult.ErrorMessage);
            }
        }
    }
}
