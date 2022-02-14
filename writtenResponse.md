# High Score Tracker Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

The purpose of High Score Tracker is to keep a record of high scores for a game. People coding games that implement high scores can use this code and use it for their game.

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video shows that with a name and score, the score is added to the high score list.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

my program recieves a name and a score and gives a list of high scores in a file.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<string> result = File.ReadAllLines(filename).ToList();
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
  foreach (string line in result)
            {
                int score = GetScoreValue(line);
                values.Add(score);
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "result"

### 3b iv.

Describes what the data contained in the list represents in your program

the list represents all the scores given.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

The list allows for the simplicity of adding new scores to a high score list. Without this list, there would need to be a set amount of scores with their own variables each time.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static List<int> LoadScoreValues(string filename)
        {
            if (File.Exists(filename) == false)
            {
                throw new Exception($"The file {filename} does can not be loaded");
            }
            List<string> result = File.ReadAllLines(filename).ToList();

            List<int> values;
            values = new List<int>();

            foreach (string line in result)
            {
                int score = GetScoreValue(line);
                values.Add(score);
            }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
List<int> scores = LoadScoreValues("high_scores.txt");
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

The scores.txt file is stored in two columns. The first column is the players name and the second column is the players score. This method loads the file and extracts the second column into a List<int>.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

// Check to see if the specified filename exists.
// If it does not, throw an exception stating the file cannot be loaded
// Load the file as a List and store it in a variable named, "lines"
// Create a List called values.
// Loop through each line
// For each line, use GetScoreValue to extract the second column as an int
// Add the int to values
// Return values

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

if filename is notafile.txt. This will cause the body of the if statement to execute.

Second call:

If filename is scores.txt. This will cause the body of the if statement to be skipped.

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
if (File.Exists(filename) == false)
if the file exists.

Condition(s) tested by the second call:

if the file is a valid name(scores.txt)

### 3d iii.

Result of the first call:

a non-valid filename which does not exits causes an exception to be thrown

Result of the second call:

the result of calling a valid filename(scores.txt) to load file and extract scores.