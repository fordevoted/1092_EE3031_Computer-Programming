using System;

namespace week11_ans
{
    class Program
    {
        static void Main(string[] args)
        {
            Easy();
            Medium();
            Hard();
            Console.ReadLine();
        }
        static void Easy() // Build a character with ascii art
        {
            //Token peko = new Token(ArtLibrary.Pekora, "Usada Pekora");
            // or you can use the LibraryDealer like:
            LibraryDealer ld = new LibraryDealer(@"C:\Users\clay0\EE3031\week11_ans\AsciiArt");
            Token peko = new Token(ld.Txt2AsciiString("Pekora.txt"), "Usada Pekora");
            peko.ShowInfo();
        }
        static void Medium()
        {
            //Token peko = new Token(ArtLibrary.Pekora, "Usada Pekora");
            //Token miko = new Token(ArtLibrary.Mikochi, "Sakura Miko");
            // Or you can use the LibraryDealer like:
            LibraryDealer ld = new LibraryDealer(@"C:\Users\clay0\EE3031\week11_ans\AsciiArt");
            Token peko = new Token(ld.Txt2AsciiString("Pekora.txt"), "Usada Pekora");
            Token miko = new Token(ld.Txt2AsciiString("Mikochi.txt"), "Sakura Miko");
            Console.WriteLine("{0}'s status is", peko.Name);
            peko.status.ShowStatus();
            Console.WriteLine("--------------------");
            Console.WriteLine("{0}'s status is", miko.Name);
            miko.status.ShowStatus();
            Console.WriteLine("--------------------");
            BigWar(peko, miko);
            // Because classes are reference types, someone's Hp becomes to 0 now.
            void BigWar(Token P1, Token P2)
            {
                while(true)
                {
                    P2.Defence(P1.Attack());
                    if(P2.status.Hp <= 0)
                    {
                        Console.WriteLine("K.O.\n{0}\n{1} is winner", P1.Art, P1.Name);
                        break;
                    }
                    Console.WriteLine();
                    P1.Defence(P2.Attack());
                    if(P1.status.Hp <= 0)
                    {
                        Console.WriteLine("K.O.\n{0}\n{1} is winner", P2.Art, P2.Name);
                        break;
                    }
                    Console.WriteLine("--------------------");
                }
            }// Big War
        }// Medium
        static void Hard()
        {
            Enemy boss = new Enemy(ArtLibrary.Bulbasaur, "Bulbasaur", "種子種子!");
            //Enemy boss = new Enemy(ArtLibrary.Squirtle, "Squirtle", "傑尼傑尼!");
            boss.ShowInfo();
        }
    }
}
