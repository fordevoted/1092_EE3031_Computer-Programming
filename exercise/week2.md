# Week2 Exercise
## Easy
#### Question:
Please declare 5 variables, include

| index | Name | Data type | Value |
| -------- | -------- | -------- | ------- |
| 1.| Senior student string|	String|	senior student|
|2.| Junior student string|	String| junior student|
|3.| My grade| int| {your grade}|
|4.| My target GPA of this semester| decimal| 4.3|
|5.| Is senior student| boolean| true if {your grade} higher than 2, else false.|

Utilize these 5 variable to write a program that can print out the following message
“I am senior student at NTU, and my target GPA of this semester is 4.3.”
If your grade is higher than 2, otherwise, print out message
“I am junior student at NTU, and my target GPA of this semester is 4.3.”

**Please follow the naming rule of lecture to name**.
> 1. 物件或變數名稱的第一個字母小寫，例如 sum。 
> 2. 類別、結構、列舉型別、函式等名稱的第一個字母大寫，例如 Main。
>3. 常數(參看講義3.4 節)名稱的所有字母均大寫，例如 PI。
>4. 除常數外的所有名稱，若為多個字(word)組成，第二個及之後的字的第一字母大寫，以便分辨出各個字，例如 sumOfEvenNumbers。
>5. 常數名稱若為多個字組成，各字之間以底線「 _ 」分開，例如ARRAY_SIZE

#### Example:
- for student whose grade is 1 or 2:
```
C:\Users\user\Desktop\Csharp>dotnet run
I am junior student at NTU, and my target GPA of this semester is 4.3.
```
- for student whose grade is 3 or 4:
```
C:\Users\user\Desktop\Csharp>dotnet run
I am senior student at NTU, and my target GPA of this semester is 4.3.
```

## Medium
#### Question:
Please fix the following code and run successfully. You are encouraged **not** to use *WriteLine* method to complete this exerices.

If you don't know how try-catch clause work, it is simple explanation from Microsoft document. For more detail, you are encouraged to refer to Chapter 11 of lecture, and read section 2 by yourself.

>A try block is used by C# programmers to partition code that might be affected by an exception. Associated catch blocks are used to handle any resulting exceptions.

```c#
using System;

namespace Csharp
{
    class program
    {
        static int Main(string[] args)
        {
            Boolean isEnd = false;
	    Console.Write("temperature of Celsius:");
            try{
		const double degreesCelsius = 0;
            	degreesCelsius = Console.ReadLine();
            	double degreesFahrenheit = 9/5 * dcelsius + 32;
				if(degreesFahrenheit < -459.67){
                    throw new ArgumentException();
                }
				
            	if(degreesFahrenheit> 82.4){
                	Console.Write("It's hot!");
            	}else if(degreesFahrenheit >59.00){
                	Console.Write("It's warm!");;
            	}else if(degreesFahrenheit > 50.00){
                	Console.Write("It's cool!");;;;;;;;;;
            	}else if(degreesFahrenheit > 41.00){
                	Console.Write("It's chilly!");
            	}else if(degreesFahrenheit > 32.00){
                	Console.Write("It's cold!");;;;
            	}else{
                	Console.Write("It's freezing!");
            	}
            	isEnd = true;
	    }catch(Exception e){}
            Console.Write(isEnd? "End" : "Something wrong, please check."); 
            return isEnd? 0.000000m : -1.000000f;
        }
    }
}
```
#### Expected output
```
C:\Users\user\Desktop\Csharp>dotnet run
temperature of Celsius:30
It's warm!
End
C:\Users\user\Desktop\Csharp>dotnet run
temperature of Celsius:10
It's chilly!
End
C:\Users\user\Desktop\Csharp>dotnet run
temperature of Celsius:3
It's cold!
End
C:\Users\user\Desktop\Csharp>dotnet run
temperature of Celsius:-4
It's freezing!
End
C:\Users\user\Desktop\Csharp>dotnet run
temperature of Celsius:-5.6
It's freezing!
End
C:\Users\user\Desktop\Csharp>dotnet run
temperature of Celsius:-140112

Something wrong, please check.
C:\Users\user\Desktop\Csharp>dotnet run
temperature of Celsius:amIAJokeToYou?

Something wrong, please check.
```

## Hard
#### Question:
Please write a simple calculator that can process basic arithmetic (+, -, *, /) of two positive integer number, which is smaller than 10. The input will be a string, and you should print out floating point if the answer is not an integer.
#### Example
```
C:\Users\user\Desktop\Csharp>dotnet run
Input formula:
1+2
3

C:\Users\user\Desktop\Csharp>dotnet run
Input formula:
3-4
-1

C:\Users\user\Desktop\Csharp>dotnet run
Input formula:
5*6
30

C:\Users\user\Desktop\Csharp>dotnet run
Input formula:
7/8
0.875
```

