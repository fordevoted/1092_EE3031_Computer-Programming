# Week 16 - Electronic Music DIY

# Easy 
## Question: Read the music sheet & Display
In sample/... are some sample sheet & music, :rotating_light:DO NOT:rotating_light: change them. 

1. Read both ***duration.txt*** and ***tone.txt*** files that put in same directory.
2. Apply what you learned so far, do some string handling to data read from *.txt.
3. Print all data like example below.

Do it with any method you want, or just check method in [System.IO.File](https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-5.0).

**Hint:** 

1. [String.Replace Method](https://docs.microsoft.com/en-us/dotnet/api/system.string.replace?view=net-5.0)
2. [String.Split Method](https://docs.microsoft.com/en-us/dotnet/api/system.string.split?view=net-5.0)

#### Example:
![ex1](https://imgur.com/5P3qRQ7.jpg) ![ex2](https://imgur.com/hArRax6.jpg)
# Medium 
## Question: Use try-catch/throw let Wav function in MakeMusic.cs more robust.

Example usage of Wav function

```C#
static void Main(string[] args)
{
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Unity\", "tone.txt", "duration.txt", "Unity.wav", 5);
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\NightOfFire\", "tone.txt", "duration.txt", "NightOfFire.wav", 4);
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\MagicForest\", "tone.txt", "duration.txt", "MagicForest.wav", 3);
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Megalovania\", "tone.txt", "duration.txt", "Megalovania.wav", 2);
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Wily'sCastle\", "tone.txt", "duration.txt", "Wily'sCastle.wav", 1);
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Dejavu\", "tone.txt", "duration.txt", "Dejavu.wav");
}
```

The following situations might make Wav function break.

1. File not found.
2. Directory is not exist.
3. Duration and tone are not .txt format.
4. Output file is not .wav format.

Add try-catch and throw to function - Wav(), to prevent the situations above.

#### Example1:
```C#
// Case: File Not found
MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Dejavu\", "TONE.txt", "DURATION.txt", "out0.wav");
```
```
File Not found. (TONE.txt, DURATION.txt)
```
#### Example2:
```C#
// Case: Directory is not exist.
MakeMusic.Wav(@"C:\Users\TA\workshop\week9999\sample\Wily'sCastle\", "tone.txt", "duration.txt", "out1.wav", 1);
```
```
Directory is not exist. (C:\Users\TA\workshop\week9999\sample\Wily'sCastle\)
```         
#### Example3:
```C#
// Case: Duration and tone are not .txt format.
MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Megalovania\", "tone.dat", "duration.jpg", "out2.wav", 2);
```
```
Input files must be .txt files. (tone.dat, duration.jpg)
```
#### Example4:
```C#
// Case: Output file is not .wav format.
MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\MagicForest\", "tone.txt", "duration.txt", "out3.mp3", 3);
```
```
Output music file must be .wav format. (out3.mp3)
```            
# Hard
## Question: Modulate music sheet
![note](https://imgur.com/O55EedJ.jpg) \
Wiki - Musical note: \
In music, a note is a symbol denoting a musical sound. In English usage a note is also the sound itself. \
Notes can represent the ***pitch*** and ***duration*** of a sound in musical notation.

In week16 samples, \
Pitch data saved in tone.txt \
Duration data saved in duration.txt \
For this problem, you need to modulate the ***pitch*** and ***duration*** of the given music sheet.

Two examples to modulate a music sheet are as follow.
### Modulate the pitch:
1. Read .../sample/Megalovania/tone.txt
2. Let all pitch shift up [half step](https://en.wikipedia.org/wiki/Chromatic_scale), write it into newTone.txt. \
shift up half step means: D -> D#, Ab -> A, and so on.
3. :point_down: Use Wav(...) recreate newMegalovania.wav.
```C#
MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Megalovania\", "newTone.txt", "duration.txt", "newMegalovania.wav", 1);
```

### Modulate the duration:
Actually, [BPM](https://en.wikipedia.org/wiki/Tempo) of [Wily's Castle](https://musescore.com/user/8853446/scores/4256311) is 180, but the BPM of given duration.txt is only 120. \
We need to divide all duration by 1.5, revise Wily's Castle BPM to 180.
1. Read .../sample/Wily'sCastle/duration.txt
2. Divide all duration by 1.5, write it into newDuration.txt.
3. :point_down: Use Wav(...) recreate newWily'sCastle.wav.
```C#
MakeMusic.Wav(@"C:\Users\TA\workshop\week16\sample\Wily'sCastle\", "tone.txt", "newDuration.txt", "newWily'sCastle.wav", 1);
```

#### NOTE:
duration.txt / note.txt files end without space or enter.

# reference
[1] https://stackoverflow.com/questions/14042630/how-to-generate-sounds-according-to-frequency

[2] [Rossing, Thomas D., The science of sound](https://ntu.primo.exlibrisgroup.com/discovery/fulldisplay?docid=alma991002261069704786&context=L&vid=886NTU_INST:886NTU_INST&lang=en&search_scope=MyInst_and_CI&adaptor=Local%20Search%20Engine&tab=Everything&query=any,contains,The%20science%20of%20sound&offset=0)

[3] [ADSR filter](https://www.wikiaudio.org/adsr-envelope/#:~:text=An%20ADSR%20envelope%20is%20a,often%20its%20loudness%20over%20time.)

[4] [Wily's Castle](https://musescore.com/user/8853446/scores/4256311)

[5] [Deja Vu](https://musescore.com/user/26506551/scores/4835692)

[6] [Magic Forest](https://www.poppiano.org/en/sheet/?id=8466)

[7] [Megalovania](https://musescore.com/user/3095931/scores/1287966)

[8] [Night of Fire](https://musescore.com/vodkat/scores/6108518)

[9] [Unity](https://musescore.com/desion/thefatratunity)



