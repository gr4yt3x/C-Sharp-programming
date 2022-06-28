<h1>
Lógica de Movimentação 3x3
</h1>


Esse programa simples é uma proposta de desafio onde o usuário pode se mover em algumas direções especificas, movendo-se entre as casas de 1 a 9.


<img src="https://user-images.githubusercontent.com/59585859/176085569-dd577071-e165-4381-952a-1d5decc77370.png" width="300" height="200">

você só pode andar uma casa por vez, e apenas em formato de cruz.

por exemplo:

Caso você esteja na <code>posição 1</code> seus movimentos disponíveis são 2 e 4

Caso você esteja na <code>posição 2</code> seus movimentos disponíveis são 1, 5 e 3

<b>obs:</b> <i>sempre se movendo em formato de cruz</i>



<br>
<b>
Esse é um ótimo desafio para desenvolver as habilidades de condicionais, pois existem três grupos de casas:
</b>

1. os que podem mover em 2 direções diferentes(1, 3, 7 e 9)
2. os que podem mover em 3 direções diferentes(2, 4, 6, 8)
3. os que podem mover em 4 direções diferentes(5)

<br>
<h2>SWITCH</h2>
no desenvolvimento desse programa foi utilizado a condicional <b>*SWITCH CASE*</b> para deixar o código menor e mais agradável para leitura.

o switch pega o parametro <code>posicao</code> e executa um codigo dentro de cada caso(<i>case</i>)

```cs
switch (posicao) {
        case 1:
          Console.WriteLine("[1] ir para 2");
          Console.WriteLine("[2] ir para 4");

          acao = int.Parse(Console.ReadLine());
          if (acao == 1) {
            posicao = 2;
          } else if (acao == 2) {
            posicao = 4;
          }
          break;

```

acima temos o codigo executado caso a posição seja 1. 

<b>O programa está todo estruturado com o switch dentro de um <code>while(true)</code> - while infinito.</b>

a condicional(switch case) está constantemente verificando qual a posição atual do usuário. Baseado nessa posição ele mostra os movimentos possiveis.

<br>
para entender como o switch funciona: 

[clique aqui](https://github.com/gr4yt3x/C-Sharp-programming/blob/main/switch_case.md)

<br>
<h2>principais funcionalidades do programa:</h2>

- Mostra sua posição atual
- Pergunta qual posição você deseja ir
- Move para essa posição 

