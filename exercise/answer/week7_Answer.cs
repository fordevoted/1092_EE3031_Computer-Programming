using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            // Exercise_Easy.Program.Answer();
            Exercise_Medium.Program.Answer();
            // Exercise_Hard.Program.Answer();
            Console.Read();

        }
    }
}


namespace Exercise_Easy
{
    class Program
    {
        public static void Answer()
        {
            Console.WriteLine("Please Input NX: ");
            int NX = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Please Input NY: ");
            int NY = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Please Input V0: ");
            double v0 = double.Parse(Console.ReadLine());

            // params
            const double g = 0.1;
            int t= 0;
            
            // init screen
            char[,] screen = new char[NY, NX];
            for(int i =0; i< NY; ++i)
            {
                for (int j = 0; j < NX; ++j)
                {
                    screen[i, j] = ' ';
                }
            }
            
            while(true)
            {
                
                int x = HorizontalDistance(v0, t);
                int y = VerticalDistance(g, t);
                if (x >= NX || y >= NY)
                {
                    break;
                }
                updateScreen('o', x, y, NX, NY, screen);
                t++;
                Thread.Sleep(100);
            }
            Console.WriteLine("Reach ground at {0}'s ", t);
        }


        static void updateScreen(char symbol, int x, int y, int NX, int NY,  char[,] screen)
        {
            Console.Clear();
            screen[y, x] = symbol;
            for (int i = 0; i < NY; ++i)
            {
                for (int j = 0; j < NX; ++j)
                {
                    Console.Write(screen[i, j]);
                }
                Console.WriteLine();
            }
            
        }
        
        static int HorizontalDistance(double v0, int t)
        {
            double x = v0 * t;
            return (int) x;
        }

        static int VerticalDistance(double g, int t)
        {
            double y = 0.5 * g * t * t;
            return (int) y;
        }
    }
}
namespace Exercise_Medium
{
    class Program
    {
        public static void Answer()
        {
            Console.WriteLine("Please Input NX: ");
            int NX = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Please Input NY: ");
            int NY = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Please Input player velocity V: ");
            double v = double.Parse(Console.ReadLine());
            
            Random random = new Random();
            double v0 = random.NextDouble() * 4.5 + 0.5;
            
            // params
            double u1 = 1.0-random.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0-random.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                                   Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            int ballInitY = (int)((3/4*NY) + (1/12)*NY * randStdNormal);
            
            const double g = 0.1;
            int t= 0;
            
            // init screen
            char[,] screen = new char[NY, NX];
            for(int i =0; i< NY; ++i)
            {
                for (int j = 0; j < NX; ++j)
                {
                    screen[i, j] = ' ';
                }
            }
            
            while(true)
            {
                
                
                int x = HorizontalDistance(v0, t);
                int y = VerticalDistance(g, t) + ballInitY;
                int xPlayer = HorizontalDistance(v, t);
                
                
                
                if (x >= NX || y >= NY || xPlayer >= NX)
                {
                    if (catchBall(x, xPlayer))
                    {
                        Console.WriteLine("Catch the Ball!");
                    }
                    else
                    {
                        Console.WriteLine("Cannot Catch the Ball!");
                    }

                    break;
                }
                updateScreen('o', x, y, NX, NY, screen);
                updateScreen('I', xPlayer, NY-1, NX, NY, screen);

                t++;
                Thread.Sleep(100);
            }
        }
        
        static void updateScreen(char symbol, int x, int y, int NX, int NY,  char[,] screen)
        {
            Console.Clear();
            screen[y, x] = symbol;
            for (int i = 0; i < NY; ++i)
            {
                for (int j = 0; j < NX; ++j)
                {
                    Console.Write(screen[i, j]);
                }
                Console.WriteLine();
            }
            
        }
        
        static int HorizontalDistance(double v0, int t)
        {
            double x = v0 * t;
            return (int) x;
        }

        static int VerticalDistance(double g, int t)
        {
            double y = 0.5 * g * t * t;
            return (int) y;
        }
        
        static bool catchBall(int xBall, int xPlayer)
        {
            if (xPlayer>= xBall)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
namespace  Exercise_Hard
{
    class Program
    {
         public static void Answer()
        {

            Console.WriteLine("Please Input NX: ");
            int NX = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Please Input NY: ");
            int NY = Int32.Parse(Console.ReadLine());
            
            
            Random random = new Random();
            double v0 = random.NextDouble() * 3.5 + 0.5;
            double u1 = 1.0-random.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0-random.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                                   Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            int ballInitY = (int)((3/4*NY) + (1/12)*NY * randStdNormal);
            
            
            // params
            const double g = 0.1;
            int t= 0;
            int player_x = 0;
            int player_y = NY - 1;
            char act = ' ';
            
            // init screen
            char[,] screen = new char[NY, NX];
            for(int i =0; i< NY; ++i)
            {
                for (int j = 0; j < NX; ++j)
                {
                    screen[i, j] = ' ';
                }
            }
            
            while(true)
            {

                if (act == 'w')
                {
                    player_y += 1;
                    act = ' ';
                }else if (act == 's')
                {
                    act = ' ';}
                else
                {
                    Console.WriteLine("player action: ");
                    act = Console.ReadLine()[0];
                    if (act == 'W' || act == 'w')
                    {
                        player_y -= 1;
                        act = 'w';
                    }else if (act == 'D' || act == 'd')
                    {
                        player_x += 1;
                    }else if (act == 'A' || act == 'a')
                    {
                        player_x -= 1;
                        if (player_x <= 0)
                        {
                            player_x = 0;
                        }
                    }else if (act == 'S' || act == 's')
                    {
                        player_x += 2;
                        act = 's';
                    }
                    else if (act == ' ')
                    {
                        
                    }
                    else
                    {
                        continue;
                    }    
                }
                
                int x = HorizontalDistance(v0, t);
                int y = VerticalDistance(g, t) + ballInitY;
                
                if (x >= NX || y >= NY || player_x >= NX)
                {
                    if (catchBall(x, player_x, y, player_y))
                    {
                        if (act == 's')
                        {
                            Console.Write("Nice play! ");
                        }
                        Console.WriteLine("Out.");
                    }
                    else
                    {
                        if (x >= NX)
                        {
                            Console.WriteLine("HomeRun!!");
                        }
                        else
                        {
                            Console.WriteLine("Hit!");
                        }


                    }

                    break;
                }
                updateScreen('o', x, y, NX, NY, screen);
                updateScreen('I', player_x, player_y, NX, NY, screen);

                screen[y, x] = ' ';
                screen[player_y, player_x] = ' ';
                t++;
                Thread.Sleep(100);
            }
        }
         
         static void updateScreen(char symbol, int x, int y, int NX, int NY,  char[,] screen)
         {
             Console.Clear();
             screen[y, x] = symbol;
             for (int i = 0; i < NY; ++i)
             {
                 for (int j = 0; j < NX; ++j)
                 {
                     Console.Write(screen[i, j]);
                 }
                 Console.WriteLine();
             }
            
         }
        
         static int HorizontalDistance(double v0, int t)
         {
             double x = v0 * t;
             return (int) x;
         }

         static int VerticalDistance(double g, int t)
         {
             double y = 0.5 * g * t * t;
             return (int) y;
         }
        
         static bool catchBall(int xBall, int xPlayer, int yBall, int yPlayer)
         {
             if (xPlayer>= xBall)
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }
    }

}




