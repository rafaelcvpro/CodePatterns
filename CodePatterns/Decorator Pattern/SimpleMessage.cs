using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Decorator_Pattern
{
    public class SimpleMessage : IMessage
    {
        private string message;

        public SimpleMessage(string message)
        {
            this.message = message;
        }

        public string GetMessage()
        {
            return message;
        }
    }
}
