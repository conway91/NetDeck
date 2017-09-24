using System;
using System.Collections.Generic;
using System.Text;

namespace NetDeck
{
    public class EmptyDeckException : Exception
    {
        public EmptyDeckException(string message) : base(message)
        {
        }
    }
}
