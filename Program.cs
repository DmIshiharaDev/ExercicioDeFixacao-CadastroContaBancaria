using ExercicioDeFixacao_CadastroContaBancaria;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)

    {
        CadastroConta conta; 

        Console.WriteLine("------- Banco Pimpão -------");

        Console.WriteLine();
        Console.Write("Entre com o número da conta (4 dígitos): ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre com o nome do Titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)? ");
        char opcao = char.Parse(Console.ReadLine());

        if (opcao == 's' || opcao == 'S')
        { 
            Console.Write("Entre com o valor do depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new CadastroConta (numero, titular, depositoInicial);
        }
        else
        {
            conta = new CadastroConta(numero, titular);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta: \n" + conta);

        Console.WriteLine();
        Console.Write("Entre com um valor de depósito: $");
        double deposito = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.valorDeposito(deposito);
        Console.WriteLine("Dados da conta atualizado: \n" + conta);

        Console.WriteLine();
        Console.Write("Entre com um valor de saque: $");
        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.valorSaque (saque);
        Console.WriteLine("Dados da conta atualizado: \n" + conta);
    }
}