using System;

class Program
  {
    public static double Area(double n1)
    {
      double total = (3.14 * n1 * n1);
      return total;
    }
    public static double Circumference(double n1)
    {
      double total = (2 * 3.14 * n1);
      return total;
    }
    static void Main(string[] args)
    {
      int num1;
      double area,perimeter;
      Console.Write("Radius: ");
      num1 = Convert.ToInt32(Console.ReadLine());
      area = Area(num1);
      perimeter = Circumference(num1);
      Console.WriteLine("The area of the circle is "+area);
      Console.WriteLine("The perimeter of the circle is "+perimeter);
      Console.ReadKey();   
    }
}
