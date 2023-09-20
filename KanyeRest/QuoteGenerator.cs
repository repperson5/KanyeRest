using System;
using Newtonsoft.Json.Linq;

namespace KanyeRest
{
	public class QuoteGenerator
	{
		public static string GetYeQuote()
		{
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            //Return and store JSON reponse from API
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            //use Newtonsoft.JSON to parse our JSON response
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }

        public static string GetRonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            //Call API and store response
            var ronResponse = client.GetStringAsync(ronURL).Result;

            //Parse JSON with Newtonsoft.JSON
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronQuote;

        }


    }
}

