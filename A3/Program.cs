namespace Apartat3
{
    class Program
    {
        static void Main()
        {
            float A;
            float B;

            while (true)
            {
                Console.WriteLine("Introdueix el valor A : ");
                string? s_A = Console.ReadLine();
                if (s_A != null)
                {
                    try
                    {
                        A = float.Parse(s_A);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid");
                    }
                }
            }

            while (true)
            {
                Console.WriteLine("Introdueix el valor B : ");
                string? s_B = Console.ReadLine();
                if (s_B != null)
                {
                    try
                    {
                        B = float.Parse(s_B);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has escrit no és valid");
                    }
                }
            }

            Console.WriteLine($"{A} mòdul {B} és {A % B}");
        }
    }
}