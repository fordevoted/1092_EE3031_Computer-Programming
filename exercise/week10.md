# Week10 Exercise

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

```
public string Name {
    get { return name; }
    set { name = value; } 
}
```

```
public string Name {
    get => name;
    set => name = value;
}
```

## Medium

#### Question: Big Two(大老二)-basic
Create a `enum` type called `enumColor` including ♣ [(clubs)](https://en.wikipedia.org/wiki/Clubs_(suit)) , ♦ [(diamonds)](https://en.wikipedia.org/wiki/Diamonds_(suit)) , ♥ [(hearts)](https://en.wikipedia.org/wiki/Hearts_(suit)), ♠ [(spades)](https://en.wikipedia.org/wiki/Spades_(suit)). 

Create a class called `Card` including private variables  `int point` and `enumColor color` and public member functions with `set` and `get`. 

Create a class called `Player` including private array of objects  `Card[] card` and use a constructor to initialize the number of `card` (default = 13). 

Finally, create an object of `Player` called `John`, and use method `AddCard` to assign a random card to `John`. Further use `Show` to print out all cards.

Part of code: 

```
class Player
{
	Card[] card;
	public Player(){}
	public Player(int N){}
	public void AddCard(int point, enumColor color){}
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

```
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

First, randomly deal a deck of cards to players (cannot repeat), and discard the remainder. 

In each turn, every player will randomly choose a card (cannot reuse). The player with max card-rank will get 1 point.

```
Card rank: 2 A K Q J 10 9 8 7 6 5 4 3
Color rank: ♠(spades) ♥(hearts) ♦(diamonds) ♣(clubs)
```

Finally, print out the result.

#### Example:

```
Please input the number of players: 3
player1: Club K, player2: Club A, player3: Heart 2
player3 get 1 point
...
player1: Diamond A, player2: Club 7, player3: Spades 2
player3 get 1 point
player3 wins with score=10
```