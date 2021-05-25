using System.Linq;

namespace ConsoleApp1
{
    public class Dessert : Food
    {
        public Dessert(string name, int price, int number)
        {
            setName(name);
            setPrice(price);
            setNumber(number);
            setAlreadyApplyDiscount(false);
        }


        public override void order(ref Food[] orderlist, ref int orderListPointer)
        {
            // third beverage would be 30% off  
            int[] check = {-1, -1};
            int count = 0;
            for (int i = 0; i < orderListPointer; i++)
            {
                if (orderlist[i] is Dessert && !orderlist[i].getAlreadyApplyDiscount())
                {
                    check[count] = i;
                    count++;
                }

                if (count >= 2)
                {
                    break;
                }
            }
            if (! check.Contains(-1))
            {
                orderlist[check[0]].setAlreadyApplyDiscount(true);
                orderlist[check[1]].setAlreadyApplyDiscount(true);
               
                orderlist[orderListPointer] = new Dessert(name: getName(), price: getPrice(), number: getNumber());
                orderlist[orderListPointer].setAlreadyApplyDiscount(true);
                orderListPointer += 1;
                
                orderlist[orderListPointer] = new Dessert(name: getName(), price: 0, number: getNumber());
                orderlist[orderListPointer].setAlreadyApplyDiscount(true);
                
            }
            else
            {
                orderlist[orderListPointer] = new Dessert(name: getName(), price: getPrice(), number: getNumber());
            }
            orderListPointer += 1;
        }
    }
}