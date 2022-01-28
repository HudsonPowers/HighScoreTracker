using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-28): This allows us to use List
using System.IO; // Feedback(jcollard 2022-01-28): This allows us to use File
using System.Linq; // Feedback(jcollard 2022-01-28): This allows us to convert files to lists

namespace HighScoreTracker
{
    class Program // Feedback(jcollard 2022-01-28): Your methods must go inside of a class
    {
        static void Main(String[] args)
        {
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
        /// TODO(jcollard 2022-01-28): Complete documentation comments
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        static List<int> LoadScoreValues(string filename)
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
        /// TODO(jcollard 2022-01-28): Complete documentation comments
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
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
        /// TODO(jcollard 2022-01-28): Complete documentation comments
        /// </summary>
        /// <param name="values"></param>
        /// <param name="newScore"></param>
        /// <returns></returns>
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
        /// TODO(jcollard 2022-01-28): Complete documentation comments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        /// <param name="insertAt"></param>
        /// <param name="scores"></param>
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