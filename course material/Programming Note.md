# C# Programming Note
## Indentation style

In computer programming, an indentation style is a convention governing the indentation of blocks of code to convey program structure. Indentation style is only one aspect of programming style.

1. Allman style

   ```
   while (x == y)
   {
       something();
       somethingelse();
   }
   ```

2. K&R style

   ```
   while (x == y) {
       something();
       somethingelse();
   }
   ```


To indent your code, you may press `Tab` or two/four `whitespace` at the beginning of the line. For example:

Before: 

```
something();
```

After: 

```
    something();
```

To easily indent multiple lines, you can highlight the lines and press `Tab`. For example:

Before: 

```
while (x == y) {
    something();
    somethingelse();
}
```

After: 

```
    while (x == y) {
        something();
        somethingelse();
    }
```

More examples of indentation are showed as following:

If-else: 

```
if (x == y) {
    something0();
}
else if (x > y) {
    something1();
}
else {
    something2();
}
```

For, while, do-while: 

```
for (int i=0; i < x; i++) {
    something();
}
```

Function: 

```
static void Main(string[] args) {
    something();
}
```

## Bracket matching

Bracket matching, also known as brace matching or parentheses matching, is a syntax highlighting feature of certain text editors and integrated development environments that highlights matching sets of brackets.

```
for (int i=0; i < x; i++) 
{
    something();
}
```

## Comment

A comment is an explanation or description of the source code of the program. It helps a developer explain logic of the code and improves program readability. At run-time, a comment is ignored by the compiler.

1. Single Line Comment

   ```
   // Sample single line comment
   ```

2. Multi Line Comment

   ```
   /* Sample Multi line Comment
   * Line 1
   * Line 2
   * …
   * …
   */
   ```

