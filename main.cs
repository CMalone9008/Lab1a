using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write("Enter a number:");
    int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number:");
    int num2 = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Sum = " + (num1 + num2
   ));
   Console.WriteLine("Diff = " + (num1 - num2));
   Console.WriteLine("Product = " + num1 * num2);
   Console.WriteLine("Quotient = " + num1 / num2);
   Console.WriteLine("Remainder = " + num1 % num2);

   

  }
}