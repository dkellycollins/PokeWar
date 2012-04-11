using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine
{
    public class ConsoleUI
    {
        /// <summary>
        /// Displays a message in the console.
        /// </summary>
        /// <param name="msg">Message</param>
        public static void DisplayMessage(string msg)
        {
            Console.Out.WriteLine(msg);
        }

        /// <summary>
        /// Gets an input after displaying the message.
        /// </summary>
        /// <param name="msg">Message</param>
        /// <returns>input</returns>
        public static string GetInput(string msg)
        {
            Console.Out.WriteLine(msg);
            return Console.In.ReadLine();
        }

        /// <summary>
        /// Displays a message and returns the input if it is in 
        /// the possible answers array.
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="posAns">possible inputs</param>
        /// <returns>Uppercase char input</returns>
        public static char GetCharInput(string msg, List<char> posAns)
        {
            char input;
            do
            {
                Console.Out.WriteLine(msg);
                input = Console.In.ReadLine().ToUpper()[0];
            } while (!posAns.Contains(input));
            return input;
        }

        /// <summary>
        /// Displays a message and returns the int input.
        /// </summary>
        /// <param name="msg">message</param>
        /// <param name="min">Minimum possible answer</param>
        /// <param name="max">Maximum possible answer</param>
        /// <returns>int input</returns>
        public static int GetIntInput(string msg, int min, int max)
        {
            string input;
            int i;
            do
            {
                Console.Out.WriteLine(msg);
                input = Console.In.ReadLine();
                if (!Int32.TryParse(input, out i))
                    i = min - 1;
            } while (i < min || i > max);
            return i;
        }
    }
}
