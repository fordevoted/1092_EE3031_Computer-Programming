using System;

namespace Review4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day0 
            Stock mtk = new Stock(2454, 500); // 發哥
            Stock asus = new Stock(2357, 326.5); // 堅若磐石
            Stock skfh = new Stock(2888, 9.31); // 新光金
            Stock ctbc = new Stock(2891, 19.25); // 中信金
            
            // 建立兩位投資人
            Investor kp = new Investor("柯玟轍", 50000);
            kp.AddHolding(2357, new Strategy(asus.Clone(), 4, 325, 305));
            kp.AddHolding(2891, new Strategy(ctbc.Clone(), 1, 19.4, 19.2));
            Investor rd = new Investor("連聖雯", 50000);
            rd.AddHolding(2454, new Strategy(mtk.Clone(), 2));
            rd.AddHolding(2357, new Strategy(asus.Clone(), 2));
            rd.AddHolding(2888, new Strategy(skfh.Clone(), 1));
            
            Console.WriteLine("各投資人起始資產\n");
            kp.Show();
            Console.WriteLine();
            rd.Show();
            Console.WriteLine();
            
            // Day1
            // 更新收盤價
            mtk.SetPrice(509);
            asus.SetPrice(325.5);
            skfh.SetPrice(9.3);
            ctbc.SetPrice(19.25);
            // 投資人根據Day0的收盤價，於Day1執行各自的投資策略
            kp.Update(mtk.Clone());
            kp.Update(asus.Clone());
            kp.Update(skfh.Clone());
            kp.Update(ctbc.Clone());
            rd.Update(mtk.Clone());
            rd.Update(asus.Clone());
            rd.Update(skfh.Clone());
            rd.Update(ctbc.Clone());
            Console.WriteLine("day 1");
            kp.Show();
            Console.WriteLine();
            rd.Show();
            Console.WriteLine();
            
            // Day2 完全同Day1 只是改數字
            // 更新收盤價
            mtk.SetPrice(510);
            asus.SetPrice(325);
            skfh.SetPrice(9.34);
            ctbc.SetPrice(19.45);
            // 投資人根據Day1的收盤價，於Day2執行各自的投資策略
            kp.Update(mtk.Clone());
            kp.Update(asus.Clone());
            kp.Update(skfh.Clone());
            kp.Update(ctbc.Clone());
            rd.Update(mtk.Clone());
            rd.Update(asus.Clone());
            rd.Update(skfh.Clone());
            rd.Update(ctbc.Clone());
            Console.WriteLine("day 2");
            kp.Show();
            Console.WriteLine();
            rd.Show();
            Console.WriteLine();
        }
        /*
         * 可看出，各Day的步驟，其實也能包成一個蘭樹，來更簡化程式碼。
         * 但是考量到要更新股價/持股，必須要有至少四個引數。
         * 就還是寫成這種條列式的參考作法惹
         */
    }
}
