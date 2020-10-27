using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibrary
{
    [System.AttributeUsage(System.AttributeTargets.Class|
        System.AttributeTargets.Struct,AllowMultiple =true)]
   public class AuthAttribute: Attribute
    {
        private string name;
        public double version;

        public AuthAttribute(string name)
        {
            this.name = name;
            version = 1.0;
        }

    }
}
