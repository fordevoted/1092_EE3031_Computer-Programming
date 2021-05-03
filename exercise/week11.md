# Week 11 Exercise

## Preface
If you think the structure of the [given code](https://github.com/fordevoted/1092_EE3031_Computer-Programming/tree/main/exercise/week11_Library), is not suitable for these questions. \
You are encouraged to edit it or create your original library!

## Easy
#### Question: Create an Object & Print its properties

First, choose your favorite picture, and go to this [site](https://www.text-image.com/convert/ascii.html) \
transfer it to an AsciiArt. 

In this question, you :rotating_light:need:rotating_light: to read the [given code](https://github.com/fordevoted/1092_EE3031_Computer-Programming/tree/main/exercise/week11_Library), and finish the missions below:
1. Put your AsciiArt into the AsciiArt.cs file. 
2. Create an Object by class-Token, which contains two properties - name & art, the art must be your AsciiArt above.
3. Use the ShowInfo(), to print your original object's info.

:rotating_light:NOTICE:rotating_light: \
You can use the given function - Ascii2StrDeclare in AsciiConverter.cs. \
It will help you to create an AsciiArt string \
![How2Use](https://imgur.com/5MbwoYz.jpg) \
^Reference: https://www.asciiart.eu/comics/batman

#### Example1:
1. Go to the [site](https://www.text-image.com/convert/ascii.html), and choose your favorite picture. \
![step1](https://imgur.com/33be3TT.jpg)
2. Convert it to the AsciiArt & Put it into AsciiArt.cs. \
![step2](https://imgur.com/n06tUPY.jpg)
3. Learn how to create an Object & Learn how to use ShowInfo in it. \
![step3](https://imgur.com/0Ru1Aax.jpg)
#### Example2:
![SevenSkyEmperor](https://imgur.com/W0COZlc.jpg)

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
