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
        static void Easy()
        {
            //Token peko = new Token(ArtLibrary.Pekora, "Usada Pekora");
            // ---上面是用AsciiArt.cs的方法
            // ---下面是用讀取txt的方法
            LibraryDealer ld = new LibraryDealer(@"C:\Users\TA\EE3031\week11_ans\AsciiArt");
            Token peko = new Token(ld.Txt2AsciiString("Pekora.txt"), "Usada Pekora");
            // ---
            peko.ShowInfo();
        }
        static void Medium()
        {
            //Token peko = new Token(ArtLibrary.Pekora, "Usada Pekora");
            //Token miko = new Token(ArtLibrary.Mikochi, "Sakura Miko");
            // ---上面是用AsciiArt.cs的方法
            // ---下面是用讀取txt的方法
            LibraryDealer ld = new LibraryDealer(@"C:\Users\TA\EE3031\week11_ans\AsciiArt");
            Token peko = new Token(ld.Txt2AsciiString("Pekora.txt"), "Usada Pekora");
            Token miko = new Token(ld.Txt2AsciiString("Mikochi.txt"), "Sakura Miko");
            // ---
            Console.WriteLine("{0}'s status is", peko.Name);
            peko.status.ShowStatus();
            Console.WriteLine("--------------------");
            Console.WriteLine("{0}'s status is", miko.Name);
            miko.status.ShowStatus();
            Console.WriteLine("--------------------");
            BigWar(peko, miko);
            // Because classes are reference types, someone's Hp becomes to 0 now.
            void BigWar(Token P1, Token P2)
            {// PekoMiko Daisensou
                /* 是說關於RPG中，物件間的對戰，
                 * 同學可以盡情發揮創意，
                 * 利用添加不同的properties給物件，
                 * 來自創各種遊戲的戰鬥系統。
                 * 例如：Status若再加入int spd 代表腳色的速度能力值，
                 * 那我們這邊BigWar函式，就可以根據物件的spd決定誰先攻。
                 */
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
