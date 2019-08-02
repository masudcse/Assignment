using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stAssignment
{
    interface IItem  //interface belongs only method 
    {
        double GetVat();
    }

   abstract class Item
    {
       public string ImageUrl;
       public double Price;
       public abstract double GetVatAmount();

   }
   class Product:Item
   {
       public string Name;
       public override double GetVatAmount()
       {
           return Price * 15 / 100;
       }
   }
   class GiftCard:Item
   {
       public string ReceiverEmailAddress;
       public override double GetVatAmount()
       {
           return 0;
       }
   }
   class ShoppingCart
   {
       public Item[] items; 
   }
}
