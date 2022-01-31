using System;

class Program
  {
    public static int Area(int n1, int n2)
    {
      int total = (n1 * n2)/2;
      return total;
    }
    static void Main(string[] args)
    {
      int area,perimeter,n1,n2;
      Console.Write("Height: ");
      n1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Base: ");
      n2 = Convert.ToInt32(Console.ReadLine());      
      area = Area(n1,n2);
      Console.WriteLine("The area of the triangle is "+area);
    }
}
