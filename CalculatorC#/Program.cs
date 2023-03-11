
namespace CalculatorCSharp
{
    public class CalculatorCSharp
    {
        public static void Main(string[] args)
        {
            Divisao();
        }

        public static void Menu()
        {
            Console.Clear();

            System.Console.WriteLine("O que deseja fazer? ");
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Subtracao");
            System.Console.WriteLine("3 - Divisão");
            System.Console.WriteLine("4 - Multiplicacao");
            System.Console.WriteLine("5 - Sair");


            System.Console.WriteLine("-----------------");
            System.Console.WriteLine("Selecione uma opção");
            short menuNumber = short.Parse(Console.ReadLine());

            switch ( menuNumber )
            {
                case 1: Soma();
                break;

                case 2: Subtracao();
                break;

                case 3: Divisao();
                break;

                case 4: Multiplicacao();
                break;

                case 5: System.Environment.Exit(0); break;

                default: Menu();
                break;
            }

        }

        public static void Soma()
        {
            System.Console.Clear();

            Console.WriteLine("Digite um número: ");
            float n1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite outro número: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 + n2;

            System.Console.WriteLine($"O resultado da operação é igual a {resultado}");
            Console.ReadKey();
            Menu();

        }

        public static void Subtracao()
        {
            System.Console.Clear();

            Console.WriteLine("Digite um número: ");
            float n1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite outro número: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 - n2;

            System.Console.WriteLine($"O resultado da operação é igual a {resultado}");
            Console.ReadKey();
            Menu();

        }

        public static void Divisao()
        {
            System.Console.Clear();

            Console.WriteLine("Digite um número: ");
            float n1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite outro número: ");
            float n2 = float.Parse(Console.ReadLine());

            if( n2 == 0 )
            {
                Console.WriteLine("Não é possivel dividir um número por 0.");
            }
            else
            {
                float resultado = n1 / n2;
                System.Console.WriteLine($"O resultado da operação é igual a {resultado}");
                Console.ReadKey();
            }
            Menu();


        }

        public static void Multiplicacao()
        {
            System.Console.Clear();

            Console.WriteLine("Digite um número: ");
            float n1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite outro número: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 * n2;

            System.Console.WriteLine($"O resultado da operação é igual a {resultado}");
            Console.ReadKey();

            Menu();

        }
    }
}
