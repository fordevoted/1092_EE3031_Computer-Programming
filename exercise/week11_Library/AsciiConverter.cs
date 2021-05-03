using System;
/* Author: TA of NTU 109-2 EE3031 
 * Contact: r09941007@g.ntu.edu.tw
 * Feel free for using or modifying it!
 */
namespace test
{
    static class Tools
    {
        static public string Ascii2String()
        {
            string str = "";
            while(true) {
                string line = Console.ReadLine();
                if (line == "-1") break;
                str += line;
                str += '\n';
            }
            return str;
        }
        static public void Ascii2StrDeclare()
        {// This function is for get an AsciiArt and print the declare format
            Console.WriteLine("How many tab before each substring?");
            string str1 = "", str2 = "";
            int NumOfIndent = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumOfIndent; i++) str2 += "    ";
            str2 += '\"';
            Console.WriteLine("Now, you can paste the AsciiArt you want to declare as a string:(input\"-1\"as the finish of AsciiArt)");
            while(true) {
                string line = Console.ReadLine();
                if (line == "-1") break;
                str1 += line;
                str1 += '\n';
            }
            foreach (char character in str1) {
                switch (character)
                {
                    case '\n':
                    str2 += "\\n\"+\n";
                    for (int i = 0; i < NumOfIndent; i++) str2 += "    ";
                    str2 += "\"";
                    break;
                    case '\\':
                    str2 += "\\\\";
                    break;
                    case '\"':
                    str2 += "\\\"";
                    break;
                    default:
                    str2 += character;
                    break;
                }
            }
            Console.WriteLine("Here's your ascii art declaration !");
            Console.WriteLine(str2);
        }
        
    }
}
