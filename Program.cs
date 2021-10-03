using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman Game");
            string[] listwords = new string[2];
            listwords[0] = "Tennis";
            listwords[1] = "Football";
            listwords[2] = "Badminton";

            Random randGen = new Random();
            var idx = randGen.Next(0, 2);
            string mysteryWord = listwords[idx];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");

            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';

            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
                Console.ReadLine();
            } 
        }
              class HangManGame
        {
            static bool correctWord(string mysteryword, List<string> letterGuessed)
            {
                bool word = false;
                for (int i = 0; i < mysteryword.Length; i++)
                {
                    string c = Convert.ToString(mysteryword[i]);
                    if (letterGuessed.Contains(c))
                    {
                        word = true;
                    }
                    else
                    {
                        return word = false;
                    }
                }
                return word;
            }
            static string correctLetter(string mysteryword, List<string> letterGuessed)
            {
                string correctletters = "";
                for (int i = 0; i < mysteryword.Length; i++)
                {
                    string c = Convert.ToString(mysteryword[i]);

                    if (letterGuessed.Contains(c))
                    {
                        correctletters += c;
                    }
                    else
                    {
                        correctletters += "_ ";
                    }
                }
                return correctletters;
            }
        }
    }
}
