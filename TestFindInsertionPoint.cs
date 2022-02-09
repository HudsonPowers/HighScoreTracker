using System;
using System.Collections.Generic;
using System.IO;

namespace HighScoreTracker
{


    class TestFindInsertionPoint
    {
        public static bool RunTest()
        {
            List<int> scores = new List<int>(); //TODO(jcollard 2022-02-04): You need to add `using System.Collections.Generic;` to the top of this file.

            // TODO(jcollard 2022-02-09): Try scores.Add(9000);
            scores.AddScore("Hudson, 9000"); // why are all the add scores red???
            scores.AddScore(1000);
            scores.AddScore(900);
            scores.AddScore(800);
            int result = Program.FindInsertionPoint(scores, 950); //TODO(jcollard 2022-02-04): You need to make FindInsertionPoint public
            if (result != 1)
            {
                Console.Error.WriteLine($"Failure, your score should have been 950 but was not");
                return false;
            }
            if (scores[0] != "Hudson 9001") // Try `if (scores[0] == 9001)` The error here is saying you cannot compare a number and a string.
            {
                Console.Error.WriteLine("The expected result was Hudson 9001 but it wasn't");
                return false;
            }

            // TODO(jcollard 2022-02-09): Don't forget to return true at the end
        }

    }

}