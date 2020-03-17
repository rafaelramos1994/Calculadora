using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escolha uma das opções : ");
            Console.WriteLine("1 - Quilometro");
            Console.WriteLine("2 - Metro");
            Console.WriteLine("3 - Centimetro");
            Console.WriteLine("4 - Milimetro");
            Console.WriteLine("5 - Micrometro");
            Console.WriteLine("6 - Nanometro");
            Console.WriteLine("7 - Milha");
            Console.WriteLine("8 - Jarda");
            Console.WriteLine("9 - Pe");
            Console.WriteLine("10 - Polegada");
            Console.WriteLine("11 - Milhanautica");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser convertido.");
            double t = Convert.ToDouble(Console.ReadLine());

            Conv comp = new Conv(t, s);

            Console.WriteLine("Escolha para qual medida o valor deve ser convertido:");
            Console.WriteLine("1 - Quilometro");
            Console.WriteLine("2 - Metro");
            Console.WriteLine("3 - Centimetro");
            Console.WriteLine("4 - Milimetro");
            Console.WriteLine("5 - Micrometro");
            Console.WriteLine("6 - Nanometro");
            Console.WriteLine("7 - Milha");
            Console.WriteLine("8 - Jarda");
            Console.WriteLine("9 - Pe");
            Console.WriteLine("10 - Polegada");
            Console.WriteLine("11 - Milhanautica");
            Console.WriteLine("12 - Todas as anteriores");
            int x = Convert.ToInt32(Console.ReadLine());


            if (x == 1)
            {
                Console.WriteLine(comp.Quilometro +" quilometros") ;
            }
            if (x == 2)
            {
                Console.WriteLine(comp.Metro + " metros");
            }
            if (x == 3)
            {
                Console.WriteLine(comp.Centimetro+ " centimetros");
            }
            if (x == 4)
            {
                Console.WriteLine(comp.Milimetro+" milimetros");
            }
            if (x == 5)
            {
                Console.WriteLine(comp.Micrometro+" micrometros");
            }
            if (x == 6)
            {
                Console.WriteLine(comp.Nanometro+" nanometros");
            }
            if (x == 7)
            {
                Console.WriteLine(comp.Milha+" milhas");
            }
            if (x == 8)
            {
                Console.WriteLine(comp.Jarda+" jardas");
            }
            if (x == 9)
            {
                Console.WriteLine(comp.Pe+" pes");
            }
            if (x == 10)
            {
                Console.WriteLine(comp.Polegada+" polegadas");
            }
            if (x == 11)
            {
                Console.WriteLine(comp.Milhanautica+" milhas nautica");
            }
            if (x == 12)
            {
                Console.WriteLine(comp.Quilometro + " quilometros");
                Console.WriteLine(comp.Metro + " metros");
                Console.WriteLine(comp.Centimetro + " centimetros");
                Console.WriteLine(comp.Milimetro + " milimetros");
                Console.WriteLine(comp.Micrometro + " micrometros");
                Console.WriteLine(comp.Nanometro + " nanometros");
                Console.WriteLine(comp.Milha + " milhas");
                Console.WriteLine(comp.Jarda + " jardas");
                Console.WriteLine(comp.Pe + " pes");
                Console.WriteLine(comp.Polegada + " polegadas");
                Console.WriteLine(comp.Milhanautica + " milhas nautica");
            }
            Console.ReadKey();
        }
    }
}
