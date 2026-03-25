# 🤖 Robô Tupiniquim I

![.NET](https://img.shields.io/badge/.NET-6.0-blue)
![C#](https://img.shields.io/badge/C%23-Console-green)
![Status](https://img.shields.io/badge/status-concluído-brightgreen)

Aplicação console desenvolvida em **C#** que simula a movimentação de um robô em um plano cartesiano (grid), com base em comandos fornecidos pelo usuário.

---

## 🚀 Demonstração

<p align="center">
  <img src="https://raw.githubusercontent.com/ThiaggoSylva/roboTupiniquim/main/docs/demo.gif" width="600"/>
</p>

---

## 📋 Descrição

O programa permite controlar um robô informando:

- Posição inicial (`X`, `Y`)
- Direção inicial (`N`, `S`, `L`, `O`)
- Sequência de comandos (`E`, `D`, `M`)

Cada comando é processado individualmente e, ao final, a posição do robô é exibida no console.

---

## 🧭 Direções

| Letra | Significado |
|------|------------|
| `N` | Norte |
| `S` | Sul |
| `L` | Leste |
| `O` | Oeste |

---

## 🎮 Comandos

| Comando | Ação |
|--------|------|
| `E` | Gira o robô 90° para a esquerda |
| `D` | Gira o robô 90° para a direita |
| `M` | Move o robô 1 posição para frente |

---

## ⚙️ Funcionamento

### 🔹 Fluxo principal (`Program.cs`)

```csharp
Robo robo = ObterPosicaoInicial();
string comandos = ObterComandos();

ExecutarComandos(robo, comandos);

ExibirPosicaoFinal(robo);

🔹 Entrada de dados

Formato esperado:
X Y Direção

Exemplo:
1 2 N

Comandos:
EMEMEMEMM

🧠 Estrutura das Classes
🧍 Classe Robo

public class Robo
{
    public int X;
    public int Y;
    public char Direcao;

    public Robo(int x, int y, char direcao)
    {
        X = x;
        Y = y;
        Direcao = direcao;
    }
}

🔄 Classe MovimentacaoRobo
Execução de comandos

if (comando == 'E')
    robo.Direcao = VirarEsquerda(robo.Direcao);

else if (comando == 'D')
    robo.Direcao = VirarDireita(robo.Direcao);

else if (comando == 'M')
    Mover(robo);

Movimento

switch (robo.Direcao)
{
    case 'N': robo.Y++; break;
    case 'S': robo.Y--; break;
    case 'L': robo.X++; break;
    case 'O': robo.X--; break;
}

Rotação

Direita (D):
N → L → S → O → N

Esquerda (E):
N → O → S → L → N

▶️ Exemplo de Execução

Digite a posição inicial (X Y Direção):
1 2 N

Digite a sequência de comandos:
EMEMEMEMM

Posição alcançada: 1 3 N

📂 Estrutura do Projeto

roboTupiniquim/
 ├── Program.cs
 ├── MovimentacaoRobo.cs
 ├── Robo.cs
 └── docs/
      └── demo.gif

🚀 Como Executar

git clone https://github.com/ThiaggoSylva/roboTupiniquim.git
cd roboTupiniquim
dotnet run

🧠 Conceitos Aplicados
> Programação Orientada a Objetos (POO)
> Separação de responsabilidades
> Métodos estáticos
> Estruturas condicionais (if, switch)
> Laço de repetição (foreach)
> Entrada e saída via console

📈 Melhorias Futuras
 . Encapsular atributos da classe Robo
 . Validar entrada do usuário
 . Tratar comandos inválidos
 . Definir limites do grid
 . Criar testes automatizados

 👨‍💻 Autor

Thiago Silva

📄 Licença

Projeto desenvolvido para fins educacionais.

⭐ Destaque

Este projeto demonstra habilidades em:

Lógica de programação
Organização de código
Estruturação de aplicações em C#

Ideal como projeto de portfólio para iniciantes 🚀