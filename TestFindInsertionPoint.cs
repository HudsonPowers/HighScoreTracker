using System;
using System.IO;

namespace HighScoreTracker
{


    class TestFindInsertionPoint
    {
        public static bool RunTest()
        {
            List<int> scores = new List<int>();
            scores.AddScore("Hudson, 9000");
            scores.AddScore(1000);
            scores.AddScore(900);
            scores.AddScore(800);
            int result = Program.FindInsertionPoint(scores, 950);
            if (result != 1)
            {
                Console.Error.WriteLine($"Failure, your score should have been 950 but was not");
                return false;
            }

            Console.WriteLine("The method should display 'InsertAt = 0'");
            if (result != 1)
            {
                Console.Error.WriteLine("the result expected was 0 but was");
                return false;
            }
            if (scores[0] != "Hudson 9001")
            {
                Console.Error.WriteLine("The expected result was Hudson 9001 but it wasn't");
                return false;
            }
        }

    }

}