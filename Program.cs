namespace CardinalAordinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int x))
            {
                for (int i = 1; i <= x; i++)
                {
                    string ordinal = CardinalAOrdinal(i);
                    Console.WriteLine($"{i}{ordinal}");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }

        static string CardinalAOrdinal(int numero)
        {
            // Reglas básicas para convertir números cardinales a ordinales
            if (numero % 100 >= 11 && numero % 100 <= 13)
            {
                return "th";
            }

            switch (numero % 10)
            {
                case 1:
                    return "st";
                case 2:
                    return "nd";
                case 3:
                    return "rd";
                default:
                    return "th";
            }
        }
    }
}