# Week3 Exercise
## Easy
#### **Question: Greatest Common Divisor and Least Common Multiple**
Write a program that asks the user input two positive integers, then calculates their greatest common divisor(GCD) and least common multiple(LCM).

**Hint:** Use ```for``` or ```while``` loop to check every number smaller than the inputs to find out GCD, then calculate LCM. **DO NOT** use recursion(will be discussed on Chapter 13.4).

#### Example 1
![image](https://user-images.githubusercontent.com/21131915/110319166-7511c980-8049-11eb-99d2-ed645a0ad897.png)

#### Example 2
![image](https://user-images.githubusercontent.com/21131915/110292236-d88aff80-8027-11eb-98d7-bfef47233947.png)

#### Example 3
![image](https://user-images.githubusercontent.com/21131915/110292328-ff493600-8027-11eb-93e7-8deacebbd71d.png)

## Medium
#### **Question: Find 3-Narcissistic Number**
A _N_-digit number which the summation of the _N_-th powers of its digits equals to itself is called a [_N_-narcissistic number](https://en.wikipedia.org/wiki/Narcissistic_number). 
For example, 153 is a 3-narcissistic number (153 = 1<sup>3</sup> + 5<sup>3</sup> + 3<sup>3</sup> ). 
Write a program to find out **all** of the 3-narcissistic numbers.

**Hint:** Use ```for``` or ```while``` loop to check every number from 100 to 999.

#### Example
![image](https://user-images.githubusercontent.com/21131915/110295817-86001200-802c-11eb-92bd-4b80d1556091.png)

## Hard
#### **Question: Fibonacci Sequence and Golden Ratio**
「人格特化指數1.61803 黃金比例 \phi 人格特化指數已達黃金比例 \phi ．．．」 This is a popular song [《凶宅》](https://youtu.be/PBTSeGLIB_U) by a famous rapper 熊仔Kumachan.

To calculate the[ golden ratio \phi ](https://en.wikipedia.org/wiki/Golden_ratio) , we can first observe the [Fibonacci sequence](https://en.wikipedia.org/wiki/Fibonacci_number): 1 , 1 , 2 , 3 , 5 , 8 , 13 , 21 , ．．． .  In this sequence, the upcoming number is found by adding up the two numbers before itself, that is, _F<sub>n</sub>_ = _F<sub>n-1</sub>_ + _F<sub>n-2</sub>_ . While _n_ becomes larger, the ratio $\frac{F<sub>n</sub>}{F<sub>n-1</sub>}$ converges to golden ratio as _n_ goes to infinity.

Assume _F<sub>1</sub>_=1 and _F<sub>2</sub>_=1, write a program that asks the user input an integer **_n_** ( 3 \leq **_n_** \leq 90 ), then  show the first **_n_** Fibonacci numbers and the approximation of the golden ratio \phi ($\frac{F_2}{F_1}$, $\frac{F_3}{F_2}$ , $\frac{F_4}{F_3}$, ．．．, $\frac{F_n}{F_n-_1}$). 

**Note:** 
1. You don't need to consider the overflow problem, please use ```ulong``` instead of ```int``` to declare _F<sub>n<sub>_ , _F<sub>n-1<sub>_ and _F<sub>n-2<sub>_ .
2. You are encouraged to use ```for``` loop to solve this problem, **DO NOT** use recursion(will be discussed on Chapter 13.4).

#### Example
![](https://i.imgur.com/sF5rhBa.png)

