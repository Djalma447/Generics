using System;
using System.Collections.Generic;
using System.IO;

namespace DictionaryHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int numberVotes = int.Parse(line[1]);
                        if (!votes.ContainsKey(name))
                        {
                            votes.Add(name, numberVotes);
                        }
                        else
                        {
                            votes[name] += numberVotes;
                        }
                    }
                    foreach (KeyValuePair<string, int> item in votes)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
