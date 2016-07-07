using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowRentLibrary.Enums
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
