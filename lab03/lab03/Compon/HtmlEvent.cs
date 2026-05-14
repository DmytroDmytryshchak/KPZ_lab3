using System;
using System.Collections.Generic;
using lab03.Observer;

namespace lab03.Compon
{
    public class HtmlElement
    {
        public string TagName { get; set; }

        private List<HtmlElement> _children = new List<HtmlElement>();

        // OBSERVER PART 
        private Dictionary<string, List<IEventListener>> _listeners
            = new Dictionary<string, List<IEventListener>>();

        public HtmlElement()
        {
            TagName = "div";
        }

        public HtmlElement(string tagName)
        {
            TagName = tagName;
        }

        
        public void AddChild(HtmlElement element)
        {
            _children.Add(element);
        }

        // OBSERVER METHODS 

        public void AddEventListener(string eventType, IEventListener listener)
        {
            if (!_listeners.ContainsKey(eventType))
            {
                _listeners[eventType] = new List<IEventListener>();
            }

            _listeners[eventType].Add(listener);
        }

        public void DispatchEvent(string eventType)
        {
            if (!_listeners.ContainsKey(eventType))
                return;

            var htmlEvent = new HtmlEvent(eventType, this);

            foreach (var listener in _listeners[eventType])
            {
                listener.Handle(htmlEvent);
            }

            
            foreach (var child in _children)
            {
                child.DispatchEvent(eventType);
            }
        }
    }
}