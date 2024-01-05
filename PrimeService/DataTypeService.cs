using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime.Services
{
    public class DataTypeService
    {
        public static bool IsInt (int value)
        {
            if (typeof value  != "number")
            {
                return false;
            }
            return true;
        }
    }
}
