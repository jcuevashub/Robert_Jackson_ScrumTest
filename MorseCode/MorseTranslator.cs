using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorseCode
{
    public class MorseTranslator
    {

        public string Translate(string message)
        {

            string translatedMessage = String.Empty;

            IDictionary<char, string> dictionary = new Dictionary<char, string>() {
                {'A', ".-"},
                {'J', ".---"},
                {'E', "."},
                {'S', "..." },
                {'O', "---" },
                {'D', "-.." },
                {'R', ".-." },
                {'I', ".." },
                {'W', ".--" },
                {'N', "-." },
                {'K', "-.-" },
                {'B', "-..." },
                {'C', "-.-." },
                {'V', "...-" },
                {'P', ".--." },
                {'M', "--" },
                {'Y', "-.--" },
                {'L',".-.."},
                {'T',"-"},
                {'U',"..-"}
            };

            if (message == "")
            {
                return translatedMessage;
            }

            foreach (char letra in message)
            {
                if (letra == ' ')
                {
                    translatedMessage += ' ';
                }
                else if (dictionary.ContainsKey(letra))
                {
                    translatedMessage += dictionary[letra] + "|";
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