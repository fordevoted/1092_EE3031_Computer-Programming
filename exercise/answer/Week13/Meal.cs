namespace ConsoleApp1
{
    public class Meal : Food
    {
        public Meal(string name, int price, int number)
        {
            setName(name);
            setPrice(price);
            setNumber(number);
            setAlreadyApplyDiscount(false);
        }


        public override void order(ref Food[] orderlist, ref  int orderListPointer)
        {
            // third beverage would be 30% off  
            int[] check = {-1};
            for (int i = 0; i < orderListPointer; i++)
            {
                if (orderlist[i] is Meal && !orderlist[i].getAlreadyApplyDiscount())
                {
                    check[0] = i;
                    break;
                }

                
            }
            if (check[0]!= -1)
            {
                orderlist[check[0]].setAlreadyApplyDiscount(true);
                orderlist[orderListPointer] = new Meal(name: getName(), price: (int)(getPrice() * 0.85), number: getNumber());
                orderlist[orderListPointer].setAlreadyApplyDiscount(true);
               
            }
            else
            {
                orderlist[orderListPointer] = new Meal(name: getName(), price: getPrice(), number: getNumber());

            }
            orderListPointer += 1;
        }
    }
}