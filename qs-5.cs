using System;

class Program
  {
    public static int ConvertM(int n1)
    {
      int total = (n1 / 100);
      return total;
    }
    static void Main(string[] args)
    {
      int m,n1;
      Console.Write("Enter measurement in Cm: ");
      n1 = Convert.ToInt32(Console.ReadLine());
      m = ConvertM(n1);
      Console.WriteLine(n1 + " cm = "+m + " metres");
    }
}
