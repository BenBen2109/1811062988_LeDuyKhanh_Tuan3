using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace _1811062988_LeDuyKhanh_Tuan3.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isVaild = DateTime.TryParseExact(Convert.ToString(value),
            "dd/MM/yyyy",
            CultureInfo.CurrentCulture,
            DateTimeStyles.None,
            out dateTime);

            return (isVaild && dateTime > DateTime.Now);
        }

    }
}