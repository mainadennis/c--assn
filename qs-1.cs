using System;

class Program
  {
    public static int Add(int n1,int n2,int n3)
    {
      int total = (n1 + n2 + n3);
      return total;
    }
    public static int Product(int n1,int n2,int n3)
    {
      int product = (n1 * n2 * n3);
      return product;
    }
    public static int Average(int n1,int n2,int n3)
    {
      int average = (n1 + n2 + n3)/3;
      return average;
    }    
    static void Main(string[] args)
    {
      int num1, num2,num3,sum,product,average;
      Console.Write("Number 1: ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Number 2: ");
      num2 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Number 3: ");
      num3 = Convert.ToInt32(Console.ReadLine());
      sum = Add(num1, num2,num3);
      product = Product(num1, num2,num3);
      average = Average(num1, num2,num3);
      Console.WriteLine("The Sum of three numbers is "+sum);
      Console.WriteLine("The product of three numbers is "+product);
      Console.WriteLine("The average of three numbers is "+average);
      Console.ReadKey();   
    }
}
