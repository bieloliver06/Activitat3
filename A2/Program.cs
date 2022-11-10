namespace Apartat2
{
    class Program
    {
        static void Main()
        {
            double d_radius;
            double d_area;
            double d_perimeter;

            while (true)
            {
                Console.WriteLine("Introdueix el radi del cercle (cm) : ");
                string? s_radius = Console.ReadLine();
                if (s_radius != null)
                {
                    try
                    {
                        d_radius = Math.Abs(Convert.ToDouble(s_radius));
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid");
                    }
                }
            }

            d_area = Math.PI * Math.Pow(d_radius, 2);
            d_perimeter = 2 * Math.PI * d_radius;
            Console.WriteLine($"El perimetre de un cercle amb un radi {d_radius} és de {d_perimeter} cm, i té un àrea de {d_area} cm^2");
        }
    }
}