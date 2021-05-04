# Example for using Tools.cs
## Create art library in specific directory
```C#
static void Main(string[] args)
{
    string path = @"/home/TA/EE3031/week11/AsciiArt/";
    LibraryDealer ld = new LibraryDealer(path);
    while(true)
    {
    Console.WriteLine("filename? (ex: 123.txt) (input \"-1\" to break)");
        string filename = Console.ReadLine();
        if(filename == "-1") break;
        ld.Ascii2Txt(filename);
    }
    Console.ReadLine();
}
```
#### Example:
![before](https://imgur.com/UIbJbOV.jpg) \
![building](https://imgur.com/P65fm5z.jpg) \
![after](https://imgur.com/k1Eer2j.jpg)
## Read art library in specific directory
```C#
static void Main(string[] args)
{
    string path = @"C:\Users\clay0\EE3031\week11\test\AsciiArt";
    LibraryDealer ld = new LibraryDealer(path);
    while(true)
    {
    Console.WriteLine("filename? (ex: 123.txt) (input \"-1\" to break)");
        string filename = Console.ReadLine();
        if(filename == "-1") break;
        Console.WriteLine(ld.Txt2AsciiString(filename));
    }
    Console.ReadLine();
}
```
#### Example:
![after](https://imgur.com/k1Eer2j.jpg) \
![after](https://imgur.com/lz6RvWK.jpg)


# Don't forget to change the namespace of each cs file.

