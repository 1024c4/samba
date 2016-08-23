﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp
{
    // This implementation of the IOutput interface
    // is actually how we write to the Console. Technically
    // we could also implement IOutput to write to Debug
    // or Trace... or anywhere else.
    public class ConsoleReverseOutput : IOutput
    {
        public void Write(string content)
        {
            string s = new string(content.Reverse().ToArray());
            Console.WriteLine(s);
        }
    }
}
