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
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\Sample\Unity\", "tone.txt", "duration.txt", "Unity.wav", 5);
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\Sample\NightOfFire\", "tone.txt", "duration.txt", "NightOfFire.wav", 4);
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\Sample\MagicForest\", "tone.txt", "duration.txt", "MagicForest.wav", 3);
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\Sample\Megalovania\", "tone.txt", "duration.txt", "Megalovania.wav", 2);
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\Sample\Wily'sCastle\", "tone.txt", "duration.txt", "Wily'sCastle.wav", 1);
    MakeMusic.Wav(@"C:\Users\TA\workshop\week16\Sample\Dejavu\", "tone.txt", "duration.txt", "Dejavu.wav");
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
MakeMusic.Wav(@"C:\Users\TA\workshop\week16\Sample\Dejavu\", "TONE.txt", "DURATION.txt", "out0.wav");
```
```
File Not found. (TONE.txt, DURATION.txt)
```
#### Example2:
```C#
// Case: Directory is not exist.
MakeMusic.Wav(@"C:\Users\TA\workshop\week9999\Sample\Wily'sCastle\", "tone.txt", "duration.txt", "out1.wav", 1);
```
```
Directory is not exist. (C:\Users\TA\workshop\week9999\Sample\Wily'sCastle\)
```         
#### Example3:
```C#
// Case: Duration and tone are not .txt format.
MakeMusic.Wav(@"C:\Users\TA\workshop\week16\Sample\Megalovania\", "tone.dat", "duration.jpg", "out2.wav", 2);
```
```
Input files must be .txt files. (tone.dat, duration.jpg)
```
#### Example4:
```C#
// Case: Output file is not .wav format.
MakeMusic.Wav(@"C:\Users\TA\workshop\week16\Sample\MagicForest\", "tone.txt", "duration.txt", "out3.mp3", 3);
```
```
Output music file must be .wav format. (out3.mp3)
```            
# Hard
## Question: Modulate given sheet
1. [Natural](https://zh.wikipedia.org/wiki/%E8%BF%98%E5%8E%9F%E5%8F%B7)
2. Increase [bpm](https://zh.wikipedia.org/wiki/%E9%80%9F%E5%BA%A6_(%E9%9F%B3%E6%A8%82))

#### Example1:
1. Read .../sample/MagicForest/tone.txt
2. Remove all '#' and 'b' in it, write it into new_tone.txt.
3. :point_down: 
```C#
MakeMusic.Wav(@"C:\Users\TA\workshop\week18\Sample\MagicForest\", "new_tone.txt", "duration.txt", "newMagicforest.wav", 1);
```

#### Example2:
1. Read .../sample/Wily'sCastle/duration.txt
2. Multiply all duration by 0.7, write it into new_duration.txt.
3. :point_down:
```C#
MakeMusic.Wav(@"C:\Users\TA\workshop\week18\Sample\Wily'sCastle\", "tone.txt", "new_duration.txt", "newWily'sCastle.wav", 1);
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



