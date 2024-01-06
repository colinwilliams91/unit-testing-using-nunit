using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime.Services
{
    public class DataTypeService
    {
        public bool IsInt(object value)
        {
            return value is int;
        }

        public bool IsBoolean(object value)
        {
            return value is bool;
        }

        public bool IsString(object value)
        {
            return value is string;
        }

        public bool IsCharacter(object value)
        {
            return value is char;
        }

        public bool IsArray(object value)
        {
            return value.GetType() == typeof(Array);
        }

        public bool IsObj(object value)
        {
            return value is object;
        }

        public bool IsNaN(object value)
        {
            return value is double.NaN;
        }

        public bool IsNull(object value)
        {
            return value is null;
        }
    }
}
