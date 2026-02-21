using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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







            //Q2

            //      public class Rectangle
            //{
            //    public double Width { get; set; }
            //    public double Height { get; set; }

            //    public double Area
            //    {
            //        get { return Width * Height; }
            //    }
            //}



            //Rectangle r = new Rectangle();
            //r.Width = 5;
            //r.Height = 4;

            //Console.WriteLine(r.Area); // Output: 20



            //Q3

            //a)
            // Purpose of an Indexer
            //It allows an object to be accessed like an array:

            //register[0] = "Ali";



            //b)

            //        public class StudentRegister
            //{
            //    private string[] names = new string[5];

            //    public string this[int index]
            //    {
            //        get
            //        {
            //            if (index >= 0 && index < names.Length)
            //                return names[index];
            //            else
            //                return "Invalid Index";
            //        }

            //        set
            //        {
            //            if (index >= 0 && index < names.Length)
            //                names[index] = value;
            //        }
            //    }
            //}



            //c)
            //Yes. This is called Indexer Overloading.

            //    public class StudentRegister
            //{
            //    private string[] names = new string[5];

            //    public string this[int index]
            //    {
            //        get { return names[index]; }
            //        set { names[index] = value; }
            //    }

            //    public string this[string name]
            //    {
            //        get
            //        {
            //            foreach (var n in names)
            //                if (n == name)
            //                    return "Found";

            //            return "Not Found";
            //        }
            //    }
            //}





            //Q4

            //a)
            //static means the variable belongs to the class itself, not to individual objects.
            //There is only one shared copy among all instances.


            //b)
            //no
            //Item belongs to a specific object.
            //A static method does not belong to any object.




    }
    }
}

