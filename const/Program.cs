using System;

namespace BuildingManagement
{
   public class Building
   {
      private int _floorCount;
      private double _height;

      // Constructor to initialize the building with floor count and height
      public Building(int floorCount, double height)
      {
         _floorCount = floorCount;
         _height = height;
      }

      // Constructor to initialize the building with floor count and a default height of 3m per floor
      public Building(int floorCount)
      {
         _floorCount = floorCount;
         _height = floorCount * 3; // Assuming each floor is 3 meters
      }

      // Method to return the maximum size a floor can be, based on total height and floor count
      public double GetFloorMaxSize()
      {
         return _height / _floorCount;
      }

      // Method to return the floor count
      public int GetFloorCount()
      {
         return _floorCount;
      }

      // Method to return the total size of the building
      public double GetSize()
      {
         return _height;
      }
   }

   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Welcome to the Building Management System!");
         Console.WriteLine("Please enter the number of floors:");
         int floors = int.Parse(Console.ReadLine());

         Console.WriteLine("Do you want to specify the total height of the building? (yes/no)");
         string response = Console.ReadLine().Trim().ToLower();

         Building building;

         if (response == "yes")
         {
            Console.WriteLine("Please enter the total height of the building in meters:");
            double height = double.Parse(Console.ReadLine());
            building = new Building(floors, height);
         }
         else
         {
            building = new Building(floors);
         }

         Console.WriteLine("\nBuilding Details:");
         Console.WriteLine($"Total floors: {building.GetFloorCount()}");
         Console.WriteLine($"Max floor height: {building.GetFloorMaxSize():F2} meters");
         Console.WriteLine($"Total height: {building.GetSize():F2} meters");
      }
   }
}

