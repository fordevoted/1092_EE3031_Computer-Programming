# 期中複習三 Problem7參考解答
## Problem description

7. 「 踩地雷 」 是微軟 Windows 作業系統所附的小遊戲，許多人都玩過。本題要求寫一個簡化版的踩地雷遊戲，規則如下：
   棋盤由9 X 9 的方格組成，電腦先隨機於其中 10 個方格佈下地雷，使用者隨後 不停 任意翻開方格。 直到遇 見 地雷 ，遊戲即告結束，使用者得分 即遇到地雷前翻開的方格總數。
   所寫程式 的 主控台螢幕 ，開始時 如下圖：

   使用者輸入座標，代表要翻的方格位置。若沒碰到地雷，清除螢幕，重新顯示棋盤及得分 。假設使用者翻開第 0 列第 0 行方格，且未遇地雷，則畫面顯示 如下：

   ![圖片1](https://user-images.githubusercontent.com/8816002/114969072-3540cc00-9eaa-11eb-9055-2dc0764befc8.jpg)


   圖中可見翻出之方格以圈號表示並秀出得 1 分 。如此反覆進行，直到遇見地雷，遊戲結束，主控台螢幕 顯示所有地雷 以星號表出 及已、未翻方格 與得分 。 一種可能 畫面如下：

   ![圖片2](https://user-images.githubusercontent.com/8816002/114969083-3b36ad00-9eaa-11eb-81fa-9c6c013d6075.jpg)


   你可以使用下列已準備好的函式 也可以不用而自行撰寫

   // 顯示棋盤及得分
   // 參數說明:
   // board代表棋盤
   // ix, jx分別代表10顆地雷在棋盤中的列和行座標構成的一維陣列
   // 其元素例如ix[5] = 3,jx[5] = 2表示第6顆地雷位在board[3,2]
   // score代表使用者得分
   // gameOver代表遊戲是否已經結束
   static void Display(char[,] board, int[] ix, int[] jx, int score, bool gameOver)

   ```
   static void Display(char[,] board, int[] ix, int[] jx, int score, bool gameOver){
   	int m;
   	int i;
   	int j;
   	if (gameOver){
   		for (m = 0; m < 10; ++m){
   			board[ix[m], jx[m]] = '*';
   		}
   	}
   	Console.Write("列/行\t");
   	for (j = 0; j < 9; ++j){
   		Console.Write(" {0} ", j);
   	}
   	Console.WriteLine();
   	Console.Write("\t");
   	for (j = 0; j < 9; ++j){
   		Console.Write("+---");
   	}
   	Console.WriteLine("+");
   	for (i = 0; i <9; ++i){
   		Console.Write("{0}\t",i);
   		for (j = 0; j < 9; ++j){
   			Console.Write("| {0} ", board[i, j]);
   		}
   		Console.WriteLine("|");
   		Console.Write("\t");
   		for (j = 0; j < 9; ++j){
   			Console.Write("+---");
   		}
   		Console.WriteLine("+");
   	}
   	Console.WriteLine();
   	Console.WriteLine("得分: {0}", score);
   }
   
   ```

   上列函式可直接在答案中引用，不需重抄一遍。此處使用陣列為參數，可以先不必考慮傳值或傳址，直接以主程式中的對應陣列作為 真實 參數呼叫即可。能利用虛擬碼思考， 並 有適當註解，才可得本題滿分 25 分

## Solving steps

1. 觀察程式IO (input, output)

   input: 欲翻方格座標

   output: 棋盤、得分

2. 程式流程圖

   ![圖片1](https://user-images.githubusercontent.com/8816002/114969094-41c52480-9eaa-11eb-81f3-60a6f81a7a47.png)


3. 蒐集程式所需變數 (因人而異)

4. 變數初始化

   ```
   	//棋盤初始化
   	char[,] board = new char[9, 9];
   	for(int i=0;i<9;i++){
   		for(int j=0;j<9;j++){
   			board[i, j] = ' ';
   		}
   	}
   	
   	//地雷座標初始化 (位置不重複)
   	int[] ix = new int[10];
   	int[] jx = new int[10];
   	bool[] mine = new bool[81];
   	Random rand = new Random();
   	int k = 0, index = 0;
   	while(k<10){
   		index = rand.Next()%81;
   		if(mine[index])
   			continue;
   		ix[k] = (int)index/9;
   		jx[k] = index%9;
   		mine[index] = true;
   		k++;
   	}
   ```

5. 根據流程圖逐步執行

   ```
   	int score = 0;
   	bool gameOver = false;
   	string input;
   	int x, y;
   	while(!gameOver){
   		Console.WriteLine("輸入欲翻方格的座標，以逗點分隔：");
   		input = Console.ReadLine();
   		x = input[0] - '0';
   		y = input[2] - '0';
   		board[x, y] = 'o';
   		score++;
   		for(int i=0;i<9;i++){
   			if(ix[i]==x && jx[i]==y)
   				gameOver = true;
   		}
   		Display(board, ix, jx, score, gameOver);
   	}
   	Console.WriteLine("遊戲結束");
   ```



## Source code

```
static void Main(string[] args)
{
	char[,] board = new char[9, 9];
	int[] ix = new int[10];
	int[] jx = new int[10];
	int score = 0;
	bool gameOver = false;
	
	for(int i=0;i<9;i++){
		for(int j=0;j<9;j++){
			board[i, j] = ' ';
		}
	}
	
	bool[] mine = new bool[81];
	Random rand = new Random();
	int k = 0, index = 0;
	while(k<10){
		index = rand.Next()%81;
		if(mine[index])
			continue;
		ix[k] = (int)index/9;
		jx[k] = index%9;
		mine[index] = true;
		k++;
	}
	
	string input;
	int x, y;
	while(!gameOver){
		Console.WriteLine("輸入欲翻方格的座標，以逗點分隔：");
		input = Console.ReadLine();
		x = input[0] - '0';
		y = input[2] - '0';
		board[x, y] = 'o';
		score++;
		for(int i=0;i<9;i++){
			if(ix[i]==x && jx[i]==y)
				gameOver = true;
		}
		Display(board, ix, jx, score, gameOver);
	}
	Console.WriteLine("遊戲結束");
}

```

