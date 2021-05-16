using System;
using static System.Console;
namespace WEEK_5_LAB_ASSIGNMENT
{
    public abstract class Bank
    {
        public int Deposit;
        public abstract void getBalance();  

      
    }

    public class BankA:Bank
    {
         public override void getBalance()
         { Deposit=100;
         WriteLine($"Your current balance is: ${Deposit}");

         }
    }
     public class BankB:Bank
    {
         public override void getBalance()
         {
              Deposit=150;
         WriteLine($"Your current balance is: ${Deposit}");
             
         }
    }

     public class BankC:Bank
    {
         public override void getBalance()
         {
              Deposit=200;
         WriteLine($"Your current balance is: ${Deposit}");
             
         }
    }
}

