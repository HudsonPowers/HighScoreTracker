using System;
using System.IO;

namespace HighScoreTracker
{


    class TestGetScoreValue
    {
        public static bool RunTest()
        {
            int result = Program.GetScoreValue("Carl, 27"); //TODO(jcollard 2022-02-04): This should be "GetScoreValue". You will need to change GetScoreValue to public in Program.cs

            if (result != 27)
            {
                Console.Error.WriteLine($"Failure, expected 27 but got {result}");
                return false;
            }
            result = Program.GetScoreValue("Hudson, 9001");
            if (result != 9001)
            {
                Console.Error.WriteLine($"Failure, expected 9001 but got {result}");
                return false;
            }
            result = Program.GetScoreValue("Susan, 8000");
            if (result != 8000)
            {
                Console.Error.WriteLine($"Failure, expected 8000 but got {result}");
                return false;
            }
            result = Program.GetScoreValue("Collard, 1");
            if (result != 1)
            {
                Console.Error.WriteLine($"Failure, expected 1 but got {result}");
                return false;
            }
            return true;
        }

    }

}