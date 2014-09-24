using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessAutoTools.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsValid(this object o,out List<ValidationResult> results)
        {
            //var u = new POCOS.User();
            var c = new ValidationContext(o, serviceProvider: null, items: null);
            //var results = new List<ValidationResult>();
            results = null;
            var isValid = Validator.TryValidateObject(o, c, results);
            
            return isValid;

        }
    }
}
