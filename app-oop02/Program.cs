using System.Drawing;
using System.IO;
using System.Net.Sockets;
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




            //part1

            //01

            //    public struct SeatLocation
            //{
            //    public char Row;
            //    public int Number;

            //    public SeatLocation(char row, int number)
            //    {
            //        Row = row;
            //        Number = number;
            //    }

            //    public override string ToString()
            //    {
            //        return $"{Row}-{Number}";
            //    }
            //}


            //02


            //    public class Ticket
            //{
            //    // Static field
            //    private static int ticketCounter = 0;

            //    // Instance fields
            //    private string movieName;
            //    private double price;

            //    public int TicketId { get; private set; }

            //    public string MovieName
            //    {
            //        get { return movieName; }
            //        set
            //        {
            //            if (!string.IsNullOrWhiteSpace(value))
            //                movieName = value;
            //        }
            //    }

            //    public TicketType Type { get; set; }
            //    public SeatLocation Seat { get; set; }

            //    public double Price
            //    {
            //        get { return price; }
            //        set
            //        {
            //            if (value > 0)
            //                price = value;
            //        }
            //    }

            //    // Calculated Property (14% tax)
            //    public double PriceAfterTax
            //    {
            //        get { return Price * 1.14; }
            //    }

            //    // Constructor
            //    public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
            //    {
            //        MovieName = movieName;
            //        Type = type;
            //        Seat = seat;
            //        Price = price;

            //        ticketCounter++;
            //        TicketId = ticketCounter;
            //    }

            //    // Static Method
            //    public static int GetTotalTicketsSold()
            //    {
            //        return ticketCounter;
            //    }

            //    public override string ToString()
            //    {
            //        return $"Ticket #{TicketId} | {MovieName} | {Type} | Seat: {Seat} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
            //    }
            //}




            //03




            //    public class Cinema
            //{
            //    private Ticket[] tickets = new Ticket[20];

            //    // Indexer
            //    public Ticket this[int index]
            //    {
            //        get
            //        {
            //            if (index >= 0 && index < tickets.Length)
            //                return tickets[index];
            //            return null;
            //        }
            //        set
            //        {
            //            if (index >= 0 && index < tickets.Length)
            //                tickets[index] = value;
            //        }
            //    }

            //    // Add Ticket
            //    public bool AddTicket(Ticket t)
            //    {
            //        for (int i = 0; i < tickets.Length; i++)
            //        {
            //            if (tickets[i] == null)
            //            {
            //                tickets[i] = t;
            //                return true;
            //            }
            //        }
            //        return false;
            //    }

            //    // Search by Movie Name
            //    public Ticket GetMovieByName(string name)
            //    {
            //        foreach (var t in tickets)
            //        {
            //            if (t != null && t.MovieName.Equals(name, StringComparison.OrdinalIgnoreCase))
            //                return t;
            //        }
            //        return null;
            //    }
            //}








            //04

            //    public static class BookingHelper
            //{
            //    private static int counter = 0;

            //    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
            //    {
            //        double total = numberOfTickets * pricePerTicket;

            //        if (numberOfTickets >= 5)
            //            total *= 0.90; // 10% discount

            //        return total;
            //    }

            //    public static string GenerateBookingReference()
            //    {
            //        counter++;
            //        return $"BK-{counter}";
            //    }
            //}





            //05


        //    class Program
        //{
        //    static void Main()
        //    {
        //        Cinema cinema = new Cinema();

        //        // Enter 3 tickets
        //        for (int i = 0; i < 3; i++)
        //        {
        //            Console.WriteLine($"\nEnter data for Ticket {i + 1}:");

        //            Console.Write("Movie Name: ");
        //            string name = Console.ReadLine();

        //            Console.Write("Type (0=Standard,1=VIP,2=IMAX): ");
        //            TicketType type = (TicketType)int.Parse(Console.ReadLine());

        //            Console.Write("Seat Row: ");
        //            char row = char.Parse(Console.ReadLine());

        //            Console.Write("Seat Number: ");
        //            int number = int.Parse(Console.ReadLine());

        //            Console.Write("Price: ");
        //            double price = double.Parse(Console.ReadLine());

        //            Ticket t = new Ticket(name, type, new SeatLocation(row, number), price);
        //            cinema.AddTicket(t);
        //        }

        //        // Print Tickets
        //        Console.WriteLine("\n--- All Tickets ---");
        //        for (int i = 0; i < 3; i++)
        //        {
        //            Console.WriteLine(cinema[i]);
        //        }

        //        // Search Movie
        //        Console.Write("\nEnter movie name to search: ");
        //        string search = Console.ReadLine();

        //        var found = cinema.GetMovieByName(search);
        //        Console.WriteLine(found != null ? $"Found: {found}" : "Not Found");

        //        // Total Tickets Sold
        //        Console.WriteLine($"\nTotal Tickets Sold: {Ticket.GetTotalTicketsSold()}");

        //        // Booking References
        //        Console.WriteLine("\nBooking References:");
        //        Console.WriteLine(BookingHelper.GenerateBookingReference());
        //        Console.WriteLine(BookingHelper.GenerateBookingReference());

        //        // Group Discount
        //        double discounted = BookingHelper.CalcGroupDiscount(5, 80);
        //        Console.WriteLine($"\nGroup Discount Price: {discounted} EGP");
        //    }
        //}
    }
    }
}

