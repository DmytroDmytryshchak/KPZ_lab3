using System;

namespace lab03.Observer
{
    public class ConsoleLogListener : IEventListener
    {
        private string _name;

        public ConsoleLogListener(string name)
        {
            _name = name;
        }

        public void Handle(HtmlEvent htmlEvent)
        {
            Console.WriteLine(
                $"{_name} → event '{htmlEvent.Type}' on {htmlEvent.Target.GetType().Name}"
            );
        }
    }
}