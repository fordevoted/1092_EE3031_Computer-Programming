namespace ConsoleApp1
{
    public abstract class Food
    {
        private string name;
        private int price;
        protected int number;
        protected bool alreadyApplyActivity;
        public abstract void order(ref Food[] orderlist, ref int orderLIstPointer);

        public  string getName(){return name;}

        public void setName(string name) {this.name = name;}

        public int getPrice(){return price;}

        public void setPrice(int price){this.price = price;}
        
        public int getNumber(){return number;}

        public void setNumber(int number){this.number = number;}
        public bool getAlreadyApplyActivity(){return alreadyApplyActivity;}

        public void setAlreadyApplyActivity(bool alreadyApplyActivity){this.alreadyApplyActivity = alreadyApplyActivity;}


    }
}