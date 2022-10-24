using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to El Resistory");

      // Options
      Console.WriteLine("What would you like to calculate?");
      Console.WriteLine("resistance, voltage, current ?");

      // User input
      Console.Write("> ");
      string userChoice = Console.ReadLine();

      // Decision Making
      if (userChoice == "current") {
        // I = U / R

        Console.Write("Please enter voltage [V]: ");
        double voltage = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter resistance [Ohm]: ");
        double resistance = Convert.ToDouble(Console.ReadLine());

        double current = voltage / resistance;
        Console.WriteLine($"The result is {current} A");

      } else if (userChoice == "voltage") {
        // U = I * R

        Console.Write("Please enter current [A]: ");
        double current = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter resistance [Ohm]: ");
        double resistance = Convert.ToDouble(Console.ReadLine());

        double voltage = current * resistance;
        Console.WriteLine($"The result is {voltage} V");

      } else if (userChoice == "resistance") {
        // R = U / I

        Console.Write("Please enter current [A]: ");
        double current = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter voltage [V]: ");
        double voltage = Convert.ToDouble(Console.ReadLine());

        double resistance = voltage / current;
        Console.WriteLine($"The result is {resistance} Ohm");

      } else {
        Console.WriteLine("Sorry. Unknown command");
      }

    }
  }
}