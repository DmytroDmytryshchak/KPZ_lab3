namespace lab03.Observer
{
    public class HtmlEvent
    {
        public string Type { get; }
        public object Target { get; }

        public HtmlEvent(string type, object target)
        {
            Type = type;
            Target = target;
        }
    }
}