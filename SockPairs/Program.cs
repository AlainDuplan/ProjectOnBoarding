using System;
using System.Linq;
using System.Collections.Generic;

namespace SockPairs
{
    class Program
    {
        private static int SockPairs(string socks)
        {
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            int toAdd = 0;
            foreach(char x in socks)
            {
                if (pairs.Keys.Contains(x))
                {  
                    
                    pairs[x]++;                   
                }
                else
                {
                    pairs.Add(x, 1);
                }
            }

            foreach(KeyValuePair<char, int> x in pairs)
            {
                if(x.Value == 1)
                {
                    pairs.Remove(x.Key);
                }
                if(x.Value >= 4)
                {
                    int temp = (x.Value - 2) / 2;
                    toAdd += temp;
                }
            }
            return pairs.Count + toAdd;
        }
        static void Main(string[] args)
        {    

            Console.WriteLine(SockPairs("AA"));
            Console.WriteLine(SockPairs("ABABC"));
            Console.WriteLine(SockPairs("CABBACCCC"));
            Console.WriteLine(SockPairs("CAAABBACCCCC"));
        }
    }
}
