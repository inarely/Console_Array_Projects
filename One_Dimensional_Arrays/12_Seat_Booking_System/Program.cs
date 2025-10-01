using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Seat_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seats = { 5, 10, 15, 20, 30 };
            bool isOpen = true;

            while (isOpen)
            {
                // Check if all seats are booked
                bool allBooked = true;
                for (int i = 0; i < seats.Length; i++)
                    if (seats[i] > 0)
                    {
                        allBooked = false;
                        break;
                    }
                // If all seats are booked, exit the program
                if (allBooked)
                {
                    Console.Clear();
                    Console.WriteLine("All seats are booked! Thank you for using our service.");
                    break;
                }

                // Display available seats
                for (int i = 0; i < seats.Length; i++)
                {
                    Console.SetCursorPosition(45, i);
                    Console.WriteLine($"There are {seats[i]} available seats in row \"{i + 1}\"");
                }

                // Display menu
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Select an option:");
                Console.WriteLine("1 - Book a seat.");
                Console.WriteLine("2 - Exit.");
                Console.Write("Option: ");
                int option = int.Parse(Console.ReadLine());

                // Handle menu options
                switch (option)
                {
                    case 1:
                        Console.Write("Select a row: ");
                        int row = (int.Parse(Console.ReadLine()) - 1);
                        // Validate row input
                        if (seats.Length < row || row < 0)
                        {
                            Console.WriteLine("Invalid value! (Press any key to retry)");
                            break;
                        }
                        // Book seats
                        Console.Write($"There are {seats[row]} available seats." +
                            $"\nHow many seats would you like to book: ");
                        int seatsRent = int.Parse(Console.ReadLine());
                        // Validate seats input
                        if (seatsRent <= seats[row])
                        {
                            Console.WriteLine($"Booking is successful! (Press any key to continue)");
                            seats[row] -= seatsRent;
                        }
                        else Console.WriteLine("Invalid value! (Press any key to retry)");
                        break;

                    // Exit the program in case of option 2
                    case 2:
                        isOpen = false;
                        break;

                    // Handle invalid options
                    default:
                        Console.WriteLine("Invalid option! (Press any key to retry)");
                        break;
                }
                // Wait for user input before clearing the console
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
