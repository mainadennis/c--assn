using System;

class Program
  {
    public static int Area(int n1, int n2)
    {
      int total = (n1 * n2);
      return total;
    }
    public static int Perimeter(int n1, int n2)
    {
      int total = 2*(n1 + n2);
      return total;
    }
    static void Main(string[] args)
    {
      int area,perimeter,n1,n2;
      Console.Write("Length: ");
      n1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Width: ");
      n2 = Convert.ToInt32(Console.ReadLine());      
      area = Area(n1,n2);
      perimeter = Perimeter(n1,n2);
      Console.WriteLine("The area of the circle is "+area);
      Console.WriteLine("The perimeter of the circle is "+perimeter);
    }
}
