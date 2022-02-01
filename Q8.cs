using System;

class MainClass {
    public static void Main (string[] args) {
    Console.WriteLine ("Please enter meters:");
    double m = Convert.ToDouble(Console.ReadLine());
    double km = m /1000;
    Console.WriteLine(km+ " Kilometers);
  }
}
