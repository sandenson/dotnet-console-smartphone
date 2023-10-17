using DesafioPOO.Models;

bool loop = true;
while (loop)
{
    Console.Clear();

    Console.WriteLine("Olá. Escolha uma marca de dispositivo para testar:");
    Console.WriteLine("1 - iPhone");
    Console.WriteLine("2 - Nokia");
    Console.WriteLine("3 - Sair");
    
    int opcao;
    while (true)
    {
        Console.WriteLine("\nDigite um dos números correspondentes para escolher uma opção:");

        if (int.TryParse(Console.ReadLine(), out opcao)) break;

        Console.WriteLine("Opção inválida! Tente novamente.");
    }
    
    try
    {
        switch (opcao)
        {
            case 1:
                Test.Iphone();
                break;
            case 2:
                Test.Nokia();
                break;
            default:
                loop = false;
                break;
        }
    }
    catch (Exception err)
    {
        Console.WriteLine($"\nOcorreu um erro: {err.Message}");
    }

    Console.WriteLine("\nAperte qualquer tecla para continuar.");
    Console.ReadKey();
}

Console.WriteLine("Até mais.");