# Jogo da Forca

![](https://i.imgur.com/98HKJ1s.gif)

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2025

## Detalhes

O computador escolherá, de maneira aleatória, uma palavra entre várias possibilidades*, e o jogador deve chutar, letra por letra, até adivinhá-la.

Se o jogador chutar mais de 6 letras erradas, ele perde.

## Entrada

Os jogadores são solicitados a inserir uma letra por vez através do console. Se a letra estiver presente na palavra, ela será revelada nas posições correspondentes. Se a letra não estiver presente na palavra, uma parte do boneco da forca será desenhada.

## Funcionalidades

- __Escolha de Palavra Secreta__: Uma palavra é escolhida aleatoriamente no início de cada jogo.
- __Representação da Forca__: A forca é desenhada progressivamente no console, com cada erro do jogador.
- __Feedback Visual__: As letras corretamente adivinhadas são exibidas na posição correta, enquanto as não descobertas permanecem ocultas.
- __Contagem de Erros__: O jogo acompanha o número de erros cometidos pelo jogador e termina quando o máximo permitido é alcançado.
- __Dicas__: Quando se era muitas vezes, se ganha uma dica da palavra.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
## Como Usar

#### Clone o Repositório
```
git clone https://github.com/academiadoprogramador-fullstack/jogo-da-forca-2025.git
```

#### Navegue até a pasta raiz da solução
```
cd jogo-da-forca-2025
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
cd JogoDaForca.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```
