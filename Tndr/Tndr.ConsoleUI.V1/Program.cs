using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tndr.ConsoleUI.V1
{
    class Program
    {
		//readonly HttpClient httpClient = new HttpClient();

		const string TinderBaseUrl = "https://api.gotinder.com/";

        static void Main(string[] args)
        {
            Console.WriteLine("Tndr started");
			Run().Wait();
			Console.WriteLine("Tndr finished");
        }

		static string token = "";//"EAACEdEose0cBAGoCryrkdsm47USr0K6Sy8Mq1QZCZCzP4aD2dp3pcyabZASIVJZBHPEuVhHGK8LSf8jEbDL3ASaoZB4j4LZByfkeT3PCS1xc40QnSsGvm1o9RIeSkE2flh5NoWzD2fcW81ZCs9LXs1pBOWCxDn6qV8VOWWZCTSMhATuCVCrurDSduIXWp75g4pUZD";
		static string id = "1620307428190128";

		static async Task Run()
		{
			HttpClient httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Clear();
			httpClient.DefaultRequestHeaders.Add("User-Agent", "Tinder Android Version 4.5.5");
			httpClient.DefaultRequestHeaders.Add("os_version", "23");
			httpClient.DefaultRequestHeaders.Add("platform", "android");
			httpClient.DefaultRequestHeaders.Add("app-version", "854");
			httpClient.DefaultRequestHeaders.Add("Accept-Language", "en");

			string postData = $"{{facebook_token: '{token}', facebook_id: '{id}', locale: 'en'}}";

			var responseTask = httpClient.PostAsync(TinderBaseUrl + "auth", new StringContent(postData, Encoding.UTF8, "application/json"));
			var response = await responseTask;

			Console.WriteLine("abc");
		}
    }
}
