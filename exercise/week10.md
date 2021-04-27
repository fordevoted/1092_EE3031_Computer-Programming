# Week 10 Exercise

## Easy
#### Question: Create a Class
Create a class called `Student` including private variables  `name`, `department`, and `year`. 

Create public member functions called `Name`, `Department`, and `Year` with `set` and `get` in `Student` class. Further create a public method called `Show` to print out all members. 

Create an object of `Student` called `Kevin`, and use above methods to set the values of members. Further use `Show` to print out all members.


#### Example:
```
Please input your name: 王大明
Please input your department: 電機
Please input your grade: 1
姓名: 王大明
科系: 電機
年級: 1
```
#### Hint

1. By default, all members of a class are `private` if you don't specify an access modifier.
2. Two ways to use `set` and `get`. 

```c#
public string Name {
    get { return name; }
    set { name = value; } 
}
```

```c#
public string Name {
    get => name;
    set => name = value;
}
```

## Medium

#### Question: Big Two(大老二)-dealing(發牌)
Create a `enum` type called `Suits` including ♣ [(Club)](https://en.wikipedia.org/wiki/Clubs_(suit)) , ♦ [(Diamond)](https://en.wikipedia.org/wiki/Diamonds_(suit)) , ♥ [(Heart)](https://en.wikipedia.org/wiki/Hearts_(suit)), ♠ [(Spade)](https://en.wikipedia.org/wiki/Spades_(suit)). 

Create a class called `Card` including private variables  `int point` and `Suits suit` and public member functions with `set` and `get`. 

Create a class called `Player` including private array of objects  `Card[] card` and use a constructor to initialize the number of `card` (default = 13). 

Finally, create an object of `Player` called `John`, and use method `AddCard` to assign a random card to `John`. Further use `Show` to print out all cards.

Part of code: 

```c#
class Player
{
	Card[] card;
	public Player(){}
	public Player(int N){}
	public void AddCard(int point, Suits suit){}
	public void Show(){}
}
```

#### Example:
```
Please input the number of cards: 10
Spades 12, Diamond 6, Spades 9, Heart 11, Diamond 11, Spades 10, Club 1, Diamond 3, Spades 12, Heart 3
```
#### Hint
1. something about `enum`. 

```c#
enum MyType {
	phone = 1,
	notebook = 2,
	laptop = 3
}
void Main()
{
	MyType mytype = MyType.phone;
    Console.WriteLine(mytype);	//phone
    
	int mytype = (int) MyType.notebook;
	Console.WriteLine(mytype);	//2
	
	MyType mytype = (MyType)3;
	Console.WriteLine(mytype);	//laptop
}
```

## Hard

#### Question: Big Two(大老二)

Please implement a single-hand Big Two game.

First, randomly deal a deck of cards to players (cannot repeat), and discard the remainder if the number of players cannot divide a deck. 

In each turn, every player will randomly choose a card (cannot reuse). Someone with max card-rank will get 1 score.

```
Point rank: 2 A K Q J 10 9 8 7 6 5 4 3
Suit rank: ♠(spades) ♥(hearts) ♦(diamonds) ♣(clubs)
```

Finally, print out the result.

#### Example:

```
Please input the number of players: 3
player1: Club K, player2: Club A, player3: Heart 2
player3 get 1 score
...
player1: Diamond A, player2: Club 7, player3: Spades 2
player3 get 1 score
player3 wins with score 10
```

#### Hint

1. refer to *BlackJack_0_0_4* in the lecture, CH9.