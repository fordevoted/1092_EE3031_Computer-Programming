# Week 13

# Easy & Medium
## Question: Build ordering system

In this task, you need to follow the template given by TA to complete this ordering system.

execution result are as follows.
```
####################################################################################################
##                                             Menu                                               ##
##------------------------------------------------------------------------------------------------##
##   * second meal enjoy 15% off                                                                  ##
##   * buy three dessert and get one free (bonus will be the same item of last order one)         ##
##   * third beverage would be 30% off                                                            ##
##------------------------------------------------------------------------------------------------##
##     Beverage                              Meal                              Dessert            ##
##------------------------------------------------------------------------------------------------##
## 0. Red Tea         NT$15.00 | 0. Chicken Sandwich     NT$75.00 | 0. Vanilla Cone    NT$35.00   ##
## 1. Milk Tea        NT$45.00 | 1. Lemon Shrimp Pasta   NT$90.00 | 1. Kiddle Cone     NT$30.00   ##
## 2. Orange Juice    NT$30.00 | 2. Cheesebuger          NT$65.00 | 2. Apple Pie       NT$40.00   ##
####################################################################################################
What would you want to order?
Dessert 1
Dessert 0
Dessert 2
Beverage 1
Beverage 2
Dessert 2
Beverage 1
Meal 1
Meal 0
end
You buy 10 items, and the total price is NT$404.00

Process finished with exit code 0.
```

There are 3 type of food, beverage, meal, and dessert respectively, and 9 items in the menu.

Customer will input `food_type food_number` to order, and input `end` to checkout.

Most of code are completed, you only need to implement 3 classes (Beverage, Meal, Dessert), which inherit abstract class **Food**

The constructor of these 3 classes should be (Dessert for example)
```C#
public Dessert(string name, int price, int number)
        {
            setName(name);
            setPrice(price);
            setNumber(number);
            setAlreadyApplyActivity(false);
        }
```

Notice 1: calcuate discount while ordering, the discount rules are shown in menu (in execution reuslt).

Notice 2: the ordering manner is input `food_type food_number`, you are encouraged to modify the code so that the order manner can be that input `food_name`, which is more closed to real system.

# Hard
For each following description, please select the most related principle of **SOLID**. To learn more infomation about **SOLID** principle, refer to Ch10 of the lecture.
```
S: Single Responsibility Principle (SRP) 
O: Open-Closed Principle (OCP) 
L: Liskov Substitution Principle (LSP) 
I: Interface Segregation Principle (ISP) 
D: Dependency Inversion Principle(DIP) 
```
- ( A )  期末專題全部丟給同一個組員(類別)做，他將可能因為難以負荷工作量而產生許多疏失(Bug)，對於他所做的事，也會有耦合度太高，別人難以修改甚至理解的問題。
> 溫馨提醒: 期末專題要記得分工哦!
- ( B ) 對於設計一款刮鬍刀，更換刀頭時，我們應該不需要去修改內部構造，只要換刀頭然後啟動就可以了。
- ( C ) 企鵝是一種鳥類，但如果在鳥類的類別中實做飛行的方法，身為繼承鳥類的企鵝將會誤以為自己可以飛...
- ( D ) 女神馮馮開出了長長一串工具人清單(介面)，包含修電腦、送消夜、搶票等等，但接收(繼承)這個工具清單(介面)的肥肥根本只會修電腦，導致繼承後空實作、並非全部方法都用到等問題。
- ( E ) 小羅有很多個女友，如果都叫名子的話，把小蝶叫成小青就尷尬了，但如果通通都透過"女朋友"這個稱謂(介面)呼叫，就不會有叫錯名子的問題。
