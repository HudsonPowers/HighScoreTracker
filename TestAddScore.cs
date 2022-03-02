using System;
using System.Collections.Generic;
using System.IO;

namespace HighScoreTracker
{


    class TestAddScore
    {
        public static bool RunTest()
        {
            List<string> testList;
            testList = new List<string>();
            testList.Add("sam 8000");
            testList.Add("sue 7500");
            testList.Add("jerry 7300");
            Program.AddScore("bob", 7000, 3, testList);

            if (testList.Count != 4)
            {
                Console.Error.WriteLine($"Failure, expected 4 but result was {testList.Count}");
                return false;
            }

            if (testList[3] != "bob, 7000")
            {
                Console.Error.WriteLine($"Failure, expected bob 7000 but was {testList[3]}");
                return false;
            }

            try
            {
                Program.AddScore(null, 2000, 2, testList);
                Console.Error.WriteLine("Expected an error for a null name.");
                return false;
            }
            catch
            {

            }



            Program.AddScore("sam", 7500, 2, testList);

            return true;
        }

    }

}