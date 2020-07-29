using System;
using System.Collections.Generic;

namespace Builder
{
    class Computer
    {
        public Computer()
        {
            Result = new List<string>();
        }

        public List<string> Result { get; set; }

        public void PrintPcSpec()
        {
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
