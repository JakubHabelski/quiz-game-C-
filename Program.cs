using System;

class Question
{
    string quest, ans_a, ans_b, ans_c, ans_d;
    char user_ans, corr_ans;
    static int score;

    public Question(string question, string answerA, string answerB, string answerC, string answerD, char correctAnswer)
    {
        quest = question;
        ans_a = answerA;
        ans_b = answerB;
        ans_c = answerC;
        ans_d = answerD;
        corr_ans = correctAnswer;
    }

    public void LoadQuest()
    {
        Console.WriteLine(quest);
        Console.WriteLine("A: "+ans_a);
        Console.WriteLine("B: "+ans_b);
        Console.WriteLine("C: "+ans_c);
        Console.WriteLine("D: "+ans_d);
    }
    public void check_ans()
    {
        while (user_ans != 'A' && user_ans != 'B' && user_ans != 'C' && user_ans != 'D')
        {
            Console.WriteLine("What is your answer: ");
            string input = Console.ReadLine();
            user_ans = Convert.ToChar(input);
            user_ans = char.ToUpper(user_ans);
        }
        if (corr_ans == user_ans)
        {
            Console.WriteLine("Correct");
            score++;
        }
        else
        {
            Console.WriteLine("InCorrect");
        }

    }

    public void getScore()
    {
        Console.WriteLine("Your score: " + score);
    }

}

class HelloWorld
{
    static void Main()
    {
        Question[] questions = new Question[15];
        questions[0] = new Question("Who holds the record for the most Formula 1 World Championships?", "Michael Schumacher", "Lewis Hamilton", "Ayrton Senna", "Sebastian Vettel", 'B');
        questions[1] = new Question("Which team has the most constructors' championships in Formula 1?", "Mercedes", "Ferrari", "McLaren", "Red Bull Racing", 'B');
        questions[2] = new Question("In which year did Formula 1 first hold a race?", "1930", "1950", "1960", "1970", 'B');
        questions[3] = new Question("What is the name of the street circuit in Monaco where the Monaco Grand Prix is held?", "Monte Carlo Circuit", "Monaco Street Circuit", "Circuit de Monaco", "Monte Carlo Street Circuit", 'C');
        questions[4] = new Question("Which driver has the most Grand Prix victories in Formula 1 history?", "Ayrton Senna", "Lewis Hamilton", "Michael Schumacher", "Sebastian Vettel", 'B');
        questions[5] = new Question("What is the term for the drag-reduction system that allows Formula 1 cars to reduce aerodynamic drag on straights?", "Turbo Boost", "Wing Flaps", "DRS (Drag Reduction System)", "Speed Thrust", 'C');
        questions[6] = new Question("Which country hosts the first race of the Formula 1 season?", "Australia", "Monaco", "Italy", "Spain", 'A');
        questions[7] = new Question("Which driver is known as 'The Flying Finn'?", "Kimi Räikkönen", "Valtteri Bottas", "Mika Häkkinen", "Nico Rosberg", 'A');
        questions[8] = new Question("How many laps are there in a typical Formula 1 race?", "50", "60", "70", "80", 'B');
        questions[9] = new Question("Which Formula 1 team is based in Milton Keynes, England?", "Ferrari", "Red Bull Racing", "Mercedes", "McLaren", 'B');
        questions[10] = new Question("Which driver won the 2020 Formula 1 World Championship?", "Sebastian Vettel", "Max Verstappen", "Lewis Hamilton", "Valtteri Bottas", 'C');
        questions[11] = new Question("What is the term for the highest level of Formula 1 competition?", "Formula 1 World Series", "Formula 1 Grand Prix", "Formula 1 Premier", "Formula 1 World Championship", 'D');
        questions[12] = new Question("Which circuit is known for its 'Eau Rouge' corner, a famous and challenging high-speed turn?", "Silverstone Circuit", "Circuit of the Americas", "Spa-Francorchamps Circuit", "Suzuka Circuit", 'C');
        questions[13] = new Question("What does DNF stand for in Formula 1?", "Did Not Finish", "Driver Not Fast", "Disqualified Not Forgiven", "Driver No Formula", 'A');
        questions[14] = new Question("Which driver is known for his nickname 'Iceman'?", "Kimi Räikkönen", "Sebastian Vettel", "Lewis Hamilton", "Max Verstappen", 'A');

        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].LoadQuest();
            questions[i].check_ans();
            if (i == questions.Length - 1)
            {
                questions[i].getScore();
            }
        }

    }
}