using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Messenger
{
    class UncleMajorMessenger:IMessenger
    {
        private IMessenger generalMessenger;
        private static string[] stopKeywords;
        public UncleMajorMessenger(IMessenger m)
        {
            if(generalMessenger == null)
            {
                generalMessenger = m;
            }

            stopKeywords = new[] {"fuck", "basters" };
        }
        
        public string Name {
            get { return generalMessenger.Name; }
            set { generalMessenger.Name = value; }
        }
        public void Connect(IMessenger to)
        {
            generalMessenger.Connect(to);
            //throw new System.NotImplementedException();
        }

        public void Send(string message)
        {
            generalMessenger.Send(message);
            //throw new System.NotImplementedException();
        }

        public void OnMessage(IMessenger sender, string message)
        {
            if(IsValidMessage(message)) { 
                Console.WriteLine("За вами уже выехали");
            }
            else
            {
                generalMessenger.OnMessage(sender, message);
            }
            //throw new System.NotImplementedException();
        }

        public static bool IsValidMessage(string input)
        {
            return (stopKeywords.Any(input.ToLowerInvariant().Contains));
            // stopKeywords.Any(s=>input.Contains(s));
        }
    }
}