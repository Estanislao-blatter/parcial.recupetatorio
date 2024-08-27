namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseP;
            int altura;
            int ladoP;

            do
            {
                Console.Write($"Ingresar el valor de la base: ");
                int.TryParse(Console.ReadLine(), out baseP);
                Console.Write($"Ingresar el valor de la altura: ");
                int.TryParse(Console.ReadLine(), out altura);
                Console.Write($"Ingresar el valor del lado de un paralelograma: ");
                int.TryParse(Console.ReadLine(), out ladoP);

                var perimetroP = 2 * (baseP + ladoP);
                Console.WriteLine($"El perimetro es:{perimetroP}");
                var superficieP = baseP * altura;
                Console.WriteLine($"La superficie es:{superficieP}");
                break;
            } while (true);
            Console.Write("Algo se ingresó mal...");
           
            

        }
    }
}
