using System;

public class HelloWorld {
  public static void Main(string[] args) {

    int posicao = 1;
    int acao;
    while (true) {
      Console.Clear();
      Console.WriteLine("1-2-3");
      Console.WriteLine("4-5-6");
      Console.WriteLine("7-8-9\n");

      Console.WriteLine("[sua posição é {0}]", posicao);

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

        case 2:
          Console.WriteLine("[1] ir para 1");
          Console.WriteLine("[2] ir para 3");
          Console.WriteLine("[3] ir para 5");

          acao = int.Parse(Console.ReadLine());
          if (acao == 1) {
            posicao = 1;
          } else if (acao == 2) {
            posicao = 3;
          } else if (acao == 3) {
            posicao = 5;
          }
          break;

        case 3:
          Console.WriteLine("[1] ir para 2");
          Console.WriteLine("[2] ir para 6");

          acao = int.Parse(Console.ReadLine());
          if (acao == 1) {
            posicao = 2;
          } else if (acao == 2) {
            posicao = 6;
          }
          break;

        case 4:
          Console.WriteLine("[1] ir para 1");
          Console.WriteLine("[2] ir para 5");
          Console.WriteLine("[3] ir para 7");

          acao = int.Parse(Console.ReadLine());
          if (acao == 1) {
            posicao = 1;
          } else if (acao == 2) {
            posicao = 5;
          } else if (acao == 3) {
            posicao = 7;
          }
          break;

        case 5:
          Console.WriteLine("[1] ir para 4");
          Console.WriteLine("[2] ir para 2");
          Console.WriteLine("[3] ir para 6");
          Console.WriteLine("[4] ir para 8");

          acao = int.Parse(Console.ReadLine());
          if (acao == 1) {
            posicao = 4;
          } else if (acao == 2) {
            posicao = 2;
          } else if (acao == 3) {
            posicao = 6;
          } else if (acao == 4) {
            posicao = 8;
          }
          break;

        case 6:
          Console.WriteLine("[1] ir para 3");
          Console.WriteLine("[2] ir para 5");
          Console.WriteLine("[3] ir para 9");

          acao = int.Parse(Console.ReadLine());
          if (acao == 1) {
            posicao = 3;
          } else if (acao == 2) {
            posicao = 5;
          } else if (acao == 3) {
            posicao = 9;
          } else if (acao == 2) {
            posicao = 4;
          }
          break;

        case 7:
          Console.WriteLine("[1] ir para 4");
          Console.WriteLine("[2] ir para 8");

          acao = int.Parse(Console.ReadLine());
          if (acao == 1) {
            posicao = 4;
          } else if (acao == 2) {
            posicao = 8;
          }
          break;

        case 8:
          Console.WriteLine("[1] ir para 7");
          Console.WriteLine("[2] ir para 5");
          Console.WriteLine("[3] ir para 9");

          acao = int.Parse(Console.ReadLine());
          if (acao == 1) {
            posicao = 7;
          } else if (acao == 2) {
            posicao = 5;
          } else if (acao == 3) {
            posicao = 9;
          }
          break;

        case 9:
          Console.WriteLine("[1] ir para 8");
          Console.WriteLine("[2] ir para 6");
          acao = int.Parse(Console.ReadLine());
          if (acao == 1) {
            posicao = 6;
          } else if (acao == 2) {
            posicao = 8;
          }
          break;
      }
    }
  }
}
