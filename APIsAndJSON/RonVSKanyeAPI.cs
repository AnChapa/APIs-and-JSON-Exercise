using Newtonsoft.Json.Linq;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public async Task GetConvo()
        {
          using (var client = new HttpClient())
          {
              var kanyeURL = "https://api.kanye.rest";
              var ronURL = " https://ron-swanson-quotes.herokuapp.com/v2/quotes";
              for (int i = 0; i < 5; i++)
              {
                  var kanyeResponse = await client.GetStringAsync(kanyeURL);
                  var ronResponse = await client.GetStringAsync(ronURL);

                  var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
                  var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

                  Console.WriteLine($"Kanye : \"{kanyeQuote}\"");
                  Console.WriteLine($"Ron : {ronQuote}");
                  Console.WriteLine("-----------------------------------");
              }
          }
        }
    }
}
