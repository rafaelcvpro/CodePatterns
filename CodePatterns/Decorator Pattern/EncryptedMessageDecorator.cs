using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Decorator_Pattern
{
    public class EncryptedMessageDecorator : MessageDecorator
    {
        // extend MessageDecorator 
        public EncryptedMessageDecorator(IMessage message) : base(message) { }
        public override string GetMessage()
        {
            // Simple encryption by reversing the string
            char[] charArray = message.GetMessage().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
