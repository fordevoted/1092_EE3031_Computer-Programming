using System;
using System.Linq;

namespace ConsoleApp1{
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
	class Player{
		int N = 0;
		Card[] card;
		int[] pointToRank = {12, 13, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
		string[] pointToFace = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
		public Player(){
			card = new Card[13];
		}
		public Player(int maxN){
			card = new Card[maxN];
		}
		public void AddCard(int point, Suits suit){
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
		public int getRank(int i){
			Console.Write(card[i].Suit + " " + pointToFace[card[i].Point]);
			return (int)card[i].Suit + 4 * pointToRank[card[i].Point];
		}
	}
	class Student{
		string name;
		string department;
		int year;
		public string Name { get => name; set => name = value; }
		public string Department { get => department; set => department = value; }
		public int Year { get => year; set => year = value; }
		public void Show(){
			Console.WriteLine("姓名: " + name);
			Console.WriteLine("科系: " + department);
			Console.WriteLine("年級: " + year);
		}
	}
	class Program{
		static void easy(){
			Student Kevin = new Student();
			Console.Write("Please input your name: ");
			Kevin.Name = Console.ReadLine();
			Console.Write("Please input your department: ");
			Kevin.Department = Console.ReadLine();
			Console.Write("Please input your grade: ");
			Kevin.Year = int.Parse(Console.ReadLine());
			Kevin.Show();
		}
		static void medium(){
			Console.Write("Please input the number of cards: ");
			int N = int.Parse(Console.ReadLine());
			Random random = new Random();
			Player John = new Player(N);
			for (int i = 0; i < N; i++){
				John.AddCard(random.Next()%13 + 1, (Suits)(random.Next()%4));
			}
			John.Show();
		}
		static void hard(){
			bool[] isDrawed = new bool[52];
			Random random = new Random();
			int draw = 0;
			
			Console.Write("Please input the number of players: ");
			int N = int.Parse(Console.ReadLine());
			int nCards = 52/N;
			Player[] player = new Player[N];
			for (int i = 0; i < N; i++){
				player[i] = new Player(nCards);
				for (int j = 0; j < nCards; j++){
					do{
						draw = random.Next()%52;
					}while(isDrawed[draw]);
					isDrawed[draw] = true;
					player[i].AddCard(draw/4, (Suits)(draw%4));
				}
			}
			
			int[] rank = new int[N];
			int[] score = new int[N];
			bool[,] isUsed = new bool[N, nCards];
			int use = 0;
			for (int i = 0; i < nCards; i++){
				for (int j = 0; j < N; j++){
					do{
						use = random.Next()%nCards;
					}while(isUsed[j, use]);
					isUsed[j, use] = true;
					Console.Write("player{0}: ", j+1);
					rank[j] = player[j].getRank(use);
					Console.Write((j==N-1)?"\n":", ");
				}
				int maxRank = rank.Max();
				int maxRankIndex = rank.ToList().IndexOf(maxRank);
				score[maxRankIndex]++;
				Console.WriteLine("player{0} get 1 score", maxRankIndex+1);
			}
			int maxScore = score.Max();
			int maxmaxScoreIndex = score.ToList().IndexOf(maxScore);
			Console.WriteLine("player{0} wins with score {1}", maxmaxScoreIndex+1, maxScore);
		}
		static void Main(string[] args){
			easy();
			medium();
			hard();
		}
	}
}