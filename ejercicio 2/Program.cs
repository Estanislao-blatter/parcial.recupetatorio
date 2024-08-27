using System.Buffers.Text;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseP;
            int altura;
            int ladoP;
            

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Paralelograma: {i}");
                do
                {
                    Console.Write($"Ingresar el valor de la base: ");
                    int.TryParse(Console.ReadLine(), out baseP); 
                    break;
                } while (true);
                Console.WriteLine("La base se ingresó mal..");
                do
                {
                    Console.Write($"Ingresar el valor de la altura: ");
                    int.TryParse(Console.ReadLine(), out altura);
                    break;
                } while (true);
                Console.WriteLine("La altura se ingresó mal..");
                do
                {
                    Console.Write($"Ingresar el valor del lado de un paralelograma: ");
                    int.TryParse(Console.ReadLine(), out ladoP); 
                    break;
                } while (true);
                Console.WriteLine("El lado de un paralelograma se ingresó mal..");
                do
                {
                    var perimetroP = 2 * (baseP + ladoP);
                    Console.WriteLine($"El perimetro es: {perimetroP}");
                    break;
                } while (true);
                Console.WriteLine("El perimetro se ingresó mal..");
                do
                {
                    var superficieP = baseP * altura;
                    Console.WriteLine($"La superficie es: {superficieP}");
                    break;
                } while (true);
                Console.WriteLine("La superficie se ingresó mal..");
            }
            
            
        }   
    }
}
