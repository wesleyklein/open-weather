using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather.Application.DTOs
{

    public class ApiWeatherDataErrorResponse
    {
        public int Cod { get; set; }
        public string Message { get; set; }
        public List<string> Parameters { get; set; }
    }
}
