<h1>
Bases da linguagem 
<img width="38" height="38" src="https://user-images.githubusercontent.com/59585859/172028663-4f118447-3888-44c0-95d6-fa0d850499d5.png">
</h1>



<h2>5.Laços de Repetição</h2>

<h3>While</h3>
A primeira forma de laços de repetição que encontramos é o while(while significa enquanto em português). Sua função é executar um codigo específico enquanto algo for verdadeiro
por exemplo: 
no codigo abaixo você pode ver um programa de adivinhação de número. O programa inicia pedindo para o usuário digitar um número, e salva este número
uma variável <code>b</code> , logo abaixo é criado um laço de repetição <code>while</code>.
  

```c#
int A = 10;
    
Console.Write("digite um número: ");
int B = int.Parse(Console.ReadLine());

while(A != B){
	Console.WriteLine("você errou o número");
	B = int.Parse(Console.ReadLine());
}
	
Console.WriteLine("você acertou o número");  
```



Dentro dos parênteses do while ele passa uma especificação <code> A != B </code>(podemos ler como: enquanto A for diferente de B) e enquanto isso for verdadeiro ele executa o codigo dentro
das chaves <code>{ }</code>. 

Nesse caso ele escreve na tela que o usuário errou o número, e da mais uma oportunidade de tentar adivinhar.

 resumindo: o programa vai ficar repetindo: <b>Você errou o número</b> até que o usuário acerte. Quando o usuário acerta ele sai de dentro do while e continua 
 a execução do codigo abaixo, nesse caso: <code> Console.WriteLine("você acertou o número"); </code>
 
<p>
outra possibilidade de utilização do while é o <code>while(true)</code> que roda o codigo infinitamente, até você decidir parar ele utilizando o comando 
<code> break </code>
</p>

<h3>For</h3>

o For é utilizando quando você sabe o número de execuções que você precisa, como por exemplo: você precisa escrever os números de 0 a 10.

para criar um For você segue a seguinte estrutura <code>for(iniciador; condição; iterador)</code> 

```c#
for(int contador = 1; contador <= 10; contador++){
	Console.WriteLine(contador);
	
}
```
<h3>
- Iniciador
</h3>
Criamos uma variável do tipo inteiro chamada <code>contador</code> que começa com o valor 1. 
<h3>
- Condição
</h3>
Dizemos para ele executar enquanto <code>contador</code> for menor ou igual a 10.
<h3>
- Iterador
</h3>
Adicionamos mais 1 ao valor da variável contador.
<h3></h3>
Ou seja, ele mostra o valor do contador na tela e logo em seguida aumenta o valor do contador, ele vai rodar isso enquanto a condição for verdadeira. 

o resultado no console é esse:


```c#
1
2
3
4
5
6
7
8
9
10
```
