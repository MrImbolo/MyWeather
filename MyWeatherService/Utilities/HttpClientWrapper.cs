﻿using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MyWeatherService.Utilities
{
    public class HttpClientWrapper
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<string> RequestString(HttpRequestMessage message, CancellationToken stoppingToken, ILogger logger)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.

            try
            {
                HttpResponseMessage response = await client.SendAsync(message, stoppingToken);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                logger.LogError(e, "Request error!");
                return string.Empty;
            }
        }
        public static async Task RequestStream(HttpRequestMessage message, CancellationToken stoppingToken, ILogger logger, Stream stream)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.

            try
            {
                HttpResponseMessage response = await client.SendAsync(message, stoppingToken);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStreamAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                await responseBody.CopyToAsync(stream);
            }
            catch (HttpRequestException e)
            {
                logger.LogError(e, "Request error!");
            }
        }
        public static async Task<byte[]> RequestByteArray(HttpRequestMessage message, CancellationToken stoppingToken, ILogger logger)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.

            try
            {
                HttpResponseMessage response = await client.SendAsync(message, stoppingToken);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsByteArrayAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                logger.LogError(e, "Request error!");
                return new byte[] { };
            }
        }
    }
}
