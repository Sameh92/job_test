using System;
using System.Collections.Generic;
using System.Text;

namespace Question4
{
    class Alexa
    {
        public string GreetingMessage = "hello, i am Alexa";
        public string OwnerName;
        public string Talk()
        {
            return this.GreetingMessage.Replace("{OwnerName}", this.OwnerName);
        }
        public void Configure(Action<Alexa> action)
        {
            action.Invoke(this);
        }
    }
}
