<h1>
Bases da linguagem 
<img width="38" height="38" src="https://user-images.githubusercontent.com/59585859/172028663-4f118447-3888-44c0-95d6-fa0d850499d5.png">
</h1>



<h2>1.Declarando variáveis</h2>

<h3>Variável do tipo Número - <i>int ou float</i></h3>
Para armazenar uma variável do tipo inteiro você adiciona <code>int</code> antes dela:

```c#
int numero = 7;
```

Já se você quiser armazenar valores quebrados, a melhor opção é utilizar o <code>float</code>

```c#
float numero = 7.5f;
```
<b>obs:</b> sempre que você declarar uma variavel <code> float </code> você precisa adicionar um <code>f</code> após o último numero 


<h3>Variável do tipo Texto - <i>string</i> </h3>

Para declarar uma variável de texto, você precisa definir ela como <code>string</code>


```c#
string nome = "Gustavo";
```

<h2>2.Escrever algo na tela </h2>

para escrever algo no console do C# utilizamos o comando <code>Console.WriteLine();</code> e adicionamos o texto entre aspas(se for variável não utiliza aspas)

```c#
Console.WriteLine("Esse texto vai ser mostrado");
```

o comando acima mostra na tela o texto entre aspas - ou variável(não se utiliza aspas) - e automaticamente pula para a linha abaixo

caso você não queira pular para a linha de baixo, o melhor a fazer é utilizar a versão sem o <code>Line</code> ficando assim <code>Console.Write();</code> 

<h2>3.Ler oque o usuário digitar</h2>
para dar a oportunidade ao usuário de digitar alguma coisa, utilizamos o comando <code>Console.ReadLine();</code> 
por exemplo se quisermos que o usuário digite o seu nome podemos utilizar

```c#
string nome = Console.ReadLine(); 
```

geralmente o <code>Console.ReadLine();</code> vem acompanhado com o <code>Console.Write();</code> que pede para o usuário digitar alguma coisa: nesse caso ele pede o nome.

```c#
Console.Write("digite o seu nome: ");
string nome = Console.ReadLine(); 
```

<h3>Ler Números</h3>
o C# através do comando: <code>Console.ReadLine();</code> por padrão lê o valor digitado como <code>string</code>, então se você quiser ler valores do tipo <code>int</code>
você vai precisar converter esse valor utilizando o <code>int.Parse()</code>. você adiciona o <code>Console.ReadLine();</code> dentro dentro dele e ele passa a converter os
valores para <code>int</code>

```c#
int numero = int.Parse(Console.ReadLine());
```
caso você queira ler valores do tipo <code>float</code>(números quebrados) você só precisa mudar o <code>int</code> para <code>float</code> assim: <code>float.Parse</code>

```c#
float numero = float.Parse(Console.ReadLine());
```
 
<h2>4.Codicionais<h2>
  
<h3>IF</h3>
caso oque você declarar entre parentes seja verdadeiro, ele executa.
A aparência de um <code>if</code> é
  
```c#
int numero = 7;
  
if(numero > 8){
   Console.WriteLine("o número é maior doque 8");
  }
```

<h3>ELSE IF</h3>
caso a condição que você especificou para o primeiro <code>if</code> esteja falsa você pode fazer outra verificação utilizando o <code>else if</code>

```c#
int numero = 7; 
  
if(numero > 10){
   Console.WriteLine("o número é maior doque 10");
  }
  
else if(numero < 5){
   Console.WriteLine("o número é menor doque 5");
                    
  }
```
no codigo acima ele verifica no <code>if</code> se a variável <code>numero</code> é maior doque 10, como ela não é maior doque 10(porque o valor da variavel é 7) ele segue 
para o <code>if else</code> que faz a verificação se a variável <code>numero</code> é menor doque 5.
  
nesse caso a variável numero não se encaixa em nenhum dos dois, então poderiamos adicionar um <code>else</code> algo equivalente a palavra senão em português
  
  
<h3>Else</h3>

o <code>else</code> vai ser executado quando nenhum dos seus <code>if</code> e <code>else if</code> forem verdadeiros
```c#
int numero = 7; 
  
if(numero > 10){
   Console.WriteLine("o número é maior doque 10");
  }
  
else if(numero < 5){
   Console.WriteLine("o número é menor doque 5");
                    
  }
                    
else{
    Console.WriteLine("o número não é maior doque 10 nem menor doque 5")
    }
```
no caso acima nenhuma das duas é verdadeira, pois <code>numero = 7 </code> logo, o programa vai ignorar oque estiver no <code>if</code> e no <code>else if</code> e vai executar oque estiver
no <code>else</code>
              
