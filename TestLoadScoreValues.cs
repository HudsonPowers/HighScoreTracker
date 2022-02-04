using System;
using System.IO;

namespace HighScoreTracker
{


    class TestLoadScoreValues
    {
        public static bool RunTest()
        {

            List<string> scoreList;
            scoreList = new List<string>();
            scoreList.Add("drake 8000");
            scoreList.Add("dog 7500");
            scoreList.Add("cat 7300");
            Program.AddScore("mouse", 10000, 0, scoreList);

            if (scoreList.Count != 3)
            {
                Console.Error.WriteLine($"Failure, expected 3 but result was {countList.Count}");
                return false;
            }
            if (scoreList.Count != 4)
            {
                Console.Error.WriteLine($"Failure, expected 4 but result was {countList.Count}");
                return false;
            }
            if (score[0] != "drake 8000")
            {
                Console.Error.WriteLine($"Failure, expected drake 8000 but result was {score[0]}");
                return false;
            }

            // Check to see if the specified filename exists.
            // If it does not, throw an exception stating the file cannot be loaded
            // Load the file as a List and store it in a variable named, "lines"
            // Create a List called values.
            // Loop through each line
            // For each line, use GetScoreValue to extract the second column as an int
            // Add the int to values
            // Return values
        }

    }

}