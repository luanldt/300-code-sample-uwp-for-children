using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UWPWeatherApp.Model;

namespace UWPWeatherApp.Helper
{
    public class Helper
    {
        public static async Task<OpenWeather> GetWeather(string lat, string lon)
        {
            using(var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(Common.Common.APIRequest(lat, lon));
                var resultText = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    try
                    {
                        var data = JsonConvert.DeserializeObject<OpenWeather>(resultText);
                        return data;
                    } catch (Exception e)
                    {
                        Debug.Fail(e.Message + resultText);
                        return null;
                    }
                }
                return null;
            }
        }
    }
}
