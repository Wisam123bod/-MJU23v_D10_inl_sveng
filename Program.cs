using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace MJU23v_D10_inl_sveng
{
    internal class Program
    {
        static List<SweEngGloss> dictionary;
        class SweEngGloss
        {
            public string word_swe, word_eng;
            public SweEngGloss(string word_swe, string word_eng)
            {
                this.word_swe = word_swe; this.word_eng = word_eng;
            }
            public SweEngGloss(string line)
            {
                string[] words = line.Split('|');
                this.word_swe = words[0]; this.word_eng = words[1];
            }
        }
        static void Main(string[] args)
            // La till en kontroll för att se argument.Lenght är minst 1
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Not enough arguments. Please provide a command.");
                return;
            }

            string defaultFile = "..\\..\\..\\dict\\sweeng.lis";
            Console.WriteLine("Welcome to the dictionary app!");
            do
            {
                Console.Write("> ");
                string[] argument = Console.ReadLine().Split();
                string command = argument[0]
             //La till en kontroll för att se till att kommandot är ett av de giltliga alternativen
                if (!command.Equals("quit", StringComparison.OrdinalIgnoreCase) &&
             !command.Equals("load", StringComparison.OrdinalIgnoreCase) &&
             !command.Equals("list", StringComparison.OrdinalIgnoreCase) &&
             !command.Equals("new", StringComparison.OrdinalIgnoreCase) &&
             !command.Equals("delete", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(< span class="math-inline">"Unknown command\: \{command\}"\);
         continue;

                if (command == "quit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                // Fixade "fix me"-kommentaren i LoadDictionary()-funktionen
                if (File.Exists(argument[1]))
                {
                    LoadDictionary(argument[1]);
                }
                else
                {
                    Console.WriteLine($"Filen \"{argument[1]}\" finns inte.");
                }

                else if (command == "load")
                    // Load dictionary // Fixme: Lägg till en säkerhetskontroll för att förhindra att filen öppnas om den inte finns
                    void LoadDictionary(string fileName)
                    {
                        using (StreamReader sr = new StreamReader(fileName))
                        {
                            dictionary = new List<SweEngGloss>();
                            string line = sr.ReadLine();
                            while (line != null)
                            {
                                SweEngGloss gloss = new SweEngGloss(line);
                                dictionary.Add(gloss);
                                line = sr.ReadLine();
                            }
                        }
                    }

                // Main function
                void Main(string[] args)
                {
                    // ...

                    // Load dictionary
                    if (argument.Length == 2)
                    {
                        LoadDictionary(argument[1]);
                    }
                    else if (argument.Length == 1)
                    {
                        LoadDictionary(defaultFile);
                    }

                    // ...
                }

                else if (command == "list")
                {
                    foreach(SweEngGloss gloss in dictionary)
                    {
                        Console.WriteLine($"{gloss.word_swe,-10}  - {gloss.word_eng,-10}");
                    }
                }
                else
                {
                    Console.WriteLine($"Ordet \"{s}\" finns inte i ordboken.");
                }
            }
    }
    }
catch (FileNotFoundException e)
{
    Console.WriteLine($"Filen \"{argument[1]}\" finns inte.");
}
                else if (command == "new")
                {
                    if (argument.Length == 3)
                    {
                        dictionary.Add(new SweEngGloss(argument[1], argument[2]));
                    }
                    else if(argument.Length == 1)
                    {
                        Console.WriteLine("Write word in Swedish: ");
                        string s = Console.ReadLine();
                        Console.Write("Write word in English: ");
                        string e = Console.ReadLine();
                        dictionary.Add(new SweEngGloss(s, e));
                    }
                }
                else if (command == "delete")
                {
                    // Fixad Fixme: Lägg till en säkerhetskontroll för att förhindra att ett index utanför listans gränser används
                if (argument.Length == 3)
                    {
                        int index = -1;
                        for (int iindex = 0; index < dictionary.Count; index++)
                        {
                            SweEngGloss gloss = dictionary[index];
                            if (gloss.word_swe == argument[1] && gloss.word_eng == argument[2])
                            {
                                index = index;
                            }
                        }
                        if (index != -1)
                        {
                            dictionary.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine($"Ordet \"{argument[1]}\" finns inte i ordboken.");
                        }
                    }
                    else if (argument.Length == 1)
                    {
                        Console.WriteLine("Write word to be translated: ");
                        string s = Console.ReadLine();
                        Console.WriteLine("Write word in English: ");
                        string e = Console.ReadLine();
                        int index = -1;
                        for (int index = 0; index < dictionary.Count; index++)
                        {
                            SweEngGloss gloss = dictionary[index];
                            if (gloss.word_swe == s || gloss.word_eng == e)
                            {
                                index = index;
                            }
                        }
                        if (index != -1)
                        {
                            Console.WriteLine($"{gloss.word_swe,-10} - {gloss.word_eng,-10}");
                        }
                        else
                        {
                            Console.WriteLine($"Ordet \"{s}\" finns inte i ordboken.");
                        }
                    }
                }
                while (true) ;
            }
    }
    }