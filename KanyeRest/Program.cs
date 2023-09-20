using KanyeRest;
using Newtonsoft.Json.Linq;

//var client = new HttpClient();

//var kanyeURL = "https://api.kanye.rest/";

//var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

//var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

//var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

//var ronResponse = client.GetStringAsync(ronURL).Result;

//var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

for (int i = 0; i < 5; i++)
{ 
Console.WriteLine($"Kanye says: \"{QuoteGenerator.GetYeQuote()}\"");

Console.WriteLine($"Ron says : {QuoteGenerator.GetRonQuote()}");
}