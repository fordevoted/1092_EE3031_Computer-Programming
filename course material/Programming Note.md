# C# Programming Note
## Indentation style

In computer programming, an indentation style is a convention governing the indentation of blocks of code to convey program structure. Indentation style is only one aspect of programming style.

1. Allman style

   ```c#
   while (x == y)
   {
       something();
       somethingelse();
   }
   ```

2. K&R style

   ```c#
   while (x == y) {
       something();
       somethingelse();
   }
   ```


To indent your code, you may press `Tab` or two/four `whitespace` at the beginning of the line. For example:

Before: 

```c#
something();
```

After: 

```c#
    something();
```

## Bracket matching

Bracket matching, also known as brace matching or parentheses matching, is a syntax highlighting feature of certain text editors and integrated development environments that highlights matching sets of brackets. 

e.g. `{}`, `[]`, `()`

```c#
for (int i=0; i < x; i++) 
{
    something();
}
```

## Comment

A comment is an explanation or description of the source code of the program. It helps a developer explain logic of the code and improves program readability. At run-time, a comment is ignored by the compiler.

1. Single Line Comment

   ```c#
   // Sample single line comment
   ```

2. Multi Line Comment

   ```c#
   /* Sample Multi line Comment
   * Line 1
   * Line 2
   * …
   * …
   */
   ```

## Functions Creation

A **method** is a block of code which only runs when it is called. Methods are used to perform certain actions, and they are also known as **functions**.

Why use methods? To reuse code: define the code once, and use it many times.

The `Main` method is the entry point of a C# application. Thus the execution order of statement 1~3 should be `statement3`→`statement1`→`statement2`→`statement4`.

```c#
static void Function1()
{
	statement1;
}
static void Function2()
{
	statement2;
}

static void Main(string[] args)
{
    statement3;
    Function1();
    Function2();
    statement4;
}
```

## Classes and Objects

You learned from the previous chapter that C# is an object-oriented programming language.

Everything in C# is associated with classes and objects, along with its attributes and methods. For example: in real life, a car is an object. The car has **attributes**, such as weight and color, and **methods**, such as drive and brake.

A Class is like an object constructor, or a "blueprint" for creating objects.

## Create an Object from a class

An object is created from a class. We have already created the class named `Student`, so now we can use this to create objects.

To create an object of `Student`, specify the class name, followed by the object name, and use the keyword `new`:

```c#
class Student{
    ...
}
class Program{
    static void Main(string[] args)
    {
        Student Kevin = new Student();
    }
}
```

## Object Methods

Methods normally belongs to a class, and they define how an object of a class behaves.

Just like with fields, you can access methods with the dot syntax. However, note that the method must be `public`. And remember that we use the name of the method followed by two parentheses ()` and a semicolon `;` to call (execute) the method:

```c#
class Student{
    public string name;		// field
    public void Show()		// method
    {
        Console.WriteLine("姓名: " + name);
    }
}
class Program{
    static void Main(string[] args)
    {
        Student Kevin = new Student();
        Console.Write("Please input your name: ");
        Kevin.name = Console.ReadLine();
        Kevin.Show();		// Call the method
    }
}
```

