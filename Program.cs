
using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

// Tratamento para preço inicial
bool precoInicialValido = false;
while (!precoInicialValido)
{
    try
    {
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                          "Digite o preço inicial:");
        string inputPrecoInicial = Console.ReadLine();
        precoInicial = Convert.ToDecimal(inputPrecoInicial);
        precoInicialValido = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Digite um valor numérico válido para o preço inicial.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Erro: O valor digitado é muito grande. Tente um valor menor.");
    }
}

// Tratamento para preço por hora
bool precoPorHoraValido = false;
while (!precoPorHoraValido)
{
    try
    {
        Console.WriteLine("Agora digite o preço por hora:");
        string inputPrecoPorHora = Console.ReadLine();
        precoPorHora = Convert.ToDecimal(inputPrecoPorHora);
        precoPorHoraValido = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Digite um valor numérico válido para o preço por hora.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Erro: O valor digitado é muito grande. Tente um valor menor.");
    }
}

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);


string opcao = string.Empty;
bool exibirMenu = true;


while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");