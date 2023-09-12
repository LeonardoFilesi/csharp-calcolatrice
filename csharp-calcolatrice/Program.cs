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
            Console.WriteLine("Scrivimi il secondo numero decimale:");
            double decNum2 = double.Parse(Console.ReadLine());

            //----------------------------SOMMA----------------------------------
            Console.WriteLine("Somma di numeri interi:");
            int result1 = CalcoliHelper.Calculate2NumSum(intNum1, intNum2);
            Console.WriteLine($"La somma è: {result1}");

            Console.WriteLine("Somma di numeri decimali ");
            double result2 = CalcoliHelper.Calculate2NumSum(decNum1, decNum2);
            Console.WriteLine($"La somma è: {result2}");
            
            //----------------------------DIFFERENZA----------------------------------
            Console.WriteLine("Sottrazione tra due numeri interi");
            int result3 = CalcoliHelper.Calculate2NumDif(intNum1, intNum2);
            Console.WriteLine($"La differenza è :{result3}");

            Console.WriteLine("Sottrazione di numeri decimali");
            double result4 = CalcoliHelper.Calculate2NumDif(decNum1, decNum2);
            Console.WriteLine($"La differenza è: {result4}");

            //----------------------------MOLTIPLICAZIONE----------------------------------
            Console.WriteLine("Moltiplicazione di numeri interi");
            int result5 = CalcoliHelper.Calculate2NumMoltipl(intNum1, intNum2);
            Console.WriteLine($"La moltiplicazione è :{result5}");

            Console.WriteLine("Moltiplicazione di numeri ddecimali");
            double result6 = CalcoliHelper.Calculate2NumMoltipl(decNum1, decNum2);
            Console.WriteLine($"La moltiplicazione è: {result6}");

            //----------------------------VALORE ASSOLUTO INTERO--------------------------------
            Console.WriteLine("Valore assoluto di un numero intero, prendendo in considerazione solo il primo numero che hai scritto");
            int result12 = CalcoliHelper.CalculateAbsoluteIntNum(intNum1);
            Console.WriteLine($"La moltiplicazione è :{result12}");

            //----------------------------VALORE ASSOLUTO DECIMALE--------------------------------
            Console.WriteLine("Valore assoluto di un numero double");
            double result13 = CalcoliHelper.CalculateAbsoluteDecNum(decNum1);
            Console.WriteLine($"La moltiplicazione è :{result13}");

            //----------------------------MINIMO------------------------------
            Console.WriteLine("Valore minimo tra due  numeri interi");
            int result7 = CalcoliHelper.CalculateMinBetween2Num(intNum1, intNum2);
            Console.WriteLine($"Il minimo tra i due è: {result7}");

            Console.WriteLine("Valore minimo tra due numeri double");
            double result8 = CalcoliHelper.CalculateMinBetween2Num(decNum1, decNum2);
            Console.WriteLine($"Il minimo tra i due è: {result8}");

            //----------------------------MASSIMO-------------------------------------
            Console.WriteLine("Valore massimo tra due  numeri interi");
            int result9 = CalcoliHelper.CalculateMaxBetween2Num(intNum1, intNum2);
            Console.WriteLine($"Il massimo tra i due è: {result9}");

            Console.WriteLine("Valore massimo tra due numeri double");
            double result10 = CalcoliHelper.CalculateMaxBetween2Num(decNum1, decNum2);
            Console.WriteLine($"Il massimo tra i due è: {result10}");

            //--------------------------ELEVATO A POTENZA------------------------------
            Console.WriteLine("Valore massimo tra due  numeri interi, dove il primo numero è la base, il secondo numero che hai inserito è l'esponente");
            int result11 = CalcoliHelper.CalculateExponential(intNum1, intNum2);
            Console.WriteLine($"L'elevazione a potenza da come risultato: {result11}");
        }
    }
}