using System.IO;
using System.Text;

namespace consoleAppTest
{
    internal class VttConverter
    {
        public static void ConvertToSrt(string inputFile, string outputFile)
        {
            var lineReader = File.ReadAllLines(inputFile);
            var index = 1;
            var convertedSubtitle = new StringBuilder();
            foreach (var line in lineReader)
            {
                if (line.Length == 0) continue;
                if (line == "WEBVTT") continue;
                if (line.Contains("-->"))
                {
                    var subtitleTime = line.Split("-->");
                    var startTime = subtitleTime[0].Trim().Replace('.', ',');
                    var endTime = subtitleTime[1].Trim().Replace('.', ',');

                    convertedSubtitle.AppendLine(index.ToString());
                    convertedSubtitle.AppendLine(startTime + " --> " + endTime);
                    index++;
                }
                else
                {
                    convertedSubtitle.AppendLine(line);
                    convertedSubtitle.AppendLine();
                }
            }

            File.WriteAllText(outputFile, convertedSubtitle.ToString());
        }
    }
}