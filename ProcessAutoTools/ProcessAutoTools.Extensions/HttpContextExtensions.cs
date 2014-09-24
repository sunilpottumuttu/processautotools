using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProcessAutoTools.Extensions
{
    public static class HttpContextExtensions
    {
        public static T GetValue<T>(this HttpContext context,string name)
        {
            object parsedValue = default(T);
            try
            {
                var value = context.Request.Form[name].ToString();
                parsedValue = Convert.ChangeType(value, typeof(T));
            }
            catch (InvalidCastException)
            {
                parsedValue = null;
            }
            catch (ArgumentException)
            {
                parsedValue = null;
            }
            return (T)parsedValue;
        }
    }
}
