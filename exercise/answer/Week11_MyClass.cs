using System;
/* Author: TA of NTU 109-2 EE3031 
 * Contact: r09941007@g.ntu.edu.tw
 * Feel free for using or modifying it!
 */
/* Assigned Readings: 
 * 1. auto-implemented-properties
 * https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
 * 2. Constructors
 * https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/constructors
 * 3. Inheritance (for Hard)
 * https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/inheritance
 */
/* 不管是每周練習、作業、還是期末project，
 * 寫任何的程式，只要他能動，那就是好程式。
 * 可以先做出有功能的作品，再來慢慢改善你的程式碼。
 * 本週之所以出這種類型的題目，
 * 是因為我發現同學寫作業的語法太過於局限了。
 * 希望大家可以多嘗試閱讀其他人的程式碼。
 * 我認為學程式的第一步不是理解他人的程式碼過程，
 * 而是理解他人的程式碼可以做到哪些事情，先試著用，
 * 如果功能達不到你的需求，再去理解他人程式碼，並自己試著改改看。
 */

namespace week11_ans
{
    class Token
    {   // Token can be regarded as all character's  base(such as Player, NPC, enemy...)
        protected string art, name;
        // protected 代表，當Token被其他class繼承後，即使art, name不是被宣告成public，
        // 但在其他class中，仍可直接用this.name this.art，
        // 使用範例可以參考最後的Enemy:Token ，同學可以試著把protected改成private，看看Enemy會顯示甚麼錯誤?
        public Status status;
        internal Random rnd;
        // internal 代表，當Token被放入其他Class後，即使rnd不是被宣告成public，
        // 但在其他class中，仍可用Token.rnd呼叫這個在Token中的Random物件(本次練習的參考解答沒用到)
        public Token()
        {// Constructors
            this.art = "";
            this.name = "";
            this.status = new Status();
            this.rnd = new Random();
        }
        public Token(string Art, string Name)
        {// Constructors
            this.art = Art;
            this.name = Name;
            this.status = new Status();
            this.rnd = new Random();
        }
        public string Art
        {// Auto-implemented property:
            get { return art; }
            set { art = value; }
        }
        public string Name
        {// Auto-implemented property:
            get { return name; }            
            set { name = value; }
        }
        public virtual void ShowInfo()
        {// Method
            Console.WriteLine("{0}\nName: {1}", this.art, this.name);
            this.status.ShowStatus();
        }
        public int Attack()
        {// 公式可以自創
            bool isCritical = this.rnd.Next()%100 < this.status.Luc;
            if (isCritical)
            {
                Console.WriteLine("{0} made a critical hit!", this.Name);
            }
            return this.status.Atk * (isCritical?2:1);
        }
        public void Defence(int AttackPoint)
        {// 公式可以自創
            int damage = AttackPoint/this.status.Def;
            Console.WriteLine("{0} gets {1} damage!", this.Name, damage);
            this.status.Hp -= (damage<=this.status.Hp)?damage:this.status.Hp;
            Console.WriteLine("{0}'s HP: {1}", this.Name, (this.status.Hp>0)?this.status.Hp:0);
        }
    }

    class Status
    {
       /* 之所以要把狀態屬性拉出來寫成一個物件，而不是寫入Token中
        * 是因為我們可以再把Status物件放入如：裝備/ 道具/ Buff效果... 等等其他遊戲元素中
        */
        // 當然，你可以自行更改各項屬性為public/private，完全視各位同學的需求、程式規劃而定。
        private int hp;
        private int atk;
        private int def;
        private int luc;
        private Random rnd;
        public Status()
        {// Constructors
            this.rnd = new Random();
            this.hp  = rnd.Next() % 50  + 50; 
            this.atk = rnd.Next() % 100 + 200;
            this.def = rnd.Next() % 30  + 1;
            this.luc = rnd.Next() % 100 + 1;
        }
        public int Hp
        {// Auto-implemented property:
            get { return this.hp; }
            set { this.hp = value; }
        }
        public int Atk
        {// Auto-implemented readonly property:
            get { return this.atk; }
        }
        public int Def
        {// Auto-implemented readonly property:
            get { return this.def; }
        }
        public int Luc
        {// Auto-implemented readonly property:
            get { return this.luc; }
        }
        public void ShowStatus()
        {// Auto-implemented readonly property:
            Console.WriteLine("  HP:{0, 3}\n ATK:{1, 3}\n DEF:{2, 3}\n LUC:{3, 3}", this.hp, this.atk, this.def, this.luc);
        }
    }// Status

    class Enemy:Token
    {// 繼承
        private string Line;
        public Enemy()
        {
            this.art = "";
            this.name = "";
            this.status = new Status();
            this.rnd = new Random();
            this.Line = "...";
        }
        public Enemy(string Art, string Name, string Line)
        {
            this.art = Art;
            this.name = Name;
            this.status = new Status();
            this.rnd = new Random();
            this.Line = Line;
        }
        public override void ShowInfo()
        {// 多型，這邊覆寫了原本再Token中的ShowInfo()函式
            Console.Write(this.Art);
            this.status.ShowStatus();
            Console.WriteLine("{0} Appeared!\n{1}",this.name, Line);
        }
    }
}
