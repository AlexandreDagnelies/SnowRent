using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Enums
{
    class StringValueAttribute : Attribute
    {

        public string StringValue { get; protected set; }
        public StringValueAttribute(string value)
        {
            this.StringValue = value;
        }
    }
}
