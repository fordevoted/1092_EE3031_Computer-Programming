        static void Main(string[] args)//<----主程式進入點, 從Main函式這裡開始跑
        {
            //不熟悉這個用法的同學也可以先分開寫每一題
            easy();//呼叫easy函式(會跳到第 17 行開始執行)
            Console.WriteLine("easy done.");

            medium();//呼叫medium函式(跳到第 46 行開始執行)
            Console.WriteLine("medium done.");

            hard();//呼叫hard函式(跳到第 88 行開始執行)
            Console.WriteLine("hard done.");

            Console.WriteLine("按Enter鍵結束");
            Console.ReadLine();
        }
        /*3-narcissistic number*/
        static void easy(){
            /*Solution 1(recommend)*/
            for(int num=100; num<1000 ;num++){//num從100跑到999
                int digit1=(num/100)%10;//取得 num 的百位數字
                int digit2=(num/10)%10;//取得 num 的十位數字
                int digit3=num%10;//取得 num 的個位數字                
                int sum = digit1*digit1*digit1 + digit2*digit2*digit2 + digit3*digit3*digit3;//算出每個digit的3次方的總和
                //計算次方也可以使用如下 Math.Pow(x,y)  即可得到 x 的 y 次方, 要注意回傳型態是double
                //double sum =Math.Pow(digit1,3)+Math.Pow(digit2,3)+Math.Pow(digit3,3);
                if(sum==num){//判斷是否等於 num 自己本身
                    Console.WriteLine("{0} is a 3-Narcissistic number.", num);
                }
            }
            /*Solution 2*/
            /*
            for(int digit1=1;digit1<=9;digit1++){//百位數字從1~9
                for(int digit2=0;digit2<=9;digit2++){//十位數字從0~9
                    for(int digit3=0;digit3<=9;digit3++){//個位數字從0~9
                        int num = digit1*100+digit2*10+digit3;//還原該數字
                        int sum = digit1*digit1*digit1 + digit2*digit2*digit2 + digit3*digit3*digit3;//算出每個數的3次方的總和
                        if(sum==num){
                            Console.WriteLine("{0} is a 3-Narcissistic number.", num);
                        }
                    }
                }
            }
            */            
        }
        /*GCD & LCM*/
        static void medium(){
            /*Solution1:輾轉相除(recommend)*/
            Console.Write("Please enter num1:");
            int num1 = int.Parse(Console.ReadLine());//讀取整數可以使用int.Parse()
            Console.Write("Please enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());//也可以使用Convert.ToInt()
            if(num1>0 && num2>0){//檢查輸入的數字是否皆大於0
                int remainder, x=num1,y=num2;
                while(y!=0){//輾轉相除法, 參考講義Chapter 4.11
                    remainder=x%y;
                    x=y;
                    y=remainder;
                }
                int GCD=x, LCM=num1*num2/x;//最小公倍數=兩個輸入相乘再除以最大公因數
                Console.WriteLine("The Greatest Common Divisor of {0} and {1} is {2}", num1, num2, GCD);
                Console.WriteLine("The Least Common Multiple of {0} and {1} is {2}", num1, num2, LCM);
            }
            else{//num1或num2為負數
                Console.WriteLine("Value Out of Range.");
            }
            /*Solution2*/
            /*
            Console.Write("Please enter num1:");
            int num1 = int.Parse(Console.ReadLine());//讀取整數可以使用int.Parse()
            Console.Write("Please enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());//也可以使用Convert.ToInt()
            if(num1>0 && num2>0){//檢查輸入的數字是否皆大於0
                int GCD=1, LCM=1;
                for(int i=1;i<=num1 && i<=num2;i++){//從1開始檢查每一個數字是否整除num1和num2
                    if(num1%i==0 && num2%i==0)
                        GCD=i;                
                }
                LCM=num1*num2/GCD;
                Console.WriteLine("The Greatest Common Divisor of {0} and {1} is {2}", num1, num2, GCD);
                Console.WriteLine("The Least Common Multiple of {0} and {1} is {2}", num1, num2, LCM);
            }
            else{//num1或num2為負數
                Console.WriteLine("Value Out of Range.");
            }
            */
        }
        /*Fibonacci sequence and golden ratio*/
        static void hard(){
            Console.Write("Enter N:");
            int n = int.Parse(Console.ReadLine());
            double Fib1=1, Fib2=1, temp;//ulong型態也可
            Console.WriteLine("F({0})={1}, ratio={2}",1,Fib1,0);//顯示F(1)=1, ratio=0 (注意F1前一項為0, 記得不要除以0!!)
            Console.WriteLine("F({0})={1}, ratio={2}",2,Fib2, Fib2/Fib1);//顯示F(2)=1, ratio=1
            if(n>=3){                
                for(int i=3;i<=n;i++){//計算出第 i 個Fibonacci number以及ratio並顯示
                    temp=Fib2;
                    Fib2=Fib1+Fib2;
                    Fib1=temp;
                    Console.WriteLine("F({0})={1}, ratio={2}",i,Fib2,Fib2/Fib1);//輸出F(3)~F(N)
                }                
            }
            else if(n<=0){
                Console.WriteLine("Value Out of Range");
            } 
        }
