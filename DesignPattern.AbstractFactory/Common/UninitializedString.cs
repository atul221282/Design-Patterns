using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Common
{
    internal class UninitializedString : INonEmptyStringState
    {
        public INonEmptyStringState Set(string value) => new NonEmptyString(value);

        public string Get()
        {
            throw new System.InvalidOperationException();
        }
    }
}
