using System;
using System.IO;

namespace HighScoreTracker
{


    class TestGetScoreValue
    {
        public static bool RunTest()
        {
            list<int> scores = Program.LoadScoreValues("high_scores.txt"); // TODO (jcollard 2022-02-04): I think you can delete this line.
            int result = Program.GetScoreValues("Carl, 27"); //TODO(jcollard 2022-02-04): This should be "GetScoreValue". You will need to change GetScoreValue to public in Program.cs

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