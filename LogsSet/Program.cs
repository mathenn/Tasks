using System;
using System.IO;
using System.Collections.Generic;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> setA = new HashSet<int>();
            HashSet<int> setB = new HashSet<int>();
            HashSet<int> setC = new HashSet<int>();


            Console.Write("How many students for course A? ");
            int courseA = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < courseA; i++)
            {
                int code = int.Parse(Console.ReadLine());
                setA.Add(code);
            }
            setA.UnionWith(setB);
            

            Console.Write("How many students for course B? ");
            int courseB = int.Parse(Console.ReadLine());
            for (int i = 0; i < courseB; i++)
            {
                int code = int.Parse(Console.ReadLine());
                setB.Add(code);
            }

            setB.UnionWith(setC);


            Console.Write("How many students for course C? ");
            int courseC = int.Parse(Console.ReadLine());
            for (int i = 0; i < courseC; i++)
            {
                int code = int.Parse(Console.ReadLine());
                setC.Add(code);
            }

            HashSet<int> all = new HashSet<int>(setA);
            all.UnionWith(setB);
            all.UnionWith(setC);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}