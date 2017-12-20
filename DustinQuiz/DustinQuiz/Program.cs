using System;

namespace DustinQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DustinQuiz!");
            // Set score to zero starting out
            short score = 0;
            // Run Question 1
            short points = Question1();
            // Apply points returned to score
            score += points;
            // Run Question 2
            points = Question2();
            // Apply points returned to score
            score += points;
            // Run Question 3
            points = Question3();
            // Apply points returned to score
            score += points;
            // Run Question 4
            points = Question4();
            // Apply points returned to score
            score += points;
            // Run Question 5
            points = Question5();
            // Apply points returned to score
            score += points;
            // Show user their end points
            Console.WriteLine("Congratulations! You got " + score / 100 + " out of 5 correct and earned " + score + " points!");
            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }

        static short Question1()
        {
            // Set first question
            string question = "What is Dustin's favorite color?";
            // Create array of possible answers
            string[] possibleAnswers = { "Red", "Green", "Purple" };
            // Which number corrosponds to the correct answer (index + 1)
            int answer = 3;
            // Use "Question" method to present first question, result is the amount of points earned.
            short points = Question(question, possibleAnswers, answer);

            return points;
        }

        static short Question2()
        {
            // Set second question
            string question = "What is Dustin's favorite activity?";
            // Create array of possible answers
            string[] possibleAnswers = { "VideoGames", "Digital Painting", "Sleeping" };
            // Which number corrosponds to the correct answer (index + 1)
            int answer = 2;
            // Use "Question" method to present first question, result is the amount of points earned.
            short points = Question(question, possibleAnswers, answer);

            return points;
        }

        static short Question3()
        {
            // Set third question
            string question = "What is Dustin Thinking about?";
            // Create array of possible answers
            string[] possibleAnswers = { "VideoGames", "Music", "Sleeping" };
            // Which number corrosponds to the correct answer (index + 1)
            int answer = 3;
            // Use "Question" method to present first question, result is the amount of points earned.
            short points = Question(question, possibleAnswers, answer);

            return points;
        }

        static short Question4()
        {
            //Set fourth question
            string question = "When does the Narwhal Bacon?";
            // Create array of possible answers
            string[] possibleAnswers = { "Midnight", "Tomorrow", "Wednessday", "Dustin's Birthday" };
            // Which number corrosponds to the correct answer (index + 1)
            int answer = 1;
            // Use "Question" method to present first question, result is the amount of points earned.
            short points = Question(question, possibleAnswers, answer);

            return points;
        }

        static short Question5()
        {
            //Set fourth question
            string question = "What are you thinking of?";
            // Create array of possible answers
            string[] possibleAnswers = { "Whatever", "Nothing", "Ninjas", "Dustin's Birthday" };
            Console.WriteLine(question);
            for (int index = 0; index < possibleAnswers.Length; index++)
            {
                int answerNumber = index + 1;
                Console.WriteLine(answerNumber + ") \"" + possibleAnswers[index] + "\"");
            }
            Console.WriteLine("Enter a number to make a guess.");
            Console.ReadLine();
            Console.WriteLine("Correct! +100 Points!");
            Console.ReadLine();
            Console.Clear();
            return (100);
        }

        static short Question(string question, string[] possibleAnswers, int solution)
        {
            // Cycling set to false
            // Ask the player a question
            Console.WriteLine(question);
            // Present possible answers
            for (int index = 0; index < possibleAnswers.Length; index++)
            {
                int answerNumber = index + 1;
                Console.WriteLine(answerNumber + ") \"" + possibleAnswers[index] + "\"");
            }
            // Get the player's guess, should be integer
            Console.WriteLine("Enter a number to make a guess.");
            string guess = Console.ReadLine();
            // If the guess can be parsed to short
            // if (Int16.TryParse(guess, out short guessParsed))
            try{
                Int16 guessParsed = Int16.Parse(guess);
                // If the guess is beyond the available choices
                if (guessParsed > possibleAnswers.Length || guessParsed <= 0)
                {
                    // Out of Range (TRY AGAIN)
                    Console.WriteLine("That wasn't an available answer, try again!");
                    Console.ReadLine();
                    Console.Clear();
                    return Question(question, possibleAnswers, solution);
                }
                else // If the guess is a valid number
                {
                    //If the guess is the right answer
                    if (guessParsed == solution)
                    {
                        //Correct! (SCORE PLAYER 100)
                        Console.WriteLine("Correct! +100 Points!");
                        Console.ReadLine();
                        Console.Clear();
                        return (100);
                    }
                    else
                    {
                        //Wrong Answer
                        Console.WriteLine("Sorry, that's not right.");
                        Console.ReadLine();
                        Console.Clear();
                        return (0);
                    }
                }
            }
            catch( FormatException e)
            { // If the guess could not be parsed
                // Not an integer (TRY AGAIN)
                Console.WriteLine("That wasn't an available answer, try again!");
                Console.ReadLine();
                Console.Clear();
                return Question(question, possibleAnswers, solution);
            }
        } // End of Question Method
    }
}
