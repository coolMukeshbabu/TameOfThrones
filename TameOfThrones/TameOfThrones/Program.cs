using System;
using System.Collections.Generic;
using TameOfThrones.Services;

namespace TameOfThrones
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<Kingdom> kingdoms = Helper.GetKingdoms();
            Print(kingdoms);

            //Read secret messages

            
        }

        public static void Print(List<Kingdom> kingdoms)
        {
            foreach(var kingdom in kingdoms)
            {
                Console.WriteLine(kingdom.GetName());
            }
            Console.ReadLine();
        }
    }
}
