using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPWeatherApp.Common
{
    class Common
    {
        public static string API_LINK = "https://api.openweathermap.org/data/2.5/weather";
        public static string API_KEY = "ba9245a132a4a5efccd3b446ca8df4b8";

        public static string APIRequest(string lat, string lon)
        {
            var strBuilder = new StringBuilder(API_LINK);
            strBuilder.AppendFormat("?lat={0}&lon={1}&units=metric&appid={2}", lat, lon, API_KEY);
            return strBuilder.ToString();
        }

        public static DateTime ConvertUnixTimeToDateTime(double unix)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(unix).ToLocalTime();
            return dt;
        }
    }
}
