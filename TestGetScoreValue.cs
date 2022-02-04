using System;
using System.IO;

namespace HighScoreTracker
{


    class TestGetScoreValue
    {
        public static bool RunTest()
        {
            list<int> scores = Program.LoadScoreValues("high_scores.txt");
            int result = Program.GetScoreValues("Carl, 27");

            if (result != 27)
            {
                Console.Error.WriteLine($"Failure, expected 27 but got {scores}");
                return false;
            }
            result = Program.GetScoreValues("Hudson, 9001");
            if (result != 9001)
            {
                Console.Error.WriteLine($"Failure, expected 9001 but got {scores}");
                return false;
            }
            result = Program.GetScoreValues("Susan, 8000");
            if (result != 8000)
            {
                Console.Error.WriteLine($"Failure, expected 8000 but got {scores}");
                return false;
            }
            result = Program.GetScoreValues("Collard, 1");
            if (result != 1)
            {
                Console.Error.WriteLine($"Failure, expected 1 but got {scores}");
                return false;
            }
            return true;
        }

    }

}