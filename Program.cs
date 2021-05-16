using System;
using static System.Console;

namespace WEEK_5_LAB_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {BankA bankA=new BankA();
        BankB bankB=new BankB();
        BankC bankC=new BankC();

        bankA.getBalance();
        bankB.getBalance();
        bankC.getBalance();
        
        }

        
    }
}
