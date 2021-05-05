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

1. Choose your favorite picture, go to this [site](https://www.text-image.com/convert/ascii.html), transfer it to an AsciiArt. 
2. Save AsciiArt in any way you prefer. 
3. Create an Object by class-Token, which contains two properties - name & art, the art must be your AsciiArt above.
4. Use the ShowInfo(), to print your original object's info.

**Hint:** 
```C#
LibraryDealer ld = new LibraryDealer("your library path");
Token BSMF = new Token(ld.Txt2AsciiString("NTULOGO.txt"), name);
```

#### Example1:
1. Convert a picture to AsciiArt\
![step1](https://imgur.com/33be3TT.jpg)
![step2](https://imgur.com/n06tUPY.jpg)
2. Create an object & use ShowInfo in it. \
![step3](https://imgur.com/0Ru1Aax.jpg)
#### Example2:
![SevenSkyEmperor](https://imgur.com/W0COZlc.jpg)

## Medium
#### Question: Big War

Now, you know how to create an Object, \
but there're only few properties in class - Token.

1. Create two functions - Attack & Defence into class - Token \
   Attack,  needs to return "int" AttackPoint \
   Defence, needs to get the AttackPoint and make "int" damage to Object's HP. \
   You can write the formulas of AttackPoint and damage by you want.
2. Create a function outside class-Token \
   This function will read two objects, and make them attack to each other till someone's HP becomes to 0.

#### Example1:
![result_Hard1](https://imgur.com/aX15AB2.jpg)
#### Example2:
![result_Hard2](https://imgur.com/qhASwgf.jpg)

## Hard
#### Question: Inheritance

1. Create Enemy inherit from Token
2. Try to add some properties/ functions in class-Enemy

The examples below, override the function-ShowInfo(), \
use object.ShowInfo() to show the art of object, and say something.
#### Example1:
![Hard1](https://imgur.com/5INBjQo.jpg) \
#### Example2:
![Hard2](https://imgur.com/TKeZWJO.jpg)
