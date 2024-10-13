using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePatterns.Decorator_Pattern
{
    // abstract class implements the IMessage interface
    // and holds a reference to an IMessage object.
    public class MessageDecorator : IMessage
    {
        protected IMessage message;

        public MessageDecorator(IMessage message)
        {
            this.message = message;
        }

        public virtual string GetMessage()
        {
            return message.GetMessage();
        }
    }
}
