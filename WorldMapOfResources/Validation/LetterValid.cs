using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WorldMapOfResources
{
   public class LetterValid : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            try
            {
       
                Regex rx = new Regex("[a-zA-Z]");
                if (rx.IsMatch((string)value))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Molimo vas unesite samo kombinaciju slova.");
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
            }
        }
    }
}
