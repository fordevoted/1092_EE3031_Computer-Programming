# Week 11 Exercise

## Preface
In these questions, you :rotating_light:need:rotating_light: to read the [given code](https://github.com/fordevoted/1092_EE3031_Computer-Programming/tree/main/exercise/week11_Library). \
Learn how to use them.
1. AsciiArt/... \
   some sample art.txt
2. Tools.cs \
   You can use it to write/read your txt file
3. MyClass.cs \
   Sample usage of class in RPG.
   
If you think the structure of the [given code](https://github.com/fordevoted/1092_EE3031_Computer-Programming/tree/main/exercise/week11_Library), is not suitable for these questions. \
You are encouraged to edit it or create your original library.


## Easy
#### Question: Create an Object & Print its properties

1. Choose your favorite picture, and go to this [site](https://www.text-image.com/convert/ascii.html), transfer it to an AsciiArt. 
2. Put your AsciiArt into the AsciiArt.cs file. 
3. Create an Object by class-Token, which contains two properties - name & art, the art must be your AsciiArt above.
4. Use the ShowInfo(), to print your original object's info.

#### Example1:
1. Convert a picture to AsciiArt\
![step1](https://imgur.com/33be3TT.jpg)
![step2](https://imgur.com/n06tUPY.jpg)
2. Learn how to create an Object & Learn how to use ShowInfo in it. \
![step3](https://imgur.com/0Ru1Aax.jpg)
#### Example2:
![SevenSkyEmperor](https://imgur.com/W0COZlc.jpg)

**Hint:** 
```C#
LibraryDealer ld = new LibraryDealer("your library path");
Token BSMF = new Token(ld.Txt2AsciiString("NTULOGO.txt"));
```

## Medium1
#### Question: Make your object could Attack & Defence

Now, you know how to create an Object, \
but there're only few properties in class - Token.

Try to create two functions - Attact & Deffence into class - Token 

Attack,  needs to  return "int" AttackPoint \
Defence, needs to get the AttackPoint and make "int" damage to Object's HP. \
The formulas between each variable shown as below: 

CriticalRate = Token.Luc \
AttackPoint = Token.Atk * isCritical?2:1 \
Damage = AttackPoint/Token.Def 


In this question, you need to create a boring object, \
and make it attack itself till it's HP becomes to 0.

#### Example1:
![result_Medium1](https://imgur.com/o59c4I7.jpg)
#### Example2:
![result_Medium2](https://imgur.com/b5WLTCp.jpg)

## Medium2
#### Question: Big War

So far, you have learned, \
How to create an object, \
How to create a function in class. \
How to get&modify properties in object. 

Now, create a function, \
which will read two objects, and make them attack each other till someone's HP becomes to 0.

#### Example1:
![result_Hard1](https://imgur.com/aX15AB2.jpg)
#### Example2:
![result_Hard2](https://imgur.com/qhASwgf.jpg)

## Hard
#### Question: Create Enemy by Inheritance from Token

Try to finish the given code - class Enemy{...} in MyClass.cs, \
make it debut and say something.

#### Example1:
![Hard1](https://imgur.com/5INBjQo.jpg)
#### Example2:
![Hard2](https://imgur.com/TKeZWJO.jpg)
