using System;
using System.Collections.Generic;
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


namespace test
{
    class Token
    {   // Token can be regarded as all character's  base(such as Player, NPC, enemy...)
        protected string art, name;
        public Status status;
        protected Random rnd;
        public Token()
        {// Constructors
            this.art = "";
            this.name = "";
            this.status = new Status();
            rnd = new Random();
        }
        public Token(string Art, string Name)
        {// Constructors
            this.art = Art;
            this.name = Name;
            this.status = new Status();
            rnd = new Random();
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
        {// Try to write it by yourself
            return 0;
        }
        public void Defence(int AttackPoint)
        {// Try to write it by yourself
            
        }
    }

    class Status
    {
        private int hp;
        private int atk;
        private int def;
        private int luc;
        private Random rnd;
        public Status()
        {// Constructors
            rnd = new Random();
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
    {// Inherit
        //private ...
        public Enemy()
        {// ... Try to write it by yourself
            
            
            
            
            
        }
        public Enemy(string Art, string Name, string Quote)
        {// ... Try to write it by yourself
            
            
            
            
            
        }
        public void Debut()
        {// ... Try to write it by yourself
            
        }
    }
}
