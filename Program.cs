using System;

namespace ReverseWordsInASentece
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWordsSentence("RemoteIo is awesome"));
            Console.WriteLine(ReverseWordsSentence("Candidates give interview"));
            Console.WriteLine(ReverseWordsSentence("best candidates are selected"));
            Console.WriteLine(ReverseWordsSentence(" testing "));
            Console.WriteLine(ReverseWordsSentence("Leap Toronto "));
            Console.ReadKey();
        }

        static string ReverseWordsSentence(string sentence)
        {
            string newSentence = string.Empty;
            string newWord = string.Empty;

            for (int index = sentence.Length - 1; index > -1; index--)
            {
                char letter = sentence[index];

                if (letter == ' ')
                {
                    if (index == sentence.Length || index == 0)
                        continue;

                    newSentence = newWord + letter + newSentence;
                    newWord = string.Empty;
                    continue;
                }

                newWord += sentence[index];
            }

            newSentence = newWord + ' ' + newSentence;

            return newSentence;
        }
    }
}
