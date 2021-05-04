using System;
using System.IO;
/* Author: TA of NTU 109-2 EE3031 
 * Contact: r09941007@g.ntu.edu.tw
 * Feel free for using or modifying it!
 */
namespace test
{
    class LibraryDealer
    {
        private string LibraryPath;
        public LibraryDealer(string path)
        {
            this.LibraryPath = path;
            if (LibraryPath[LibraryPath.Length-1]!='\\')
            {// MacOS的路徑應該要把 \\ => 改成 /
                LibraryPath+='\\';
            }
        }
        public string Txt2AsciiString(string filename)
        {// 讀檔案回傳字串
            return File.ReadAllText(this.LibraryPath + filename);
        }
        public void Ascii2Txt(string filename)
        {// 讀字串寫成檔案
            if(!File.Exists(this.LibraryPath+filename))
            {
                Console.WriteLine("{0} does not exist.\nFile will been created.", filename);
            }
            Console.WriteLine("Input \"-1\" as the end of the AsciiArt.\nPaste your AsciiArt below:");
            using(StreamWriter EchoPath = File.CreateText(this.LibraryPath+filename))
            {// 將貼到Terminal上的AsciiArt寫入
                while(true) {
                    string line = Console.ReadLine();
                    if (line == "-1") break;
                    EchoPath.WriteLine(line);
                }
                Console.WriteLine("Your AsciiArt has been saved at {0}", this.LibraryPath+filename);
            }
        }
    }
}
