using System;
using System.IO;

namespace consoleAppTest
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var path = args.Length == 0 ? AppContext.BaseDirectory : args[0];

            var files = Directory.GetFiles(path);
            foreach (var variable in files)
            {
                if (Path.GetExtension(variable) != ".vtt") continue;
                Console.WriteLine(variable);
                VttConverter.ConvertToSrt(variable, path +@"\"+ Path.GetFileNameWithoutExtension(variable) + ".srt");
            }
        }
    }
}
