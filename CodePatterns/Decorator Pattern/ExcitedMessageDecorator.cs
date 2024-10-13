using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Decorator_Pattern
{
    // extend MessageDecorator 
    public class ExcitedMessageDecorator : MessageDecorator
    {
        public ExcitedMessageDecorator(IMessage message) : base(message) { }
        public override string GetMessage()
        {
            return message.GetMessage() + "!!!";
        }

    }
}
