using Code_First.Models;
using Microsoft.Extensions.Hosting;
using System.Drawing.Text;
using System.Net;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Text;

public static class RestApiHelpers
{
    private static readonly string baseurl = "https://localhost:7270/api/Administrator";

    public static async Task<IList<Administrators>> GetALL()
    {
        
        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage res = await client.GetAsync(baseurl))
            {
                using (HttpContent content = res.Content)
                {
                    var data = await content.ReadAsAsync<IList<Administrators>>();
                    if (data != null)
                    {
                        return data;
                    }
                }
            }
        }
        return new List<Administrators>();
    }

    public static async Task<string> Post<T>(T data, string url) where T : class

    {
        
        var baseAddress = new Uri($"https://localhost:7270/api/{url}");

        using (var httpClient = new HttpClient { })
        {
            

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var jsonContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await httpClient.PostAsync(baseAddress, jsonContent);

                // Ensure we get a successful response.
                response.EnsureSuccessStatusCode();

                // Read the response as a string.
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        return string.Empty;
    }
    
}