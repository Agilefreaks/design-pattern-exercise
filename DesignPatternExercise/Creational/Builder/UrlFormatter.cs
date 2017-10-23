using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternExercise.Creational.Builder
{
    public class UrlFormatter
    {
        public string Format(string baseUrl, Dictionary<string, string> query)
        {
            var queryString = FormatQueryString(query);

            return string.IsNullOrEmpty(queryString) ? baseUrl : $"{baseUrl}?{queryString}";
        }

        public string Format(string baseUrl, string hash)
        {
            return string.IsNullOrEmpty(hash) ? baseUrl : $"{baseUrl}#{hash}";
        }

        public string Format(string baseUrl, Dictionary<string, string> query, string hash)
        {
            var queryString = FormatQueryString(query);
            var result = baseUrl;

            if (!string.IsNullOrEmpty(queryString))
            {
                result = $"{result}?{queryString}";
            }
            if (!string.IsNullOrEmpty(hash))
            {
                result = $"{result}#{hash}";
            }

            return result;
        }

        private string FormatQueryString(Dictionary<string, string> query)
        {
            var queryValues = query.Select((item) => $"{item.Key}={Uri.EscapeUriString(item.Value)}");

            return string.Join("&", queryValues);
        }
    }
}
