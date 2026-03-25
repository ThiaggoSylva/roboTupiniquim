namespace roboTupiniquim.ConsoleApp;

public static class MovimentacaoRobo
{
    public static void ExecutarComando(Robo robo, char comando)
    {
        if (comando == 'E')
            robo.Direcao = VirarEsquerda(robo.Direcao);

        else if (comando == 'D')
            robo.Direcao = VirarDireita(robo.Direcao);

        else if (comando == 'M')
            Mover(robo);
    }

    static void Mover(Robo robo)
    {
        switch (robo.Direcao)
        {
            case 'N':
                robo.Y++;
                break;

            case 'S':
                robo.Y--;
                break;

            case 'L':
                robo.X++;
                break;

            case 'O':
                robo.X--;
                break;
        }
    }

    static char VirarDireita(char direcao)
    {
        switch (direcao)
        {
            case 'N': return 'L';
            case 'L': return 'S';
            case 'S': return 'O';
            case 'O': return 'N';
            default: return direcao;
        }
    }

    static char VirarEsquerda(char direcao)
    {
        switch (direcao)
        {
            case 'N': return 'O';
            case 'O': return 'S';
            case 'S': return 'L';
            case 'L': return 'N';
            default: return direcao;
        }
    }
}
