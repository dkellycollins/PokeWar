using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeWar.ConsoleUI
{
    /// <summary>
    /// Handles safely reading input and writing output.
    /// </summary>
    public class IOHelper
    {
        private StreamWriter _fileWriter;

        /// <summary>
        /// Creates a new IOHelper that will not write to a file.
        /// </summary>
        public IOHelper()
        {

        }

        /// <summary>
        /// Creates a new IOHelper that will write to the given file.
        /// </summary>
        /// <param name="fileName"></param>
        public IOHelper(string fileName)
        {
            FileStream file;
            if (File.Exists(fileName))
                file = File.Open(fileName, FileMode.Append);
            else
                file = File.Create(fileName);

            _fileWriter = new StreamWriter(file);
        }

        /// <summary>
        /// Reads in a character and returns the result when the user enters in a possible answer.
        /// Note only compares first character. So quit would be a valid answer for q.
        /// </summary>
        /// <param name="msg">Message to display before entering text.</param>
        /// <param name="posAns">An array for possible answers.</param>
        /// <returns>Valid user input.</returns>
        public char ReadChar(string msg, char[] posAns)
        { 
            string buff = string.Empty;

            do
            {
                Console.Out.Write(msg);
                buff = Console.In.ReadLine();
            } while (buff.Length == 0 || !posAns.Contains(buff[0]));

            if(_fileWriter != null)
                _fileWriter.WriteLine(msg + buff);

            return buff[0];
        }

        /// <summary>
        /// Reads in an integer and returns the result when the user enters a value between min and max.
        /// </summary>
        /// <param name="msg">Message to display before entering text.</param>
        /// <param name="min">Minimum value that can be entered.</param>
        /// <param name="max">Maximum value that can be entered.</param>
        /// <returns>Valid user input.</returns>
        public int ReadInt(string msg, int min, int max)
        {
            string buff = string.Empty;
            bool parsed = false;
            int ans = 0;

            do
            {
                Console.Out.Write(msg);
                buff = Console.In.ReadLine();
                parsed = Int32.TryParse(buff, out ans);
            } while (!parsed || (ans < min || ans > max));

            if (_fileWriter != null)
                _fileWriter.WriteLine(msg + buff);

            return ans;
        }

        /// <summary>
        /// Reads in a string from the user.
        /// </summary>
        /// <param name="msg">Message to display before entering text.</param>
        /// <returns>A none empty string.</returns>
        public string ReadString(string msg)
        {
            string buff = string.Empty;

            do
            {
                Console.Out.Write(msg);
                buff = Console.In.ReadLine();
            } while (buff.Length == 0);

            if (_fileWriter != null)
                _fileWriter.WriteLine(msg + buff);

            return buff;
        }

        /// <summary>
        /// Simply writes the message.
        /// </summary>
        /// <param name="msg"></param>
        public void WriteString(string msg)
        {
            Console.Out.WriteLine(msg);
            if (_fileWriter != null)
                _fileWriter.WriteLine(msg);
        }

        public void Dispose()
        {
            if (_fileWriter != null)
            {
                _fileWriter.Flush();
                _fileWriter.Close();
            }
        }
    }
}
