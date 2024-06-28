using Code_First.Models;
using System.Drawing.Text;
using System.Net;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Security.Policy;
using System.Net.Http.Headers;
using System;
using Microsoft.AspNetCore.Mvc;

public static class RestApiHelpers
{

    public static async Task<IList<T>> GetALL<T>(T b, string url) where T : class
    {
        var baseurl = new Uri($"https://localhost:7270/api/{url}");

        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage res = await client.GetAsync(baseurl))
            {
                using (HttpContent content = res.Content)
                {
                    var data = await content.ReadAsAsync<IList<T>>();
                    if (data != null)
                    {
                        return data;
                    }
                }
            }
        }
        return new List<T>();
    }

    public static async Task<IList<T>> GetByName<T>(T b, string url, string name) where T : class
    {
        var baseurl = new Uri($"https://localhost:7270/api/{url}/Name?name={name}");

        using (HttpClient client = new HttpClient())
        {
            using (HttpResponseMessage res = await client.GetAsync(baseurl))
            {
                using (HttpContent content = res.Content)
                {
                    var jsondata = await content.ReadAsStringAsync();

                    IList<T> records = JsonConvert.DeserializeObject<IList<T>>(jsondata);

                    if (records != null)
                    {
                        return (IList<T>)records;
                    }
                }
            }
        }
        return new List<T>();
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
                Console.WriteLine(response);

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

    public static async Task<string> Update<T>(T data, string url, int id) where T : class
    {
        var baseAddress = new Uri($"https://localhost:7270/api/{url}?Id={id}");

        using (var httpClient = new HttpClient { })
        {

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var jsonContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

                var result = await httpClient.PutAsync(baseAddress, jsonContent);
                result.EnsureSuccessStatusCode();
                string response = await result.Content.ReadAsStringAsync();

                result.EnsureSuccessStatusCode();
                Console.WriteLine(response);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        return string.Empty;
    }

    public static async Task<string> Delete<T>(T d, string url, int Id) where T : class
    {
        var baseAddress = new Uri($"https://localhost:7270/api/{url}?Id={Id}");

        using (var httpClient = new HttpClient { })
        {
            try 
            { 
                var result = await httpClient.DeleteAsync(baseAddress);
                result.EnsureSuccessStatusCode();
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