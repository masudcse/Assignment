using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1stAssignment
{
  public  class Student   //class we must always use class in C#.this is public means outside or from everywhere accessible class
    {
      public int a; // can access everyone 
      private int b; //can access within class
      protected int c; // can accesss from child class 
      internal int d; // can access within same assembly 

      public void Variable()//exmaple declaration of different variable
      {
          int a;
          string Name;
          double Salary;
      }
      public void Datatype()  //Datatypes Example 
      {
          char	a;
          short	b;
          int	c;
          long	d;
          float	e;
          double f;
          decimal g;
          bool h;
      }

      struct Employee //value type
      {
        public  int x;
        public  int y;

         
      }
      public void StructExample()
      {
          Employee _objEmployeeStruct = new Employee();
          _objEmployeeStruct.x = 6;
          _objEmployeeStruct.y = _objEmployeeStruct.x;
          Console.WriteLine("x:{0},y={1}", _objEmployeeStruct.x, _objEmployeeStruct.y);
      }
      class Salary //Reference type
      { 

      }

      public void ImplicitType()
      {
          int x; //explicit datatype declared by us
          int y; //explicit datatype declared by us

          var a = 6.5;//double by value
          var v = 6;// int by value
          var u = "Mahmudunnabi Masud"; // it is string by assigned value
      }

      public void AnonymousType() //Can assign value instanlly rather than using class defince variable & initialize then assing value
      {
          var car = new // we can not declare twice & copy
          {
              carName = "BMW",
              carModel = 2018,
              CarMilez = 65
          };
      }

      public void DynamicTypes() //we can assign any type of value 
      {
          dynamic DynamicVariable = 45;
          DynamicVariable = true;
          DynamicVariable = "Mahmudunnabi";
          DynamicVariable = new { name="Mahmudunnabi",age=32};

      }



    }

  public class specialStudent : Student  //Protected exmaple 
  {
      public void ProtectedExample()
      {
          d = a + c; //can not access b for but others can 
      }
  }

  public interface IWeapon
  {
      void Fire();
  }

  public abstract class Weapon
  {
      protected int DamagePower;
      public abstract void Fire();
  }

  public class Missile:Weapon
  {
      
      public Missile()
      {
          DamagePower = 200;
      }
      
      public override void Fire()
      {
          Console.WriteLine("Missile was fired with Damage Amount{0}",DamagePower);
      }
  }

  public class MachineGun:Weapon
  {
     
      public MachineGun()
      {
          DamagePower = 100;
      }

      public override void Fire()
      {
          Console.WriteLine("Missile was fired with Damage Amount{0}", DamagePower);
      }
  }

  

}
