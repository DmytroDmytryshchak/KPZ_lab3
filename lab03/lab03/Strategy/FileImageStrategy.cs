using System;
using System.IO;

namespace lab03.Strategy
{
    public class FileImageStrategy : IImageLoadingStrategy
    {
        public string Load(string href)
        {
            string path = Path.Combine("Images", href);

            if (!File.Exists(path))
                return $"FILE NOT FOUND: {path}";

            byte[] data = File.ReadAllBytes(path);

            return $"Loaded FILE image: {path}, bytes: {data.Length}";
        }
    }
}