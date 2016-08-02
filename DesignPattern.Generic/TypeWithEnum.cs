using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Generic
{
    public class TypeWithEnum
    {
        public TypeWithEnum()
        {
            var input = "Step1";
            Steps s = input.ParseEnum<Steps>(); //
            Console.WriteLine(s.ToString());
        }

        
    }
    public enum Steps
    {
        Step1,
        Step2,
        Step3
    }
}
