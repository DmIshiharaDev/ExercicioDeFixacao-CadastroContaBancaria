using ExercicioDeFixacao_CadastroContaBancaria;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------- Banco Pimpão -------");

        Console.WriteLine();
        Console.Write("Entre com o número da conta (4 dígitos): ");
        int conta = int.Parse(Console.ReadLine());
        Console.Write("Entre com o nome do Titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)? ");
        char opcao = char.Parse(Console.ReadLine());

        CadastroConta c = new CadastroConta(conta, titular, opcao);

        Console.WriteLine();
        Console.WriteLine(c);
    }
}