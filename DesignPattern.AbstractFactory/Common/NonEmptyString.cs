using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.Common
{
    public class NonEmptyString : INonEmptyStringState
    {
        private string Value { get; }

        public NonEmptyString(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException();
            this.Value = value;
        }

        public INonEmptyStringState Set(string value) => new NonEmptyString(value);

        public string Get() => this.Value;
    }
}
