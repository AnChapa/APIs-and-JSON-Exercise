using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            RonVSKanyeAPI convo = new RonVSKanyeAPI();
            await convo.GetConvo();
        }
    }
}
