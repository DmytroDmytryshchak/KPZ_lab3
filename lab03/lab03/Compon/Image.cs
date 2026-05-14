using lab03.Strategy;
using System.IO;

namespace lab03.Compon
{
    public class Image : HtmlElement
    {
        private string _href;
        private IImageLoadingStrategy _strategy;

        public Image(string href)
        {
            _href = href;
            _strategy = SelectStrategy(href);
        }

        private IImageLoadingStrategy SelectStrategy(string href)
        {
            if (href.StartsWith("http"))
                return new NetworkImageStrategy();

            return new FileImageStrategy();
        }

        public string Load()
        {
            return _strategy.Load(_href);
        }
    }
}