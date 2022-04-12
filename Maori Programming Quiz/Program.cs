/*Introduction of the quiz
 * Explains how many chances you get for each question
 * Number of quesions
 * Goes through Question's 1-15
 * Presents score
 * Wishes the user goodbye
 */

Console.WriteLine("Welcome To My Te Reo Maori Quiz!\n");

Console.WriteLine("This quiz will help you improve your knowledge on Te Reo Maori colours!");
Console.WriteLine("There will be 15 questions in total, best of luck!\n\n");

//variables 
int score = 0;
int TotalScore;
char ans;
char option;

//question 1

do {

    Console.WriteLine("What is the colour 'Yellow' in Te Reo Maori?");
    Console.WriteLine("A: Whero");
    Console.WriteLine("B: Karaka");
    Console.WriteLine("C: Kowhai");
    Console.WriteLine("D: Mangu");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'c' || ans == 'C')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'C'");
        if (score > 0)
        {
            score--;
        }
    }

    //Questions 2

    Console.WriteLine("What is the colour 'Red' in Te Reo Maori?");
    Console.WriteLine("A: Kikorangi");
    Console.WriteLine("B: Whero");
    Console.WriteLine("C: Parauri");
    Console.WriteLine("D: Waiporoporo");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'b' || ans == 'B')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'B'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 3

    Console.WriteLine("What is the colour 'Black' in Te Reo Maori?");
    Console.WriteLine("A: Mangu");
    Console.WriteLine("B: Parauri");
    Console.WriteLine("C: Kowhai");
    Console.WriteLine("D: Whero");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'a' || ans == 'A')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'A'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 4

    Console.WriteLine("What is the colour 'Green' in Te Reo Maori?");
    Console.WriteLine("A: Karaka");
    Console.WriteLine("B: Kakariki");
    Console.WriteLine("C: Kowhai");
    Console.WriteLine("D: Waiporoporo");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'B' || ans == 'b')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'B'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 6

    Console.WriteLine("What is the colour 'Orange' in Te Reo Maori?");
    Console.WriteLine("A: Kikorangi");
    Console.WriteLine("B: Mangu");
    Console.WriteLine("C: Kowhai");
    Console.WriteLine("D: Karaka");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'd' || ans == 'D')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'D'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 7

    Console.WriteLine("What is the colour 'Purple' in Te Reo Maori?");
    Console.WriteLine("A: Waiporoporo");
    Console.WriteLine("B: Parauri");
    Console.WriteLine("C: Whero");
    Console.WriteLine("D: Mangu");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'A' || ans == 'a')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'A'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 8

    Console.WriteLine("What is color 'Pink' in Te Reo Maori?");
    Console.WriteLine("A: Parauri");
    Console.WriteLine("B: Māwhero");
    Console.WriteLine("C: Kakara");
    Console.WriteLine("D: Kowhai");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'b' || ans == 'B')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'B'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 9

    Console.WriteLine("What is color 'White' in Te Reo Maori?");
    Console.WriteLine("A: Mangu");
    Console.WriteLine("B: Kakariki");
    Console.WriteLine("C: Whero");
    Console.WriteLine("D: Ma");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'd' || ans == 'D')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'D'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 10

    Console.WriteLine("What is color 'Gray' in Te Reo Maori?");
    Console.WriteLine("A: Kākaka");
    Console.WriteLine("B: Waiporoporo");
    Console.WriteLine("C: Hina");
    Console.WriteLine("D: Whero");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'C' || ans == 'c')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'C'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 11

    Console.WriteLine("What is color 'Blue' in Te Reo Maori?");
    Console.WriteLine("A: Ma");
    Console.WriteLine("B: Kikorangi");
    Console.WriteLine("C: Kakariki");
    Console.WriteLine("D: Mangu");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'b' || ans == 'B')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'B'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 12

    Console.WriteLine("What is color 'Turquoise' in Te Reo Maori?");
    Console.WriteLine("A: Whero");
    Console.WriteLine("B: Ma");
    Console.WriteLine("C: Karaka");
    Console.WriteLine("D: Karekau");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'd' || ans == 'D')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'D'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 13

    Console.WriteLine("What is color 'Magenta' in Te Reo Maori?");
    Console.WriteLine("A: Makurakura");
    Console.WriteLine("B: Whero");
    Console.WriteLine("C: Kakariki");
    Console.WriteLine("D: Kowhai");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'a' || ans == 'A')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'A'");
        if (score > 0)
        {
            score--;
        }
    }

    //Question 14

    Console.WriteLine("What is color 'Lime Green' in Te Reo Maori?");
    Console.WriteLine("A: Kahurangi marama");
    Console.WriteLine("B: Ma");
    Console.WriteLine("C: Kotakota kākāriki");
    Console.WriteLine("D: Kowhai");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'c' || ans == 'C')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'C'");
        if (score > 0)
        {
            score--;
        }
    }
    //Question 15

    Console.WriteLine("What is color 'Dark Blue' in Te Reo Maori?");
    Console.WriteLine("A: Kakariki pouri");
    Console.WriteLine("B: Kahurangi pouri");
    Console.WriteLine("C: Mangu");
    Console.WriteLine("D: Kahurangi marama");
    ans = Convert.ToChar(Console.ReadLine());

    while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
    {
        Console.WriteLine("Incorrect, please select only a,b c or d");
        ans = Convert.ToChar(Console.ReadLine());
    }
    if (ans == 'b' || ans == 'B')
    {
        Console.WriteLine(" You're correct! Next Question:\n");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect :( Correct answer was 'B'");
        if (score > 0)
        {
            score--;
        }
    }
    //User has reached the end of the quiz
    //Shows the user their score
    //Asks user if they wish to repeat
    //Loops the whole quiz if select 'y'

    Console.WriteLine("Thank you! You have reached the end.\n");
    Console.WriteLine("Your score is: ");
    TotalScore = score;
    Console.WriteLine(TotalScore);

    Console.WriteLine("\nIf you wish to try again, type 'y' or type press any other key to exit. \n");
    option= char.Parse(Console.ReadLine());

} while (option == 'y' || option == 'Y');
