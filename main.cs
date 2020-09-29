using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Please enter the number of cars");
    int carCount = Convert.ToInt32(Console.ReadLine());
    double totalSpeed = 0;
    double totalTime = 0;
    var counter = 0;
    while (counter < carCount){
    
    Console.WriteLine ("Please enter Car #" + carCount +"'s speed");
    double carSpeed = Convert.ToDouble(Console.ReadLine());
    counter++;
    totalSpeed = totalSpeed + carSpeed;
    Console.WriteLine ("Please enter the time taken in hours");
    double carTime = Convert.ToDouble(Console.ReadLine());
    totalTime = totalTime + carTime;
    Console.WriteLine("The speed of this car is " + carSpeed / carTime + " miles per hour");
    }
    Console.WriteLine("The average speed of these cars is " + totalSpeed / totalTime + " miles per hour.");
  }
}