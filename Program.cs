namespace Who_Wants_to_Be_a_Millionare
{
    internal class Program
    {
        static int GetReply()
        {
            int user_answer = 0;

            while (true)
            {
                user_answer = Convert.ToInt32(Console.ReadLine());

                if (user_answer < 1 || user_answer > 4)
                {
                    Console.WriteLine("That's the wrong numbah");
                }
                else
                {
                    return user_answer;
                }
            }
        }
        static string GetScore(int score)
        {
            string text = $"Current Score: {score}\n";
            return text;
        }

        static string GetQuestion(int question_number)
        {
            switch (question_number) //questions text
            {
                case 1:
                    return "Question 1.\n\nWhat are the colors of the Ukrainian flag?"
                    + "\n 1. Blue and yellow."
                    + "\n 2. Red and white."
                    + "\n 3. Green, red and white."
                    + "\n 4. Orange and black.\n";
                case 2:
                    return "Question 2.\n\n In which city KNUTE is located?"
                    + "\n 1. Kyiv."
                    + "\n 2. Kharkiv."
                    + "\n 3. Lviv."
                    + "\n 4. Odessa.\n";
                case 3:
                    return "Question 3.\n\n How many hearts does an octopus have?"
                    + "\n 1. One."
                    + "\n 2. Two."
                    + "\n 3. Three."
                    + "\n 4. Four.\n";
                case 4:
                    return "Question 4.\n\n Which country has the most natural islands in the world?"
                    + "\n 1. Canada."
                    + "\n 2. Sweden."
                    + "\n 3. Indonesia."
                    + "\n 4. Greece.\n";
                case 5:
                    return "Question 5.\n\n What is the color of a polar bear's skin?"
                    + "\n 1. Yellow."
                    + "\n 2. White."
                    + "\n 3. Beige."
                    + "\n 4. Black.\n";
                default:
                    return "";
            }
        }

        static bool NewQuestion(int question_number)
        {
            int correct_case = 0;

            switch (question_number) //set which option is correct for each case(question)
            {
                case 1:
                    correct_case = 1;
                    break;
                case 2:
                    correct_case = 1;
                    break;
                case 3:
                    correct_case = 3;
                    break;
                case 4:
                    correct_case = 2;
                    break;
                case 5:
                    correct_case = 4;
                    break;
            }
                
            Console.WriteLine(GetQuestion(question_number));
            return GetReply() == correct_case;
        }

        static void Main(string[] args)
        {
            int score = 0;
            int question = 1;

            while (true)
            {
                Console.WriteLine(GetScore(score));
                bool last_is_correct = NewQuestion(question);
                if (last_is_correct)
                {
                    Console.WriteLine("Correct Answer");
                }
                else
                {
                    Console.WriteLine($"Wrong Answer.\nYou've managed to aquire {score} points before you lost the game!");
                    return;
                }
                score += 1000; //increment score after the question was answered correctly
                question++; //go to the next question

                if (question >= 5+1)
                {
                    Console.WriteLine($"Congrats on completing this game!\nYou've managed to aquire {score} points!!!");
                    return;
                }
            }

        }
    }
}
