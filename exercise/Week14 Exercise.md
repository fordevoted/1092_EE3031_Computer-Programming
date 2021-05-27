# Week14 Exercise

## **Question: Base Converter**

Design a Windows Forms application that can input a decimal number _**N**_ and a base _**B**_ , then convert _**N**_ from decimal(base 10) to base _**B**_ after the user click the **Convert** button. 

For example, (1024)<sub>10</sub> = (10000000000)<sub>2</sub> , (81)<sub>10</sub> = (10000)<sub>3</sub> , (255)<sub>10</sub> = (FF)<sub>16</sub> .

To simplify the problem, we assume both of the inputs _**N**_ and _**B**_ are positive integers.

****Hint:****

1. Assume _**N**_=4138 and _**B**_=16, we can repeat the following steps until the quotient is equal to 0:

 |Step| Divide | Modulo  |Result 
 | :--------- | ---------: | ---------: | ---------: |
 |1.|4138 DIV 16 = 258|4138 MOD 16 = 10|A|
 |2.|258 DIV 16 =  16|258 MOD 16 = 2|2A|
 |3.|16 DIV 16 = 1|16 MOD 16 = 0|02A|
 |4.|1 DIV 16 = 0|1 MOD 16 = 1|102A|
 
2.  As the remainder may be greater than 10, we can use [ASCII code](https://zh.wikipedia.org/wiki/ASCII) to represent the number (10=A, 11=B, ..., etc.)

**Example 1:**

![](https://i.imgur.com/6tEhFYm.png)

**Example 2:**

![](https://i.imgur.com/S7jnryr.png)

**Example 3:**

Check our github website [Week14_Program.exe](https://github.com/fordevoted/1092_EE3031_Computer-Programming/blob/main/exercise/Week14_Program.exe).

**Reference:**
1.  [進位制-維基百科](https://zh.wikipedia.org/wiki/%E8%BF%9B%E4%BD%8D%E5%88%B6)

