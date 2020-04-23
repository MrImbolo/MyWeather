using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MyWeatherService.Utilities
{
    public class HttpClientWrapper
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<string> Request(HttpRequestMessage message, CancellationToken stoppingToken, ILogger logger)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.

            try
            {
                while(!stoppingToken.IsCancellationRequested)
                {
                    HttpResponseMessage response = await client.SendAsync(message);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    return responseBody;
                }
                logger.LogInformation("Request cancelled by user");
                return "{'status': { 'Name': 'Error', 'StatusCode': '499', 'Message': 'Cancelled by user' }}";
            }
            catch (HttpRequestException e)
            {
                logger.LogError(e, "Request error!");
                return string.Empty;
            }
        }
    }
}
