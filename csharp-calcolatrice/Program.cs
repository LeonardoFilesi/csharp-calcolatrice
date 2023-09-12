namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scrivi 2 numeri interi e 2 numeri decimali. Eseguirò le seguenti operazioni:");
            Console.WriteLine("Scrivimi il primo numero intero:");
            int intNum1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Scrivimi il secondo numero intero:");
            int intNum2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Scrivimi il primo numero decimale:");
            double decNum1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Scrivimi il secondo numero intero:");
            double decNum2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Somma di numeri interi:");
            int result = CalcoliHelper.Calculate2NumSum(intNum1, intNum2);

     
            Console.WriteLine("Somma di numeri double ");
            Console.WriteLine("Sottrazione di numeri interi");
            Console.WriteLine("Sottrazione di numeri double");
            Console.WriteLine("Moltiplicazione di numeri interi");
            Console.WriteLine("Moltiplicazione di numeri double");
            Console.WriteLine("Valore assoluto di un numero intero");
            Console.WriteLine("Valore assoluto di un numero double");
            Console.WriteLine("Valore minimo tra due  numeri interi");
            Console.WriteLine("Valore minimo tra due numeri double");
            Console.WriteLine("Valore massimo tra due  numeri interi");
            Console.WriteLine("Valore massimo tra due numeri double");
        }
    }
}