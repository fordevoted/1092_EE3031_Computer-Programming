using System;
using System.Collections.Generic;
namespace Review4
{
    public class Strategy
    {   // Strategy 會被丟到 Investor裡面
        private double stopProfitPoint;
        private double stopLossPoint;
        private Random rnd;
        public Stock stock;
        // 不知道"一張"股票的英文到底是啥... 決定用piece
        private int piece;
        
        public Strategy(Stock stock, int piece, double stopProfitPoint, double stopLossPoint)
        {// 有停利停損的策略
            this.stopProfitPoint = stopProfitPoint;
            this.stopLossPoint = stopLossPoint;
            this.stock = stock;
            this.piece = piece;
        }

        public Strategy(Stock stock, int piece)
        {// 隨機亂賣的策略
            this.rnd = new Random();
            this.stock = stock;
            this.piece = piece;
        }

        public double SoldOut()
        {// 判斷出清持股的兌現，若沒賣出會回傳0
            bool sold;
            if (rnd == null)
            {// 確認價錢是否已達停利停損點，決定是否賣出
                sold = (stock.GetPrice() >= stopProfitPoint) || (stock.GetPrice() <= stopLossPoint);
            }
            else
            {// 50%機率 亂賣 
                sold = (rnd.Next() % 2 == 0);
            }
            if (sold) return piece * stock.GetPrice();
            return 0;
        }

        public int GetPiece() { return piece; }
        // 市值
        public double GetValue() { return piece * stock.GetPrice(); }
    }// </Strategy>
}