using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         //insert variables
             int num1,num2,pago,win;
             var aleatorio = new Random();
             var value = aleatorio.Next(0, 100);
            
             Console.WriteLine("Enter your number");
             num1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter your mount");
             num2 = int.Parse(Console.ReadLine());
             
             if (num1 == value)
             {
              pago = (num2 * 80);
              Console.WriteLine("You win:",pago);
             }else{
              Console.WriteLine("You lost");
              Console.WriteLine("el numero ganar es:" + Convert.ToString(value));
             }
    }
}
