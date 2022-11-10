namespace Apartat1
{
    class Program
    {
        static void Main()
        {
            uint i_ageTotal = 0;
            UInt16 i_numAges;
            while (true)
            {
                Console.WriteLine("Introdueix el nombre de edats que vols introduir : ");
                string? s_numAges = Console.ReadLine();
                if (s_numAges != null)
                {
                    try
                    {
                        i_numAges = Convert.ToUInt16(s_numAges);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no hes valid");
                    }
                    catch (System.OverflowException)
                    {
                        Console.WriteLine("El nombre no pot ser menor que 0");
                    }
                }
            }
            for (int i = 0; i < i_numAges; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Introdueix la edat {i + 1} :");
                    string? s_age = Console.ReadLine();
                    if (s_age != null)
                    {
                        try
                        {
                            uint i_age = Convert.ToUInt16(s_age);
                            i_ageTotal = i_ageTotal + i_age;
                            break;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("El que has introduit no es valid");
                        }
                        catch (System.OverflowException)
                        {
                            Console.WriteLine("El nombre no pot ser menor que 0");
                        }
                    }
                }
            }
            float mitja = i_ageTotal / i_numAges;
            Console.WriteLine($"La mitja es de {mitja} anys");
        }
    }
}