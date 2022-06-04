/*Introduction of the quiz
 * Explains how many chances you can get per question
 * Number of quesions
 * Goes through Question's 1-15
 * Presents score
 * Wishes the user goodbye
 */

Console.WriteLine("Welcome To My Te Reo Maori Quiz!\n");

Console.WriteLine("This quiz will help you improve your knowledge on Te Reo Maori colours!");
Console.WriteLine("You will only get no chances if you get the answer wrong");
Console.WriteLine("Select a level on your chosing, by either pressing 1, 2, or 3 on the keyboard\n\n");

//variables 
int score = 0;
int TotalScore;
char ans;
int option;

//question 1

do {
    Console.WriteLine("\t->Level 1");
    Console.WriteLine("\n\t->Level 2");
    Console.WriteLine("\n\t->Level 3");
    Console.WriteLine("\nPlease input the number of the level of your choosing!");

    while(!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 4)
    {
        Console.WriteLine("Please only enter a valid number.");
    }

    switch (option)
    {
        case 1:
            Console.WriteLine("\nAre you set for Level 1?");
            Level1();
            break;
        case 2:
            Console.WriteLine("\nAre you set for Level 2?");
            Level2();
            break;
        case 3:
            Console.WriteLine("\nAre you set for Level 3?");
            Level3();
            break;
        default:
            Console.WriteLine("\nAre you set for Level 1?");
            Level1();
            break;
    }

    void Level1()
    {
        Console.WriteLine("Level 1: Easy");
        Console.WriteLine("Topic: Colours\n");
        Console.WriteLine("Questions in the topic: 5\n");
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
            Console.WriteLine("You're correct! Next Question:\n");
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
            Console.WriteLine("You're correct! Next Question:\n");
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
            Console.WriteLine("You're correct! Next Question:\n");
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
            Console.WriteLine("You're correct! Next Question:\n");
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
        //Loops the whole quiz if user selects 'y'

        Console.WriteLine("Thank you! You have reached the end.\n");
        Console.WriteLine("Your score is: ");
        TotalScore = score;
        Console.WriteLine(TotalScore);
    
    Console.WriteLine("\nIf you wish to try again, type 'y' or type press any other key to exit. \n");
    option= char.Parse(Console.ReadLine());
    }

    void Level2()
    {
        //Question 5
        Console.WriteLine("\nLevel 2: Hard");
        Console.WriteLine("Topic: Animals\n");
        Console.WriteLine("Questions in the topic: 5\n");
        Console.WriteLine("What is 'dog' in Te Maori?");
        Console.WriteLine("A: Kuri");
        Console.WriteLine("B: Kau");
        Console.WriteLine("C: Wheke");
        Console.WriteLine("D: Poaka");
        ans = Convert.ToChar(Console.ReadLine());

        while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
        {
            Console.WriteLine("Incorrect, please select only a,b c or d");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'a' || ans == 'A')
        {
            Console.WriteLine("You're correct! Next Question:\n");
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

        //Question 6

        Console.WriteLine("What is 'cat' in Te Reo Maori?");
        Console.WriteLine("A: Reme");
        Console.WriteLine("B: Pepe");
        Console.WriteLine("C: Ngeru");
        Console.WriteLine("D: Wheke");
        ans = Convert.ToChar(Console.ReadLine());

        while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
        {
            Console.WriteLine("Incorrect, please select only a,b c or d");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'c' || ans == 'C')
        {
            Console.WriteLine("You're correct! Next Question:\n");
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

        //Question 7

        Console.WriteLine("What is 'horse' in Te Reo Maori?");
        Console.WriteLine("A: Reme");
        Console.WriteLine("B: Hōiho");
        Console.WriteLine("C: Wheke");
        Console.WriteLine("D: Kau");
        ans = Convert.ToChar(Console.ReadLine());

        while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
        {
            Console.WriteLine("Incorrect, please select only a,b c or d");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'b' || ans == 'B')
        {
            Console.WriteLine("You're correct! Next Question:\n");
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

        //Question 8

        Console.WriteLine("What is 'cow' in Te Reo Maori?");
        Console.WriteLine("A: Pepe");
        Console.WriteLine("B: Kiore");
        Console.WriteLine("C: Wheke");
        Console.WriteLine("D: Kau");
        ans = Convert.ToChar(Console.ReadLine());

        while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
        {
            Console.WriteLine("Incorrect, please select only a,b c or d");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'd' || ans == 'D')
        {
            Console.WriteLine("You're correct! Next Question:\n");
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
    
        Console.WriteLine("What is 'seal' in Te Reo Maori?");
        Console.WriteLine("A: Reme");
        Console.WriteLine("B: Kau");
        Console.WriteLine("C: Hōiho");
        Console.WriteLine("D: Popoiangore");
        ans = Convert.ToChar(Console.ReadLine());

        while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
        {
            Console.WriteLine("Incorrect, please select only a,b c or d");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'd' || ans == 'D')
        {
            Console.WriteLine("You're correct! Next Question:\n");
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
        //User has reached the end of the quiz
        //Shows the user their score
        //Asks user if they wish to repeat
        //Loops the whole quiz if user selects 'y'

        Console.WriteLine("Thank you! You have reached the end.\n");
        Console.WriteLine("Your score is: ");
        TotalScore = score;
        Console.WriteLine(TotalScore);
    
        Console.WriteLine("\nIf you wish to try again, type 'y' or type press any other key to exit. \n");
        option= char.Parse(Console.ReadLine());
    }
        void Level3()
    {
        //Question 11
        Console.WriteLine("\nLevel 3: Expert");
        Console.WriteLine("Topic: New Zealand Trivia\n");
        Console.WriteLine("What colours are on the NZ flag?");
        Console.WriteLine("A: Whero, Kowhai, Ma");
        Console.WriteLine("B: Kahurangi, Ma, Whero");
        Console.WriteLine("C: Karaka, Wheroma, Mangu");
        Console.WriteLine("D: Mangu, Whero, Ma");
        ans = Convert.ToChar(Console.ReadLine());

        while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
        {
            Console.WriteLine("Incorrect, please select only a,b c or d");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'B' || ans == 'b')
        {
            Console.WriteLine("You're correct! Next Question:\n");
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

        Console.WriteLine("What was one of the first animals brought to NZ?");
        Console.WriteLine("A: Kau");
        Console.WriteLine("B: Ngeru");
        Console.WriteLine("C: Kuri");
        Console.WriteLine("D: Kiore");
        ans = Convert.ToChar(Console.ReadLine());

        while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
        {
            Console.WriteLine("Incorrect, please select only a,b c or d");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'b' || ans == 'B')
        {
            Console.WriteLine("You're correct! Next Question:\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect :( Correct answer was 'B'! Cats and Stoats were the first to come to NZ\n");
            if (score > 0)
            {
                score--;
            }
        }

        //Question 13

        Console.WriteLine("What is the capital of NZ?");
        Console.WriteLine("A: Wellington");
        Console.WriteLine("B: Auckland");
        Console.WriteLine("C: Christchurch");
        Console.WriteLine("D: Hamilton");
        ans = Convert.ToChar(Console.ReadLine());

        while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
        {
            Console.WriteLine("Incorrect, please select only a,b c or d");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'a' || ans == 'A')
        {
            Console.WriteLine("You're correct! Next Question:\n");
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

        Console.WriteLine("Which is the Maori names for NZ?");
        Console.WriteLine("A: Aotera");
        Console.WriteLine("B: Aortearoa");
        Console.WriteLine("C: Aotea");
        Console.WriteLine("D: Aotearoa");
        ans = Convert.ToChar(Console.ReadLine());

        while (ans != 'a' && ans != 'A' && ans != 'b' && ans != 'B' && ans != 'C' && ans != 'c' && ans != 'd' && ans != 'D')
        {
            Console.WriteLine("Incorrect, please select only a,b c or d");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'D' || ans == 'd')
        {
            Console.WriteLine("You're correct! Next Question:\n");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect :( Correct answer was 'D' which means 'The land of the cloud'");
            if (score > 0)
            {
                score--;
            }
        }


        //User has reached the end of the quiz
        //Shows the user their score
        //Asks user if they wish to repeat
        //Loops the whole quiz if user selects 'y'

        Console.WriteLine("Thank you! You have reached the end.\n");
        Console.WriteLine("Your score is: ");
        TotalScore = score;
        Console.WriteLine(TotalScore);
    
    Console.WriteLine("\nIf you wish to try again, type 'y' or type press any other key to exit. \n");
    option= char.Parse(Console.ReadLine());
   }
} while (option == 'y' || option == 'Y');
