using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads
{
    internal class WelcomeMessage
    {
        public string Hey;

        public WelcomeMessage(string hey)
        {
            Hey = hey;
        }

        public string Compliment;
        public WelcomeMessage(string hey, string compliment)
        {
            Hey = hey;
            Compliment = compliment;
        }
    }
}
