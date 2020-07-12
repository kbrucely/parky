using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyWeb
{
    public class SD
    {
        public static string APIBaseUrl = "https://localhost:44396/";
        public static string NationalParkApiPath = APIBaseUrl+"api/v1/nationalparks/";
        public static string TrailApiPath = APIBaseUrl+"api/v1/trails/";
        public static string AccountAPIPath = APIBaseUrl + "api/v1/Users/";
    }
}
