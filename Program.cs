using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-28): This allows us to use List
using System.IO; // Feedback(jcollard 2022-01-28): This allows us to use File
using System.Linq; // Feedback(jcollard 2022-01-28): This allows us to convert files to lists

namespace HighScoreTracker
{
    class Program // Feedback(jcollard 2022-01-28): Your methods must go inside of a class
    {

        public static void TestAll()
        {
            // Feedback(jcollard 2022-02-02): You're off to a great start! The next
            // step is to write your tests.
            bool testLoadScoreValues = TestLoadScoreValues.RunTest();
            Console.WriteLine($"Test LoadScoreValues(filename): {testLoadScoreValues}");
            
            bool testGetScoreValue = TestGetScoreValue.RunTest();
            Console.WriteLine($"Test GetScoreValue(score): {testGetScoreValue}");

            bool testFindInsertionPoint = TestFindInsertionPoint.RunTest();
            Console.WriteLine($"Test FindInsertionPoint(newscore): {testFindInsertionPoint}");

            bool testAddScore = TestAddScore.RunTest();
            Console.WriteLine($"Test AddScore(name, score, insertAt, scores): {testAddScore}");
        }
        static void Main(String[] args)
        {

            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }

            // Feedback(jcollard 2022-01-28): Great job! Your method stubs are
            // looking good. You need to finish the documentation comment before
            // moving on to Part 2.2.

            // Below is an example of how to load the high_scores.txt file and
            // extract the left and right columns

            // This line loads the file and converts it to a list of strings
            List<string> lines = File.ReadAllLines("high_scores.txt").ToList();

            // Extract the 3rd line from the list
            string collard = lines[2];

            // Split the string into two elements
            List<string> elems = collard.Split(" ").ToList();

            // Get the first element
            string name = elems[0];

            // Get the second element
            string scoreString = elems[1];

            // Convert the score to an integer
            int score = int.Parse(scoreString);

            Console.WriteLine($"{name} {score}");

        }

        /// <summary>
        /// The scores.txt file is stored in two columns. The first column is the players name and the second column is the players score. 
        /// This method loads the file and extracts the second column into a List<int>.
        /// </summary>
        /// <param name="filename">high_scores.txt</param>
        /// <returns>list<int></returns>
        public static List<int> LoadScoreValues(string filename)
        {
            // Check to see if the specified filename exists.
            // If it does not, throw an exception stating the file cannot be loaded
            // Load the file as a List and store it in a variable named, "lines"
            // Create a List called values.
            // Loop through each line
            // For each line, use GetScoreValue to extract the second column as an int
            // Add the int to values
            // Return values
            return null;
        }

        // static int GetScoreValue(string score);
        /// <summary>
        /// This is a helper method which, given a score string of the format "name score", extracts the score value from the second column,
        /// parses it into an int value, and finally returns it.
        /// </summary>
        /// <param name="score">Hudson75</param>
        /// <returns> Hudson - 75</returns>
        static int GetScoreValue(string score)
        {
            //Split the specified score string into two strings using ' ' as a delimiter
            // Store the result in a variable called parts
            // Parse the second element as an int int.Parse(parts[1])
            // Return the result
            return -1;
        }

        // static int FindInsertionPoint(List<int> values, int newScore);
        /// <summary>
        /// Given a list of score values and a newScore to insert into the high scores table,
        /// returns the index where the new score should be inserted.
        /// </summary>
        /// <param name="values">2, 42</param>
        /// <param name="newScore">56</param>
        /// <returns>56 --> newscore</returns>
        static int FindInsertionPoint(List<int> values, int newScore)
        {
            // Initialize a counter variable, insertAt, to 0.
            // Loop through each value in values
            // If the new score is greater than the current value, we should insert above that score so we return insertAt.
            // Otherwise, the new score should not be inserted above this score so we increment insertAt by 1 and continue.
            // If we reach the end of the list, insertAt should be the length of the list so we return insertAt.
            return -1;
        }


        // static void AddScore(String name, int score, int insertAt, List<String> scores);
        /// <summary>
        /// Given the name, score, insertion location, and a list of strings containing the current high scores, inserts the name and score at the specified location.
        /// Then writes the results to "scores.txt".
        /// </summary>
        /// <param name="name">Hudson</param>
        /// <param name="score">75</param>
        /// <param name="insertAt">1</param>
        /// <param name="scores">3, 15, 42, 68, 75</param>
        static void AddScore(String name, int score, int insertAt, List<String> scores)
        {
            // Create a string variable entry which will be the new row to add to the high score list.
            // Assign entry to be $"{name} {score}"
            // Insert entry into scores at the index insertAt
            // Use File.WriteLines to write each line of the scores list to the file "scores.txt"
            // return -1; // Feedback(jcollard 2022-01-28): cannot return
            // anything from a void method
        }

    }

}