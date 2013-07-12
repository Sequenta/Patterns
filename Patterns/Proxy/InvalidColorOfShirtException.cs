using System;

namespace Proxy
{
    public class InvalidColorOfShirtException : Exception
    {
        public override string Message
        {
            get { return "Sorry, but we don't sell t-shirts of this color"; }
        }
    }
}