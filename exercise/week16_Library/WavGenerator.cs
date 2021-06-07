using System;
using System.IO;
using System.Collections.Generic;

namespace week16
{
    class WavGenerator : WavFormat
    {
        private List<Note> _notes;
        private int _numOfData;

        public WavGenerator(string path)
        {
            this.path = path;
            this.riff = 0x46464952;
            this.wave = 0x45564157;
            this.formatChunkSize = 16;
            this.headerSize = 8;
            this.format = 0x20746D66;
            this.formatType = 1;
            this.tracks = 1;
            // 音樂解析度 44100 = 一"秒"有44100個點
            this.samplesPerSecond = 44100;
            this.bitsPerSample = 16;
            this.frameSize = (short) (tracks * ((bitsPerSample + 7) / 8));
            this.bytesPerSecond = samplesPerSecond * frameSize;
            this.waveSize = 4;
            this.data = 0x61746164;
            // ampl 是震幅，代表音樂的大小聲，不要設太大 會爆音
            this.ampl = 4000;
            this._notes = new List<Note>();
        }
        // </Constructor>

        // <Method>
        public void Write(string filename, int style = 0)
        {
            // 創音樂檔
            this.stream = new FileStream($"{this.path}{filename}", FileMode.Create);
            this.writer = new BinaryWriter(this.stream);
            double timeStep = 1.0 / this.samplesPerSecond;
            writer.Write(this.riff);
            writer.Write(this.fileSize);
            writer.Write(this.wave);
            writer.Write(this.format);
            writer.Write(this.formatChunkSize);
            writer.Write(this.formatType);
            writer.Write(this.tracks);
            writer.Write(this.samplesPerSecond);
            writer.Write(this.bytesPerSecond);
            writer.Write(this.frameSize);
            writer.Write(this.bitsPerSample);
            writer.Write(this.data);
            writer.Write(this.dataChunkSize);
            // 開始寫入音樂
            double previousPhase = 0;
            for (int i = 0; i < this._numOfData; i++)
            {
                double freq = this._notes[i].frequency;
                double time = this._notes[i].duration / 1000;
                // 若freq = 0 代表了休止符，就沒有震幅
                int ampFixer = (freq == 0) ? 0 : 1;
                // 選擇樂器 (音色、波形) 可以於 WaveForm.cs 中自己新增樂器
                // Violin myInstrument = new Violin(freq);
                Sin sin = new Sin(freq);
                Triangle tri = new Triangle(freq);
                Square square = new Square(freq);
                Sawtooth sawtooth = new Sawtooth(freq);
                Piano piano = new Piano(freq);
                Flute flute = new Flute(freq);
                Violin violin = new Violin(freq);
                // adsr filter
                ADSR adsr  = new ADSR(0.2 * time, 0.0 * time, 0.4 * time, time, 1.0);
                ADSR adsr2  = new ADSR(0.1 * time, 0.0 * time, 0.2 * time, time, 1.0);
                for (double timePass = 0; timePass < time; timePass += timeStep)
                {
                    short s = 0;
                    switch (style)
                    {// some type of mixer
                        case 1:
                        s = (short) (adsr.Filter(timePass) *
                                       (0.7 * ampFixer * ampl * sin.WaveForm(timePass, previousPhase) +
                                        0.3 * ampFixer * ampl * tri.WaveForm(timePass, previousPhase)));
                        break;
                        case 2:
                        s = (short) (adsr.Filter(timePass) *
                                       (0.7 * ampFixer * ampl * sawtooth.WaveForm(timePass, previousPhase) +
                                        0.7 * ampFixer * ampl * sin.WaveForm(timePass, previousPhase)));
                        break;
                        case 3:
                        s = (short) (adsr.Filter(timePass) * ampFixer * ampl * piano.WaveForm(timePass, previousPhase));
                        break;
                        case 4:
                        s = (short) (adsr.Filter(timePass) * ampFixer * ampl * flute.WaveForm(timePass, previousPhase));
                        break;
                        case 5:
                        s = (short) (adsr2.Filter(timePass) * ampFixer * ampl * square.WaveForm(timePass, previousPhase));
                        break;
                        default:
                        s = (short) (adsr.Filter(timePass) * ampFixer * ampl * violin.WaveForm(timePass, previousPhase));
                        break;
                    }
                    writer.Write(s);
                }

                // use phase shift to reduce noise between each tone
                previousPhase += 2 * Math.PI * freq * time;
                while (previousPhase > 2 * Math.PI) previousPhase -= 2 * Math.PI;
            }

            writer.Close();
            stream.Close();
        }

        public void Read(string tonesFile, string durationsFile)
        {
            // Read 將會讀兩個txt, 並將txt中的資料(tone & duration)存到List中
            string[] tones = File.ReadAllText($"{this.path}{tonesFile}")
                .Replace("\n", "").Replace("\r", "").Split(' ');
            string[] durations = File.ReadAllText($"{this.path}{durationsFile}")
                .Replace("\n", "").Replace("\r", "").Split(' ');
            if (tones.Length != durations.Length) return;
            this._numOfData = tones.Length;
            Dictionary<string, int> tone2Freq = new Dictionary<string, int>
            {
                {"D''b", 1108}, {"D''", 1174}, 
                {"'Bb", 233}, {"'B", 247}, {"Fb", 330}, {"C'b", 988}, {"C''", 1047}, {"F'b", 660}, 
                {"0", 0}, {"C", 262}, {"C#", 277}, {"Db", 277}, {"D", 294}, {"D#", 311},
                {"Eb", 311}, {"E", 330}, {"F", 349}, {"F#", 370}, {"Gb", 370}, {"G", 392},
                {"G#", 415}, {"Ab", 415}, {"A", 440}, {"A#", 466}, {"Bb", 466}, {"B", 494},
                {"C'", 524}, {"C'#", 554}, {"D'b", 554}, {"D'", 588}, {"D'#", 622},
                {"E'b", 622}, {"E'", 660}, {"F'", 698}, {"F'#", 740}, {"G'b", 740}, {"G'", 784},
                {"G'#", 830}, {"A'b", 830}, {"A'", 880}, {"A'#", 932}, {"B'b", 932}, {"B'", 988}
            };
            double totLen = 0; // 單位為 mini second
            for (int i = 0; i < this._numOfData; i++)
            {
                this._notes.Add(new Note(tone2Freq[tones[i]], Double.Parse(durations[i])));
                totLen += Double.Parse(durations[i]);
            }

            // 讀完檔案後才會計算，整個wav檔的長度(需要多少個Samples)
            // samples Define了檔案的總時長, 88200 = 2sec = 1小節
            this.samples = 44100 * ((int) (totLen / 1000) + 1);
            this.dataChunkSize = this.samples * this.frameSize;
            this.fileSize = this.waveSize + this.headerSize + this.formatChunkSize + this.headerSize +
                            this.dataChunkSize;
        }
        // </Method>
    }
}
/*
convert Table (tone2Freq Dictionary)
+--------+-----------+
|  tone  | frequency |
+--------+-----------+
| C      |       262 |
| C#(Db) |       277 |
| D      |       294 |
| D#(Eb) |       311 |
| E      |       330 |
| F      |       349 |
| F#(Gb) |       370 |
| G      |       392 |
| G#(Ab) |       415 |
| A      |       440 |
| A#(Bb) |       466 |
| B      |       494 |
| 0(mute)|        0  |
+--------+-----------+
*/