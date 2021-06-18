using System;
using System.Collections.Generic;

namespace Review4
{
    class StockLibrary
    {
        // 建立Stock物件時，給Constructor查表用
        public static Dictionary<int, string> StockID2Name = new Dictionary<int, string>()
        {
            {2454, "聯發科"},
            {2357, "華碩"}, 
            {2888, "新光金"}, 
            {2891, "中信金"} 
        };
    }
    public class Stock
    {
        private string stockName;
        private int stockID;
        private double price;
        public Stock(int stockID, double price)
        {
            try
            {// 防止companyID不存在於Dictionary的index內
                this.stockName = StockLibrary.StockID2Name[stockID];
                this.stockID = stockID;
                this.price = price;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
        public string GetName() { return this.stockName; }
        public int GetID() { return this.stockID; }
        public double GetPrice() { return this.price; }
        public void SetPrice(double price) { this.price = price; }
        public Stock Clone() { return new Stock(stockID, price); }
    }// </Stock>
}