using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      /*Following method calculate the user selected monument area and cost and show it in the console*/
      CalculateTotalCost();
      
    }

    //calculate the rectangular area
    static double Rect(double length, double width){
      return length * width;
    }

    //calculate the circle area
    static double Circle(double radius){
      return Math.PI * (Math.Pow(radius,2));
    }
    //calculate the triangle area
    static double Triangle(double bottom, double height){
      return 0.5 * bottom * height;
    }

    /* Following method (according user selection from the provided list) call different area calculation methods and evaluate the cost for the monument and show the result in console*/
    static void CalculateTotalCost(){
      Console.WriteLine("What monument would you like to work with?");
      Console.Write("Choose Taj Mahal (1), Mecca (2), Teotihuacan (3): ");
      string monument = Console.ReadLine();
      double totalArea;
      double totalCost;

      switch(monument){

        //Taj Mahal total area calculations
        case "1":
        Console.WriteLine("\nTaj Mahal monument cost details");
        totalArea = Rect(90.5, 90.5) - 2 * Rect(24, 24);
        break;

        //Mecca total area calculations
        case "2":
        Console.WriteLine("\nMecca monument cost details");
        totalArea = Rect(180, 106) + Rect(200, 264) + Triangle(264, 84);
        break;

        //Teotihuacan total area calculations
        case "3":
        Console.WriteLine("\nTeotihuacan monument cost details");
        totalArea = Rect(2500, 1500) + (Circle(375)/2) + Triangle(750, 500);
        break;

        default:
        totalArea = 0;
        break;
      }
      
      Console.WriteLine("Total Area: " + totalArea);
      totalCost = Math.Round((totalArea * 180), 2);
      Console.WriteLine($"My plan costs: {totalCost} pesos\n");
    }
  }
}