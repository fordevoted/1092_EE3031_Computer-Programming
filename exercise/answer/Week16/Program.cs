using System;
using System.IO;

namespace week16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Easy();
            //Medium();
            //Hard_ModulateThePitch();
            Hard_ModulateTheBPM();
        }
        public static void Easy()
        {
            string path = @"C:\Users\TA\workshop\week16\sample\Megalovania\";
            string tonesFile = "tone.txt";
            string durationsFile = "duration.txt";
            string[] tones = File.ReadAllText($"{path}{tonesFile}")
                .Replace("\n", "").Replace("\r", "").Split(' ');
            string[] durations = File.ReadAllText($"{path}{durationsFile}")
                .Replace("\n", "").Replace("\r", "").Split(' ');
            int len = tones.Length;
            Console.WriteLine("Megalovania");
            Console.WriteLine("tone | duration");
            for (int i = 0; i < len; i++)
                Console.WriteLine(" {0,-3} | {1,-4}", tones[i], durations[i]);
            Console.ReadLine();
        }
        public static void Medium()
        {
            // Case: File Not found
            MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Dejavu\", "GodIsAGirl.txt", "DamDadiDo.txt", "out0.wav");

            // Case: Path doesn;t exist
            MakeMusic.Wav(@"C:\Users\TA\workshop\week9999\sample\Sample\Wily'sCastle\", "tone.txt", "duration.txt", "out1.wav", 1);

            // Case: Duration and tone are not .txt format.
            MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Megalovania\", "tone.dat", "duration.jpg", "out2.wav", 2);
            
            // Case: Output music file are not .wav format.
            MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\MagicForest\", "tone.txt", "duration.txt", "out3.mp3", 3);
            Console.ReadLine();
        }
        public static void Hard_ModulateThePitch()
        {
            string tones = "";
            using (StreamReader sr = new StreamReader(@"C:\Users\TA\workshop\week16\sample\Megalovania\tone.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] pitchs = line.Split(" ");
                    for (int i = 0; i < pitchs.Length; i++)
                    {
                        if (pitchs[i]=="") 
                        {
                            tones += "\n";
                        }
                        else
                        {
                            string pitch = (pitchs[i])[pitchs[i].Length-1]=='b'?pitchs[i].Replace("b",""):$"{pitchs[i]}#";
                            tones += $"{pitch} ";
                        }
                    }
                }
                tones = tones.Remove(tones.Length-1);
            }
            using (StreamWriter sw = new StreamWriter(@"C:\Users\TA\workshop\week16\sample\Megalovania\newTone.txt"))
            {
                sw.Write(tones);
            }
            MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Megalovania\", "newTone.txt", "duration.txt", "newMegalovania.wav", 1);
        }

        public static void Hard_ModulateTheBPM()
        {
            string durations = "";
            using (StreamReader sr = new StreamReader(@"C:\Users\TA\workshop\week16\sample\Wily'sCastle\duration.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] times = line.Split(" ");
                    for (int i = 0; i < times.Length; i++)
                    {
                        if (times[i]=="") 
                        {
                            durations += "\n";
                        }
                        else
                        {
                            double time = Double.Parse(times[i]) / 1.5;
                            durations += $"{time.ToString()} ";
                        }
                    }
                }
                durations = durations.Remove(durations.Length-1);
            }
            using (StreamWriter sw = new StreamWriter(@"C:\Users\TA\workshop\week16\sample\Wily'sCastle\newDuration.txt"))
            {
                sw.Write(durations);
            }
            MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Wily'sCastle\", "tone.txt", "newDuration.txt", "newWily'sCastle.wav", 1);
        }
    }
}
