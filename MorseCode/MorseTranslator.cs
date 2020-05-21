using System;
using System.Collections.Generic;

namespace MorseCode
{
    public class MorseTranslator
    {

        IDictionary<char, string> dictionary = new Dictionary<char, string>()
        {
            {'S', "..."},
            {'O', "---"},
            {'E', "."},
            {'A', ".-"},
            {'D', "-.."},
            {'R', ".-."},
            {'L', ".-.."},
            {'I', ".."},
            {'Y', "-.--"},
            {'W', ".--"},
            {'N', "-."},
            {'M', "--"},
            {'J', ".---"},
            {'C', "-.-."},
            {'K', "-.-"},
            {'B', "-..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'P', ".--."},
        };

        private string translatedMessage = String.Empty;

        public string Translate(string message)
        {
            if (message == "")
            {
                return translatedMessage;
            }

            foreach (char letter in message)
            {
                if (letter == ' ')
                {
                    translatedMessage += ' ';
                } 
                else if (dictionary.ContainsKey(letter))
                {
                    translatedMessage += dictionary[letter] + "|";
                }
            }

            string[] dividedMessage = translatedMessage.Split(' ');
            
            string newMessage = "";
            
            for (int i = 0; i < dividedMessage.Length; i++)
            {
                newMessage += dividedMessage[i].Remove(dividedMessage[i].Length - 1) + " ";
            }


            return newMessage.Remove(newMessage.Length - 1);
        }
    }
}