using System;
using System.Text;

namespace _4.MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morseCode = new string[36]
            {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
                "....", "..", ".---", "-.-", ".-..", "--", "-.",
                "---", ".--.", "--.-", ".-.", "...", "-", "..-",
                "...-", ".--", "-..-", "-.--", "--..", ".----",
                "..---", "...--", "....-", ".....", "-....",
                "--...", "---..", "----.", "-----"
            };

            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            string toTranslate = Console.ReadLine();

            string[] split = toTranslate.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            string[] furtherSplit;

            StringBuilder result = new StringBuilder();

            foreach (var s in split)
            {
                furtherSplit = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var s1 in furtherSplit)
                {
                    result.Append(characters[Array.IndexOf(morseCode, s1)]);
                }
                result.Append(' ');
            }

            Console.WriteLine(result.ToString());
        }
    }
}