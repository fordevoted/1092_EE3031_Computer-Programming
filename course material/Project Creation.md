# VS Code C# Project Creation
## Using dotnet(.NET)
1. create and name a folder in your computer
2. open VS Code
3. View --> Terminal
4. type "dotnet new console -o PATH" in terminal, where PATH is the path of your folder
5. File --> Open Folder, open the folder you create
6. View --> Terminal
7. type "dotnet run" in terminal

## Using command line(cmd)

1. create and name a folder in your computer

2. open command line (terminal), search "cmd" in your computer

3. type "dotnet new console -o PATH" in terminal, where PATH is the path of your folder

4. type "cd PATH" in terminal
5. type "dotnet run" in terminal

## Using VS Code

1. create and name a folder in your computer
2. open VS Code
3. View --> Terminal
4. type "dotnet new console -o PATH" in terminal, where PATH is the path of your folder
5. File --> Open Folder, open the folder you create
6. click Program.cs
7. "Required assets to build and debug are missing from c#. Add them?", click "Yes"
8. Terminal --> Run Build Task --> Build
9. Run --> Run Without Debugging

## C# Function Creation

The `Main` method is the entry point of a C# application. Thus the execution order of statement 1~3 should be statement2→statement3→statement1. 

```
using System;

namespace csharp
{
    class Program
    {
        static void Function1()
        {
            statement1;
        }
        
        static void Main(string[] args)
        {
            statement2;
            Function1();
            statement3;
        }
    }
}
```

## Note

After environment setup, you can start programming in "Main" function.

```
using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ...
        }
    }
}
```

Moreover, you can test your program with typing "dotnet run" in terminal

```
C:\Users\user\Desktop\Csharp>dotnet run
```

## Common errors/warnings

warning MSB3026: Could not copy DLL files


