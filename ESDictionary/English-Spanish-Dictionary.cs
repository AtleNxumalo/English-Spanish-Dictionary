using System;
using System.Collections;
using System.Collections.Generic;


 public class English_SpanishDictionary
    {
        public void Main(string[] arguments)
        {
            Dictionary<string, string> English_to_Spanish_Dictionary = new Dictionary<string, string>();


            // Here you add English words and their Spanish translations to the dictionary
            English_to_Spanish_Dictionary.Add("hello", "hola");
            English_to_Spanish_Dictionary.Add("goodbye", "adiós");
            English_to_Spanish_Dictionary.Add("good", "bueno");
            English_to_Spanish_Dictionary.Add("day", "dia");
            English_to_Spanish_Dictionary.Add("afternoon", "tarde");
            English_to_Spanish_Dictionary.Add("night", "noche");

            //prompt user to enter an english word
            Console.WriteLine("English to Spanish Dictionary:");
            Console.WriteLine("=============================");


            while (true)
            {
                Console.WriteLine("Enter an English word (or 'exit' to exit the program):");
                string englishWord = Console.ReadLine().ToLower(); // Converts all words to lowercase for case-insensitive analysis

                if (englishWord == "exit")
                    break;

                if (English_to_Spanish_Dictionary.ContainsKey(englishWord))
                {
                    // If the word exists in the dictionary, its corresponding Spanish translation will be retrieved and displayed.
                    string translation = English_to_Spanish_Dictionary[englishWord];
                    Console.WriteLine($"Spanish translation: {translation}");

                }
                else
                {// If the word isn't found in the dictionary, this message will be displayed.
                    Console.WriteLine("No such word found in the dictionary.");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Thanks for using the dictionary!");



        }
  }
