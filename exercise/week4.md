# Week4 Exercise
## Easy

#### **Question: Number Triangle**

Please print a number triangle of range n, where n is a positive integer derived from user input.

**Hint:** 

1. String of space (" ") and digit ("0") have same spacing

#### Example 1

```
Enter a range: 5
     1
    121
   12321
  1234321
 123454321
```

#### Example 2

```
Enter a range: 6
      1
     121
    12321
   1234321 
  123454321
 12345654321
```

## Medium

#### **Question: 中二 ID generator**

In this program, you need to randomly generate a 中二 ID. Your ID may include prefix, postfix and infix. The content should be a combination of two words. For example:

>   1. naming with prefix, postfix and infix: \楓糖★戀果/
>   2. naming with prefix and postfix: \楓糖戀果/
>   3. naming with infix: 楓糖★戀果
>   4. naming without prefix, postfix and infix: 楓糖戀果

Your program should be able to generate the above four types of naming. The naming contents are showed as following: 

```
prefix and postfix:
0o...o0, 乂☆...☆乂, \.../, ↗...↙, ＊*...*＊, 卍...卍

infix:
a, o, x, 之, ★, ～, ‧

first word:
小小, 元氣, 楓糖, 霸氣, 煞氣, 闇夜, 血

second word:
糖, 漾, 戀果, 鮭魚, 鮪魚, 大閘蟹
```

Please randomly generate a 中二 ID.

**Hint:** 

1. The declaration of string array: 

   ```
   string[] strArr1 = new string[5];
   string[] strArr2 = new string[] {"Mon", "Tue", "Wed", "Thu", "Fri"};
   ```

2. To generate a random integer from 0 to 99: 

   ```
   Random rnd = new Random();
   int N  = rnd.Next(0, 100);
   Console.WriteLine(N);
   ```

#### Example

```
乂☆煞氣a薔薇☆乂
```

## Hard

#### **Question: Reverse Number**

In this program, you need to reverse a positive number from user input. For example:

>   Enter a number: 234
>
>   Reversed number: 432

If you complete the above task, you can use it as a prototype to finish a sequence of reverse number. Which concatenate all reverse number and print out if user enter a negative number.

**Hint:** 

1. Two forms of infinite loop: `for( ; ; )`, `while(true)`
2. The `break` statement ends the loop immediately when it is encountered

#### Example

```
Enter a number: 2021
Reversed number: 1202
Enter a number: 03
Reversed number: 30
Enter a number: 19
Reversed number: 91
Enter a number: -1
A sequence of reversed number: 12023091
```
