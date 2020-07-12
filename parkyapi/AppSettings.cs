using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parkyapi
{
    public class AppSettings
    {
        // Any key use user must be greater than 16 chars in length or you will get an argument out of range exception
        public string Secret { get; set; }
    }
}
