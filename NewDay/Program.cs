using System;
using System.Collections.Generic;

namespace NewDay
{
    static class Program
    {
        static void Main(string[] args)
        {
            Diamond diamond = new Diamond();
            List<string> result = diamond.Print('D');

            foreach(var item in result)
            {
                Console.WriteLine(item);    
            }
            Console.Read();
        }
    }
}
