using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Regexes
{
    public class MyRegexCommands
    {
        public static  Regex reg1 = new Regex(@"[!@#$%^&*(){}<>?:]");
        public static  Regex reg2 = new Regex("^\\w+@\\w+\\.\\w{2,5}");
    }
}
