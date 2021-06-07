using System;
using System.IO;

namespace week16
{
    abstract class WavFormat
    {
        // <properties>
        protected string path;
        protected FileStream stream;
        protected BinaryWriter writer;
        protected int riff;
        protected int wave;
        protected int formatChunkSize;
        protected int headerSize;
        protected int format;
        protected short formatType;
        protected short tracks;
        protected int samplesPerSecond;
        protected short bitsPerSample;
        protected short frameSize;
        protected int bytesPerSecond;
        protected int waveSize;
        protected int data;
        protected int samples;
        protected int dataChunkSize;
        protected int fileSize;

        protected double ampl;
        // </properties>
    }

    class Note
    {
        internal int frequency;
        internal double duration;

        public Note(int frequency, double duration)
        {
            this.frequency = frequency;
            this.duration = duration;
        }
    }

    public abstract class ArtificialWaveForm
    {
        protected double fundFreq;
        public abstract double WaveForm(double time, double fixer);
    }

    public class ADSR
    {
        private double aSlope;
        private double dSlope;
        private double rSlope;
        private double dTime;
        private double sTime;
        private double rTime;
        private double sAmp;

        public ADSR(double dTime, double sTime, double rTime, double totTime, double sAmp)
        {
            this.dTime = dTime;
            this.sTime = sTime;
            this.rTime = rTime;
            this.sAmp = sAmp;
            aSlope = 1.0 / dTime;
            dSlope = (sAmp - 1) / (sTime - dTime);
            rSlope = -sAmp / (totTime - rTime);
        }

        public double Filter(double time)
        {
            // There are many kinds of ADSR filter
            if (time < dTime) return aSlope * time;
            else if (time < sTime) return 1 - dSlope * (time - dTime);
            else if (time < rTime) return sAmp;
            else return sAmp + rSlope * (time - rTime);
        }
    }
}