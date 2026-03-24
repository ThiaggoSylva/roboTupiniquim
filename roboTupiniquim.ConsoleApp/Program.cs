using System.Runtime.CompilerServices;

namespace roboTupiniquim.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        /*
            solicita ao usuário a posição do robô
            Exemplo de entrada: 1 2 N
        */
        Console.WriteLine("Digite a posição inicial (X,Y,Direção): ");
        string[] posicaoInicial = Console.ReadLine()!.Split(' ');

        //Converte os valores par as variaveis
        int X = int.Parse(posicaoInicial[0]);
        int Y = int.Parse(posicaoInicial[1]);
        char direcao = char.Parse(posicaoInicial[2].ToUpper());

        //solicita ao usuário a sequencia de comandos
        Console.Write("Digite a sequência de comandos: ");
        string comandos = Console.ReadLine()!.ToUpper();

        //percorre cada comando da sequencia
        foreach (char comando in comandos)
        {
            //se o comando for E, o robô vira a esquerda
            if (comando == 'E')
                direcao = virarEsquerda(direcao);

            //caso o comando seja D, o robô vira para a direita
            else if (comando == 'D')
                direcao = virarDireita(direcao);

            //se o comando for M, o robô avança uma possição
            else if (comando == 'M')
                Mover(ref X, ref Y, direcao);
        }

        //Mostra a Posição alcançada do robô
        Console.WriteLine($"Posição alcançada: {X} {Y} {direcao}");
    }

    //Metodo que move o robô
    static void Mover(ref int x, ref int y, char direcao)
    {
        switch (direcao)
            {
                // Se estiver apontando para Norte, aumenta o Y
                case 'N':
                    y++;
                    break;

                // Se estiver apontando para Sul, diminui o Y
                case 'S':
                    y--;
                    break;

                // Se estiver apontando para Leste, aumenta o X
                case 'L':
                    x++;
                    break;

                // Se estiver apontando para Oeste, diminui o X
                case 'O':
                    x--;
                    break;
            };
    }

    //Metodo que vira o robô 90° para a direita
    static char virarDireita(char direcao)
    {
        switch (direcao)
        {
            // Se estiver para Norte, ao virar à direita ficará para Leste
            case 'N': return 'L';

            // Se estiver para Leste, ao virar à direita ficará para Sul
            case 'L': return 'S';

            // Se estiver para Sul, ao virar à direita ficará para Oeste
            case 'S': return 'O';

            // Se estiver para Oeste, ao virar à direita ficará para Norte
            case 'O': return 'N';

            // Caso não seja nenhuma direção válida, retorna a mesma direção
            default: return direcao;
        }
    }

    //Metodo que vira o robô 90° para a Esquerda

    static char virarEsquerda(char direcao)
    {
        switch (direcao)
        {
            //se tiver apontando para o Norte ao virar a esquerda apontará para o Oeste
            case 'N': return 'O';
            //se tiver apontando para o Oeste ao virar a esquerda apontará para o Sul
            case 'O': return 'S';
            //se tiver apontando para o Sul ao virar a esquerda apontará para o Leste
            case 'S': return 'L';
            //se tiver apontando para o Leste ao virar a esquerda apontará para o Norte
            case 'L': return 'N';
            //Caso não seja nenhuma direção valida, retorna a mesma direção
            default: return direcao;
        }
    }
}
