using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime.Services
{
    public class DataTypeService
    {
        public static bool IsInt (object value)
        {
            return value is int;
        }
    }
}
