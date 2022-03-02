using System;
using System.Collections.Generic;
using System.IO;

namespace HighScoreTracker
{


    class TestFindInsertionPoint
    {
        public static bool RunTest()
        {
            List<int> scores = new List<int>(); 
            scores.Add(1000);
            scores.Add(900);
            scores.Add(800);
            int result = Program.FindInsertionPoint(scores, 950); 
            if (result != 1)
            {
                Console.Error.WriteLine($"Failure, your score should have been 950 but was not");
                return false;
            }
            if (scores[0] == 9001)
            {
                Console.Error.WriteLine("Failure, You can not compare a number and a string");
                return false;
            }
            return true;
        }

    }

}