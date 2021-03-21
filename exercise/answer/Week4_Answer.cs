
		/*Number Triangle*/
		static void easy(){
			/*Solution*/
			Console.Write("Enter a range: ");
			int n = int.Parse(Console.ReadLine());
			
			for(int i=1; i<=n; i++){
				//數字三角形左側的空白數量為三角形高度(n)-目前第幾行(i)
				for(int j=1; j<=n-i; j++)
					Console.Write(" ");
				
				//數字三角形左半邊為等差數列由1至i
				for(int j=1; j<=i; j++)
					Console.Write(j);
				
				//數字三角形右半邊為等差數列由i-1至1
				for(int j=i-1; j>=1; j--)
					Console.Write(j);
				
				//for迴圈一次疊代一行總共n行
				Console.Write("\n");
			}
        }
		/*中二 ID generator*/
		static void medium(){
			/*Solution*/
			string[] prefix = new string[] {"", "0o", "乂☆", "\\", "↗", "＊*", "卍"};
			string[] postfix = new string[] {"", "o0", "☆乂", "/", "↙", "*＊", "卍"};
			string[] infix = new string[] {"", "a", "o", "x", "之", "★", "～", "‧"};
			string[] first = new string[] {"小小", "元氣", "霸氣", "煞氣", "闇夜", "血"};
			string[] second = new string[] {"糖", "漾", "戀果", "鮭魚", "鮪魚", "大閘蟹"};
			
			Random rnd = new Random();
			//prefix
			int p  = rnd.Next(0, 7);
			Console.Write(prefix[p]);
			
			//first
			int f  = rnd.Next(0, 6);
			Console.Write(first[f]);
			
			//infix
			int i  = rnd.Next(0, 8);
			Console.Write(infix[i]);
			
			//second
			int s  = rnd.Next(0, 6);
			Console.Write(second[s]);
			
			//postfix
			Console.Write(postfix[p]);
			Console.Write("\n");
        }
		/*Reverse Number*/
		static void hard(){
			/*Solution*/
			string sequence = "";
			while(true){
				Console.Write("Enter a number: ");
				string number = Console.ReadLine();
				
				if(Convert.ToInt32(number)>=0){
					Console.Write("Reversed number: ");
					
					//由string最後一個index至第一個index
					for (int i=number.Length-1; i>=0; i--){
						Console.Write(number[i]);
						
						//string的加法就是合併
						sequence += number[i];
					}
					Console.Write("\n");
				}
				else{
					Console.WriteLine("A sequence of reversed number: " + sequence);
					break;
				}
			}
        }
		static void Main(string[] args)
        {
            easy();
            medium();
            hard();
        }
