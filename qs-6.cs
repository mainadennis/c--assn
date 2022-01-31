using System;

class Program
  {
    public static int ConvertT(int n1)
    {
      int total = ((n1 / 5)*9)+32;
      return total;
    }
    static void Main(string[] args)
    {
      int m,n1;
      Console.Write("Enter temperature in degrees celcius: ");
      n1 = Convert.ToInt32(Console.ReadLine());
      m = ConvertT(n1);
      Console.WriteLine(n1 + " degrees celcius = "+m + " degrees fahrenheit");
    }
}
