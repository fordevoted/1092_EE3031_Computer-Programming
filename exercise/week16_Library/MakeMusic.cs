namespace week16
{
    public class MakeMusic
    {
        public static void Wav(string path, string toneFile, string durationFile, string outputFilename, int type = 0)
        {
            WavGenerator hnd = new WavGenerator(path);
            hnd.Read(toneFile, durationFile);
            hnd.Write(outputFilename, type);
        }
    }
}