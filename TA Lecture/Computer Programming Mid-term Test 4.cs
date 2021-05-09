using System;
// 程式說明請參考week8_r09941007
namespace MidtermReview4
{
    enum Decision
    {
        COOPERATE,
        BETRAY
    }
    class Program
    {
        static void Main (string[] args)
        {
            Prisoner A = new Prisoner();
            Prisoner B = new Prisoner();
            Random rnd = new Random();
            int rounds = rnd.Next()%1000+1;
            A.SetSeed("A");
            B.SetSeed("B");
            // Initial Decisions are COOPERATE
            A.SetFRate(5);
            B.SetFRate(2);
            for (int round = 0; round < rounds; round++) {
                Game(ref A, ref B, round);                
            }
        }
        static void ScoreBoard (ref Prisoner a, ref Prisoner b, int round)
        {                    // ^我後來發現這邊寫法有點多此一舉，class作為引數被讀入後，本來就是傳址，不是傳值。故不用ref
            Console.WriteLine("Round {0, -4}: A {1, -9}, score: {2, -4} | B {3, -9}, score: {4, -4}",
                              round, a.LastChoice, a.score, b.LastChoice, b.score);
        }
        static void Game (ref Prisoner a, ref Prisoner b, int round)
        {              // ^我後來發現這邊寫法有點多此一舉，class作為引數被讀入後，本來就是傳址，不是傳值。故不用ref
            switch (a.LastChoice)
            {
                case (Decision.COOPERATE):
                if (b.LastChoice == Decision.COOPERATE)
                {   // win-win
                    a.score += 3;
                    b.score += 3;
                }
                else
                {   // b win
                    b.score += 5;
                }
                break;
                case (Decision.BETRAY):
                if (b.LastChoice == Decision.COOPERATE)
                {   // a win
                    a.score += 5;
                }
                else
                {   // Both Betray
                    a.score += 1;
                    b.score += 1;
                }
                break;
            }
            ScoreBoard(ref a, ref b, round);
            Decision a_choice = a.LastChoice, b_choice = b.LastChoice;
            a.Action(b_choice);
            b.Action(a_choice);
        }// End of void Game
        class Prisoner
        {
            public int score = 0;
            private int ForgiveRate = 0;
            private Random rnd = new Random();
            public Decision LastChoice = Decision.COOPERATE;
            // Initial Decision is COOPERATE,
            // also you can assign it as BETRAY.
            public void SetFRate (int p)
            {
                // forgive rate : p %
                ForgiveRate = p;
            }
            public void SetSeed (string PrisonerName)
            {
                Console.WriteLine("Please input seed of {0}", PrisonerName);
                while (true) {
                    try {
                        int seed = int.Parse(Console.ReadLine());
                        rnd = new Random(seed);
                        break;
                    }
                    catch {
                        Console.WriteLine("Invalid input! Please input seed of {0}", PrisonerName);
                    }
                }
            }
            public void Action (Decision OpponentDecision)
            {
                switch (OpponentDecision)
                {
                    case (Decision.COOPERATE):
                    LastChoice = Decision.BETRAY;
                    break;
                    case (Decision.BETRAY):
                    if ((rnd.Next()%100)<ForgiveRate)
                    {
                        LastChoice = Decision.COOPERATE;
                    }
                    else LastChoice = Decision.BETRAY;
                    break;
                }
            }
        }// End of class Prisoner
    }// End of class Program
}// End of namespace review4
