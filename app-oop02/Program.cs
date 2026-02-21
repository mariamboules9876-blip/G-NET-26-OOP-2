using System.IO;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace app_oop02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part1--Q1


            //a)


            //            The fields Owner and Balance are declared as public.
            //This allows any external code to modify them directly without control.




            //b)

            //            Make fields private
            //Use properties to control access
            //Add validation inside methods




            //    public class BankAccount
            //{
            //    private string owner;
            //    private double balance;

            //    public string Owner
            //    {
            //        get { return owner; }
            //        set
            //        {
            //            if (!string.IsNullOrWhiteSpace(value))
            //                owner = value;
            //        }
            //    }

            //    public double Balance
            //    {
            //        get { return balance; }
            //        private set { balance = value; } // cannot be modified directly
            //    }

            //    public void Deposit(double amount)
            //    {
            //        if (amount > 0)
            //            balance += amount;
            //    }

            //    public void Withdraw(double amount)
            //    {
            //        if (amount > 0 && amount <= balance)
            //            balance -= amount;
            //    }
            //}






            //c)
//            No control over data
//No validation
//Hard to maintain or modify later
//Leads to bugs and invalid states
//Properties provide safe access to data.








    }
    }
}
