
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;

namespace Week13Exercise
{
    enum enumFood
    {
        Beverage,
        Meal,
        Dessert,
    }
    class Program
    {
        static void Main(string[] args)

        {
            
            Menu myMenu = new Menu();
            myMenu.createMenu();
            Food[] orderList = new Food[99];
            int orderListPointer = 0;
            
            myMenu.showMenu();
            Console.WriteLine("What would you want to order?");
            
            while (true)
            {
                string read = Console.ReadLine();
                read = read.ToLower();
                if (read.Equals("end"))
                {
                    break;;
                }
                string[] split = read.Split(' ');
                string type = split[0];
                int based = 0;
                int number = int.Parse(split[1]);
                if (type.Equals("beverage"))
                {
                    based = (int)enumFood.Beverage;
                }
                else if (type.Equals("meal"))
                {
                    based = (int)enumFood.Meal;
                }
                else if (type.Equals("dessert"))
                {
                    based = (int)enumFood.Dessert;
                }

                myMenu.menu[based *3 +number].order(ref orderList, ref orderListPointer);
            }

            int priceSum = 0;
            for (int i = 0; i < orderListPointer; i++)
            {
                priceSum += orderList[i].getPrice();     
            }
            Console.WriteLine("You buy {0} items, and the total price is {1:C}", orderListPointer, priceSum);


        }

    }

    class Menu
    {
        public Food[] menu;
        private int currentFood;
        public Menu()
        {
            // 3 Beverage, 3 meal, 3 dessert
            menu = new Food[9];
            currentFood = 0;
        }

        public void addMenu(Food food)
        {
            menu[currentFood] = food;
            currentFood += 1;
        }

        public void createMenu()
        {
            addMenu(new Beverage(name:"Red Tea", price:15, number:0));
            addMenu(new Beverage(name:"Milk Tea", price:45, number:1));
            addMenu(new Beverage(name:"Orange Juice", price:30, number:2));
            addMenu(new Meal(name:"Chicken Sandwich", price:75, number:0));
            addMenu(new Meal(name:"Lemon Shrimp Pasta", price:90, number:1));
            addMenu(new Meal(name:"Cheesebuger", price:65, number:2));
            addMenu(new Dessert(name:"Vanilla Cone", price:35, number:0));
            addMenu(new Dessert(name:"Kiddle Cone", price:30, number:1));
            addMenu(new Dessert(name:"Apple Pie", price:40, number:2));
            
        }

        public void showMenu()
        {
            Console.WriteLine(new string('#', 100));
            Console.WriteLine(new string("##"+new string (' ', 45)+"Menu"+new string (' ', 47)+"##"));
            Console.WriteLine("##"+new string('-', 96)+"##");
            Console.WriteLine(new string("##"+new string (' ', 3)+"* second meal enjoy 15% off"+new string (' ', 66)+"##"));
            Console.WriteLine(new string("##"+new string (' ', 3)+"* buy three dessert and get one free (bonus will be the same item of last order one)"+new string (' ', 9)+"##"));
            Console.WriteLine(new string("##"+new string (' ', 3)+"* third beverage would be 30% off"+new string (' ', 60)+"##"));
            Console.WriteLine("##"+new string('-', 96)+"##");
            Console.WriteLine("##"+new string (' ', 5)+"Beverage"+new string (' ', 30)+"Meal"+new string (' ', 30)+"Dessert"+new string (' ', 12)+"##");
            Console.WriteLine("##"+new string('-', 96)+"##");
            for (int i = 0; i < 3; i++)
            {
                    Console.Write("## {0}. {1, -15} {2:C} | ", menu[i].getNumber(), menu[i].getName(), menu[i].getPrice());
                    Console.Write("{0}. {1, -20} {2:C} | ", menu[i+3].getNumber(), menu[i+3].getName(), menu[i+3].getPrice());
                    Console.WriteLine("{0}. {1, -15} {2:C}   ##", menu[i+6].getNumber(), menu[i+6].getName(), menu[i+6].getPrice());
            }
            Console.WriteLine(new string('#', 100));


            
            
        }
    }

}



