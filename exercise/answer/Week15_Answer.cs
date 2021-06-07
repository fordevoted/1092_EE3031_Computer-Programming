using System;
using System.Linq;

namespace App{
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
	
	enum Suits{
		Club,
		Diamond,
		Heart,
		Spade
	}
	class Card{
		int point;
		Suits suit;
		public int Point { get => point; set => point = value; }
		public Suits Suit { get => suit; set => suit = value; }
	}
	interface Iplayer
	{
		void SaveACard(int point, Suits suit);
		void Show();
	}
	class Player:Iplayer{
		int N = 0;
		Card[] card;
		public Player(){
			card = new Card[13];
		}
		public Player(int maxN){
			card = new Card[maxN];
		}
		public void SaveACard(int point, Suits suit){
			card[N] = new Card();
			card[N].Point = point;
			card[N].Suit = suit;
			N++;
		}
		public void Show(){
			for (int i = 0; i < card.Length; i++){
				Console.Write(card[i].Suit + " " + card[i].Point);
				Console.Write((i==card.Length-1)?"\n":", ");
			}
		}
	}
	class Program{
		static void easy(){
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
		static void medium(){
			Console.Write("Please input the number of cards: ");
			int N = int.Parse(Console.ReadLine());
			Random random = new Random();
			Player John = new Player(N);
			for (int i = 0; i < N; i++){
				John.SaveACard(random.Next()%13 + 1, (Suits)(random.Next()%4));
			}
			John.Show();
		}
		static void Main(string[] args){
			easy();
			medium();
		}
	}
}