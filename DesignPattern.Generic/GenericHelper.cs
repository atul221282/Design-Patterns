using DesignPattern.Module.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Generic
{
    public static class GenericHelper
    {
        public static IEnumerable<TOutput> Map<TOutput, T>
            (this  IEnumerable<T> value, Converter<T, TOutput> converter)
        {
            return value.Select(x => converter(x));
        }
    }
}
