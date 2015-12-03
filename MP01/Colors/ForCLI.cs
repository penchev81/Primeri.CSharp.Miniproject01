﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
    public class ForCLI
    {
        public ForCLI()
        {
            
        }

        public void Default()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Command()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }

        public void Result ()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Promt ()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }

}
