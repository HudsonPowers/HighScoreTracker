using System;
using System.Collections.Generic; // Feedback(jcollard 2022-02-02): Necessary to use List
using System.IO;

namespace HighScoreTracker
{


    class TestLoadScoreValues
    {
        public static bool RunTest()
        {
            // TODO(jcollard 2022-02-02):
            // Each of your tests should call the associated method with various inputs
            // You should write the expected outputs. For example, one of the possible inputs
            // to LoadScoreValues(string filename) could be:

            List<int> testScores = Program.LoadScoreValues("test_high_score.txt");

            // Create a file called test_high_scores.txt that contains some test data
            // Based on that file, how many elements should be in the testScores list?
            // What values should be contained inside?
            // For example:

            if (testScores.Count != 3)
            {
                Console.Error.WriteLine($"Failure: Expected the list to contain 3 elements but it contained {testScores.Count}");
                return false;
            }

            if (testScores[0] != 8000)
            {
                Console.Error.WriteLine($"Failure: Expected the first element in the list to be 8000 but it was {testScores[0]}.");
                return false;
            }

            if (testScores[1] != 7500)
            {
                Console.Error.WriteLine($"Failure: Expected the second element in the list to be 7500 but it was {testScores[1]}.");
                return false;
            }

            if (testScores[2] != 7300)
            {
                Console.Error.WriteLine($"Failure: Expected the third element in the list to be 7300 but it was {testScores[2]}.");
                return false;
            }

            try
            {
                Program.LoadScoreValues("Notafile.txt");
                Console.WriteLine("Notafile does not exist so catch");
                return false;
            }

            catch (Exception x)
            {
                
            }

            return true;
        }

    }

}