using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            RonVSKanyeAPI convo = new RonVSKanyeAPI();
            await convo.GetConvo();

            OpenWeatherMapAPI sa = new OpenWeatherMapAPI();
            await sa.GetWeatherSA();
        }
    }
}
