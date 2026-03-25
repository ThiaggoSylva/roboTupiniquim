using System.Runtime.CompilerServices;

namespace roboTupiniquim.ConsoleApp;


class Program
{
    static void Main(string[] args)
    {
        Robo robo = ObterPosicaoInicial();

        string comandos = ObterComandos();

        ExecutarComandos(robo, comandos);

        ExibirPosicaoFinal(robo);
    }

    static Robo ObterPosicaoInicial()
    {
        Console.WriteLine("Digite a posição inicial (X Y Direção): ");
        string[] entrada = Console.ReadLine()!.Split(' ');

        int x = int.Parse(entrada[0]);
        int y = int.Parse(entrada[1]);
        char direcao = char.Parse(entrada[2].ToUpper());

        return new Robo(x, y, direcao);
    }

    static string ObterComandos()
    {
        Console.Write("\nDigite a sequência de comandos: ");
        return Console.ReadLine()!.ToUpper();
    }

    static void ExecutarComandos(Robo robo, string comandos)
    {
        foreach (char comando in comandos)
        {
            MovimentacaoRobo.ExecutarComando(robo, comando);
        }
    }

    static void ExibirPosicaoFinal(Robo robo)
    {
        Console.WriteLine($"\nPosição alcançada: {robo.X} {robo.Y} {robo.Direcao}");
    }
}