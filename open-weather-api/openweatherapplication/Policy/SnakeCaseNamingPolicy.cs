using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenWeather.Application.Policy
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            var retorno = string.Concat(name.Split('_')
                    .Select(word => string.IsNullOrEmpty(word) ? "" : char.ToUpperInvariant(word[0]) + word.Substring(1)));

            return retorno;
        }
    }
}
