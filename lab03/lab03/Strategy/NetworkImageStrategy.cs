using System;
using System.Net.Http;

namespace lab03.Strategy
{
    public class NetworkImageStrategy : IImageLoadingStrategy
    {
        public string Load(string href)
        {
            try
            {
                using var client = new HttpClient();
                var data = client.GetByteArrayAsync(href).Result;

                return $"Loaded NETWORK image: {href}, bytes: {data.Length}";
            }
            catch (Exception ex)
            {
                return $"NETWORK ERROR: {ex.Message}";
            }
        }
    }
}