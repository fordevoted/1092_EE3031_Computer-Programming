using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Review4
{
    public class Investor
    {
        private string name; // 投資人姓名
        private int cash;
        private Dictionary<int ,Strategy> holding;

        public Investor(string name, int cash)
        {
            this.name = name;
            this.cash = cash;
            holding = new Dictionary<int, Strategy>();
        }
        
        public void AddHolding(int stockID, Strategy strategy)
        {// 用來在初始化投資人後，加入他現有的持股
            holding.Add(stockID, strategy);
        }

        public void Update(Stock stock)
        {// 功能：讀入一檔股票，判斷是否有持股，判斷是否要出清，並更新資料
            if (holding.ContainsKey(stock.GetID()))
            {
                double change = holding[stock.GetID()].SoldOut(); // 判斷是否出清
                cash += (int)change;
                if (change != 0) holding.Remove(stock.GetID()); // 移除持股
                else holding[stock.GetID()].stock = stock; // 更新市值
            }
        }

        public void Show()
        {// 用來印出投資人資料
            double asset = cash;
            Console.WriteLine("{0}: 現金 {1, -10}", name, cash);
            IDictionaryEnumerator holdingEnum = holding.GetEnumerator();
            while (holdingEnum.MoveNext())
            {   // 一一印出持股資料 
                Console.WriteLine("持有 {0, -5} {1} {2} 張", 
                    holdingEnum.Key, 
                    StockLibrary.StockID2Name[(int)holdingEnum.Key], 
                    holding[(int)holdingEnum.Key].GetPiece());
                asset += holding[(int) holdingEnum.Key].GetValue();
            }
            Console.WriteLine("總資產: {0,-10:C2}", asset);
            /*
             * Console.WriteLine(myEnumerator.Key + " --> "
                              + myEnumerator.Value);
             */
        }
    }
}