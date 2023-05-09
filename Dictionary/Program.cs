using System;
using System.IO;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            Console.WriteLine();

            using (StreamReader sr = File.OpenText(path))
            {
                try
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] recordedVotes = sr.ReadLine().Split(',');
                        string candidate = recordedVotes[0];
                        int votes = int.Parse(recordedVotes[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        } else
                        {
                            dictionary[candidate] = votes;
                        }
                    }

                    foreach (KeyValuePair<string, int> item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Oops, we have an exception error: " + e.Message);
                }
            }
        }
    }
}