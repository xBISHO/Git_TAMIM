using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bitte geben Sie eine positive ganze Zahl ein:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (IstPrimzahl(n))
        {
            Console.WriteLine($"{n} ist eine Primzahl.");
        }
        else
        {
            Console.WriteLine($"{n} ist keine Primzahl.");
        }
    }

    static bool IstPrimzahl(int zahl)
    {
        if (zahl <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(zahl); i++)
        {
            if (zahl % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
