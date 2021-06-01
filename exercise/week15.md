# Week 15 Exercise

## Easy

#### Question: override & new

Refer to the following code, please choose the reasonable output choice for each problem.

```c#
class Car
{
	public virtual void DescribeCar()
	{
		Console.WriteLine("Four wheels and an engine.");
	}
}
class ConvertibleCar : Car
{
	public new virtual void DescribeCar()
	{
		base.DescribeCar();
		Console.WriteLine("A roof that opens up.");
	}
}
class Minivan : Car
{
	public override void DescribeCar()
	{
		base.DescribeCar();
		Console.WriteLine("Carries seven people.");
	}
}
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("problem 1:");
		Car car1 = new Car();
		car1.DescribeCar();
		
		Console.WriteLine("problem 2:");
		ConvertibleCar car2 = new ConvertibleCar();
		car2.DescribeCar();
		
		Console.WriteLine("problem 3:");
		Minivan car3 = new Minivan();
		car3.DescribeCar();
		
		Console.WriteLine("problem 4:");
		Car car4 = new Car();
		car4.DescribeCar();
		
		Console.WriteLine("problem 5:");
		Car car5 = new ConvertibleCar();
		car5.DescribeCar();
		
		Console.WriteLine("problem 6:");
		Car car6 = new Minivan();
		car6.DescribeCar();
	}
}
```

- (A)
  Four wheels and an engine.

- (B)
  A roof that opens up.

- (C)
  Carries seven people.

- (D)
  Four wheels and an engine.
  A roof that opens up.

- (E)
  Four wheels and an engine.
  Carries seven people.

## Medium & Hard

#### Question: interface

In week 10 exercise, we complete Big Two dealing program. The description is showed as following: 

>   #### Question: Big Two(大老二)-dealing(發牌)
>
>   Create a `enum` type called `Suits` including ♣ [(Club)](https://en.wikipedia.org/wiki/Clubs_(suit)) , ♦ [(Diamond)](https://en.wikipedia.org/wiki/Diamonds_(suit)) , ♥ [(Heart)](https://en.wikipedia.org/wiki/Hearts_(suit)), ♠ [(Spade)](https://en.wikipedia.org/wiki/Spades_(suit)). 
>
>   Create a class called `Card` including private variables  `int point` and `Suits suit` and public member functions with `set` and `get`. 
>
>   Create a class called `Player` including private array of objects  `Card[] card` and use a constructor to initialize the number of `card` (default = 13). 
>
>   Finally, create an object of `Player` called `John`, and use method `AddCard` to assign a random card to `John`. Further use `Show` to print out all cards.
>
>   Part of code: 
>
>   ```c#
>   class Player
>   {
>   	Card[] card;
>   	public Player(){}
>   	public Player(int N){}
>   	public void AddCard(int point, Suits suit){}
>   	public void Show(){}
>   }
>   ```
>
>   #### Example:
>
>   ```
>   Please input the number of cards: 10
>   Spades 12, Diamond 6, Spades 9, Heart 11, Diamond 11, Spades 10, Club 1, Diamond 3, Spades 12, Heart 3
>   ```

Now, we just need to use `interface` to create an abstract class `Iplayer` to rewrite the program we complete in week 10.

```c#
interface Iplayer
{
	void AddCard(int point, Suits suit);
	void Show();
}
```

#### Example:
```
Please input the number of cards: 10
Spades 12, Diamond 6, Spades 9, Heart 11, Diamond 11, Spades 10, Club 1, Diamond 3, Spades 12, Heart 3
```
#### Hint
1. [**w3schools C# Interface**](https://www.w3schools.com/cs/cs_interface.asp)
