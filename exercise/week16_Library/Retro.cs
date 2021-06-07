using System;

namespace week16
{
    public class Sin : ArtificialWaveForm
    {
        public Sin(double f0)
        {
            this.fundFreq = f0;
        }

        public override double WaveForm(double time, double phase)
        {
            return Math.Sin(time * this.fundFreq * 2.0 * Math.PI + phase);
        }
    }

    public class Square : ArtificialWaveForm
    {
        public Square(double f0)
        {
            this.fundFreq = f0;
        }

        public override double WaveForm(double time, double phase)
        {
            return 1.0 / 1.29468 * (
                Math.Sin(time * 1.0 * this.fundFreq * 2.0 * Math.PI + phase) +
                Math.Sin(time * 3.0 * this.fundFreq * 2.0 * Math.PI + phase) / 3 +
                Math.Sin(time * 5.0 * this.fundFreq * 2.0 * Math.PI + phase) / 5 +
                Math.Sin(time * 7.0 * this.fundFreq * 2.0 * Math.PI + phase) / 7);
        }
    }

    public class Triangle : ArtificialWaveForm
    {
        public Triangle(double f0)
        {
            this.fundFreq = f0;
        }

        public override double WaveForm(double time, double phase)
        {
            return 1.0 / 1.08237 * (
                Math.Sin(time * 1.0 * this.fundFreq * 2.0 * Math.PI + phase) -
                Math.Sin(time * 3.0 * this.fundFreq * 2.0 * Math.PI + phase) / 9 +
                Math.Sin(time * 5.0 * this.fundFreq * 2.0 * Math.PI + phase) / 25 -
                Math.Sin(time * 7.0 * this.fundFreq * 2.0 * Math.PI + phase) / 49);
        }
    }

    public class Sawtooth : ArtificialWaveForm
    {
        public Sawtooth(double f0)
        {
            this.fundFreq = f0;
        }

        public override double WaveForm(double time, double phase)
        {
            return 1.0 / 1.44338 * (
                Math.Sin(time * 1.0 * this.fundFreq * 2.0 * Math.PI + phase) / -1 +
                Math.Sin(time * 2.0 * this.fundFreq * 2.0 * Math.PI + phase) / 2 +
                Math.Sin(time * 3.0 * this.fundFreq * 2.0 * Math.PI + phase) / -3 +
                Math.Sin(time * 4.0 * this.fundFreq * 2.0 * Math.PI + phase) / 4);
        }
    }
}