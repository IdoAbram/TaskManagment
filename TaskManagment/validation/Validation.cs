using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagment.validation
{
    internal class Validation
    {
        public Validation() { }
        public bool isNumber(string text)
        {
            foreach (char c in text)
            {
                if (c > '9' || c < '0')
                {
                    return false;
                }
            }
            return true;
        }
        public bool isletters(string text)
        {
            foreach (char c in text)
            {
                if (!((c <= 'z' && c >= 'a') || (c >= 'A' && c<= 'Z')))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isValidDate(string dateString) 
        {
            string dateFormat = "MM/dd/yyyy";

            // Try to parse the date using the specified format
            if (DateTime.TryParseExact(dateString, dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                // The date is valid
                return true;
            }

            // The date is not valid
            return false;
        }
    }
}
