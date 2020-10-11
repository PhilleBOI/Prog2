using System;

namespace ReverseRot
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_.";

            var input = Console.ReadLine();

            var words = input.Split(' ');
            var rotation = Convert.ToInt32(words[0]);
            var message = words[1];

            var result = "";

            for (int i = 0; i < message.Length; i++)
            {
                var letter = message.ToCharArray()[i];
                var indexOfLetter = alphabet.IndexOf(letter);

                var newIndex = indexOfLetter + rotation;
                if(newIndex > 27)
                {
                    newIndex = newIndex - 28;
                }
                var newLetter = alphabet.ToCharArray()[newIndex];

                result += newLetter;
            }

            var reverseWord = ReverseString(result);

            Console.WriteLine(reverseWord);

        }

        private static object ReverseString(string result)
        {
            var resultArr = result.ToCharArray();
            Array.Reverse(resultArr);
            return new string(resultArr);
        }
    }
}
