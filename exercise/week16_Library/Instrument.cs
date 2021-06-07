using System;

namespace week16
{
    public class Violin : ArtificialWaveForm
    {
        public Violin(double f0)
        {
            this.fundFreq = f0;
        }

        public override double WaveForm(double time, double phase)
        {
            return 1.0 / 2.57832 * (
                Math.Sin(time * 1.0 * this.fundFreq * 2.0 * Math.PI + 101 * Math.PI / 180 + phase) * 2.189 +
                Math.Sin(time * 2.0 * this.fundFreq * 2.0 * Math.PI + 100 * Math.PI / 180 + phase) * 1.256 +
                Math.Sin(time * 3.0 * this.fundFreq * 2.0 * Math.PI - 169 * Math.PI / 180 + phase) * 0.459 +
                Math.Sin(time * 4.0 * this.fundFreq * 2.0 * Math.PI - 144 * Math.PI / 180 + phase) * 0.182 +
                Math.Sin(time * 5.0 * this.fundFreq * 2.0 * Math.PI - 132 * Math.PI / 180 + phase) * 0.161 +
                Math.Sin(time * 6.0 * this.fundFreq * 2.0 * Math.PI + 018 * Math.PI / 180 + phase) * 0.016 +
                Math.Sin(time * 7.0 * this.fundFreq * 2.0 * Math.PI + 176 * Math.PI / 180 + phase) * 0.086 +
                Math.Sin(time * 8.0 * this.fundFreq * 2.0 * Math.PI - 116 * Math.PI / 180 + phase) * 0.024 +
                Math.Sin(time * 9.0 * this.fundFreq * 2.0 * Math.PI + 012 * Math.PI / 180 + phase) * 0.011 +
                Math.Sin(time * 10.0 * this.fundFreq * 2.0 * Math.PI + 176 * Math.PI / 180 + phase) * 0.020);
        }
    }

    public class Flute : ArtificialWaveForm
    { // fail sound not good
        public Flute(double f0)
        {
            this.fundFreq = f0;
        }

        public override double WaveForm(double time, double phase)
        {
            return 1.0 / 1.042113 * (
                Math.Sin(time * 1.0 * this.fundFreq * 2.0 * Math.PI + 167 * Math.PI / 180 + phase) * 1.000 +
                Math.Sin(time * 2.0 * this.fundFreq * 2.0 * Math.PI - 025 * Math.PI / 180 + phase) * 0.172 +
                Math.Sin(time * 3.0 * this.fundFreq * 2.0 * Math.PI - 108 * Math.PI / 180 + phase) * 0.069 +
                Math.Sin(time * 4.0 * this.fundFreq * 2.0 * Math.PI - 161 * Math.PI / 180 + phase) * 0.179 +
                Math.Sin(time * 5.0 * this.fundFreq * 2.0 * Math.PI + 061 * Math.PI / 180 + phase) * 0.124 +
                Math.Sin(time * 6.0 * this.fundFreq * 2.0 * Math.PI - 162 * Math.PI / 180 + phase) * 0.046 +
                Math.Sin(time * 7.0 * this.fundFreq * 2.0 * Math.PI - 157 * Math.PI / 180 + phase) * 0.045 +
                Math.Sin(time * 8.0 * this.fundFreq * 2.0 * Math.PI + 138 * Math.PI / 180 + phase) * 0.026 +
                Math.Sin(time * 9.0 * this.fundFreq * 2.0 * Math.PI + 000 * Math.PI / 180 + phase) * 0.004 +
                Math.Sin(time * 10.0 * this.fundFreq * 2.0 * Math.PI + 000 * Math.PI / 180 + phase) * 0.007 +
                Math.Sin(time * 11.0 * this.fundFreq * 2.0 * Math.PI + 129 * Math.PI / 180 + phase) * 0.013 +
                Math.Sin(time * 12.0 * this.fundFreq * 2.0 * Math.PI - 163 * Math.PI / 180 + phase) * 0.015);
        }
    }

    public class Piano : ArtificialWaveForm
    {
        public Piano(double f0)
        {
            this.fundFreq = f0;
        }

        public override double WaveForm(double time, double totTime)
        {
            double amp = 0.6 * Math.Sin(time * 1.0 * this.fundFreq * 2.0 * Math.PI) ;
            amp += 0.4 * Math.Sin(time * 2.0 * this.fundFreq * 2.0 * Math.PI) ;
            amp += amp * amp * amp;
            //amp *= 1 + 16 * time * Math.Pow(Math.E, -6 * time / 1000);
            return amp;
        }
    }
}