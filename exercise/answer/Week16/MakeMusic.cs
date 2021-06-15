using System;
using System.IO;
namespace week16
{
    public class MakeMusic
    {
        // Medium
        public static void Wav(string path, string toneFile, string durationFile, string outputFilename, int type = 0)
        {
            bool toneFileExist = File.Exists(path+toneFile);
            bool durationFileExist = File.Exists(path+durationFile);
            bool pathExist = Directory.Exists(path);
            bool validToneFormat = (Path.GetExtension(path+toneFile) == ".txt");
            bool validDurationFormat = (Path.GetExtension(path+durationFile) == ".txt");
            bool validOutputFormat = (Path.GetExtension(outputFilename) == ".wav");
            try
            {
                if (!(validToneFormat && validDurationFormat))
                {//Duration and tone are not .txt format.
                    throw new InputFileFormatException(String.Format("{0}{1}", validToneFormat?"":$"{toneFile}, ", validDurationFormat?"":durationFile));
                }
                else if (!pathExist)
                {//Directory is not exist.
                    throw new DirectoryNotFoundException(path);
                }
                else if (!(toneFileExist && durationFileExist))
                {//File not found.
                    throw new FileNotFoundException(String.Format("{0}{1}", toneFileExist?"":$"{toneFile}, ", durationFileExist?"":durationFile));
                }
                else if (!validOutputFormat)
                {//Output file is not .wav format.
                    throw new OutputFileFormatException(outputFilename);
                }
                WavGenerator hnd = new WavGenerator(path);
                hnd.Read(toneFile, durationFile);
                hnd.Write(outputFilename, type);
            }
            catch (FileNotFoundException e)
            {
                e.Print();
            }
            catch (DirectoryNotFoundException e)
            {
                e.Print();
            }
            catch (InputFileFormatException e)
            {
                e.Print();
            }
            catch (OutputFileFormatException e)
            {
                e.Print();
            }
        }
        public class FileNotFoundException : Exception
        {
            private string filename;
            public FileNotFoundException(string whichFile)
            {
                this.filename = whichFile;
            }
            public void Print()
            {
                Console.WriteLine($"File Not found. ({filename})");
            }
        }
        public class DirectoryNotFoundException : Exception
        {
            private string path;
            public DirectoryNotFoundException(string path)
            {
                this.path = path;
            }
            public void Print()
            {
                Console.WriteLine($"Directory is not exist. (path)");
            }
        }
        public class InputFileFormatException : Exception
        {
            private string filename;
            public InputFileFormatException(string whichFile)
            {
                this.filename = whichFile;
            }
            public void Print()
            {
                Console.WriteLine($"Input files must be .txt files. ({filename})");
            }
        }
        public class OutputFileFormatException : Exception
        {
            private string filename;
            public OutputFileFormatException(string whichFile)
            {
                this.filename = whichFile;
            }
            public void Print()
            {
                Console.WriteLine($"Output file must be .wav format. ({filename})");
            }
        }
    }
}