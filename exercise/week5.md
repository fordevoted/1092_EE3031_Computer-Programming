# Week5 Exercise
## Easy

#### **Question: Drink bar menu**

Write a program to read the base & fruit in your store, \
then generate menu.

#### Example

```
Enter base: 
牛奶 啤酒 綠茶
Enter fruit:
西瓜 香蕉 榴槤
Menu:
西瓜牛奶 香蕉牛奶 榴槤牛奶
西瓜啤酒 香蕉啤酒 榴槤啤酒
西瓜綠茶 香蕉綠茶 榴槤綠茶
```


## Medium

#### **Question: Pascal's triangle**

![Pascal's_triangle](https://upload.wikimedia.org/wikipedia/commons/0/0d/PascalTriangleAnimated2.gif)

In mathematics, \
Pascal's triangle is a triangular array of the binomial coefficients \
that arises in probability theory, combinatorics, and algebra. \
e.g. \
![binomial](https://imgur.com/1KL14Yn.jpg)

In this problem, you nead to read an integer as the height of the Pascal's triangle. \
Output is sum of all integers in the Pascal's triangle. 

#### Example 1

```
Please input height of the Pascal's triangle: 3
7
```
A Pascal's triangle with height equals to 3. \
1 \
1 1 \
1 2 1 \
Sum of all integers equals to 7

#### Example 2

```
Please input height of the Pascal's triangle: 5
31
```
A Pascal's triangle with height equals to 5. \
1 \
1 1 \
1 2 1 \
1 3 3 1 \
1 4 6 4 1 \
Sum of all integers equals to 31

**Hint:** 

1. Building priority: row0 -> row1 -> row2 and so on.
2. Use for-for loop to calculate number & save it into array.
3. :point_down: \
![hint](https://imgur.com/dt2Nlq3.jpg)

## Hard

#### **Question: Spreading**

Peko-virus, is a horrible virus with strong infectiousness. \
People were infected by it, can't alive without saying "peko" ... 

In consideration of a class consists of two types of students, \
0 : students who are not infected by peko-virus. \
1 : students who are infected by peko-virus. \
Every 10 minutes, 0 will be infected by nearby(:arrow_up:, :arrow_right:, :arrow_down:, :arrow_left:) 1. 

As a teacher, you need to calculate \
how long does it take that all of your students are infected by peko-virus.

The input consists of two parts, \
First: Size of the class seating chart. \
Second: Class seating chart. \
Output: How long does it take that all of your students are infected.

#### Example 1

```
Please input size of class seating chart:
3 3
Please input a class seating chart:
1 1 1
1 0 1
1 1 1
10 minutes
```
![generation](https://imgur.com/tEJcdrf.jpg)

#### Example 2

```
Please input size of class seating chart:
4 5
Please input a class seating chart:
1 0 0 0 0
1 1 0 0 0
1 1 1 0 0
1 1 1 1 1
30 minutes
```
![generation](https://imgur.com/vKIBjSi.jpg)

**Hint:** 

1. Recommend using bool array.
2. You maybe need to clone the seating chart in each generation.
3. :point_down: \
![hint](https://imgur.com/0winPzm.jpg)
