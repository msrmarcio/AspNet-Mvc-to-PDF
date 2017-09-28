using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC.PDF.WEB.Options
{
    class OptionFlag : Attribute
    {
        public string Name { get; private set; }

        public OptionFlag(string name)
        {
            Name = name;
        }
    }
}