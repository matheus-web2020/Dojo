using System;

namespace DojoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
          Jogador Almeida = new Jogador();
          Almeida.Nome = "Almeida";
          Almeida.Posicao = "Atacante";
          Almeida.Nascimento = DateTime.Parse( "08/01/2004" );
          Almeida.Idade = Almeida.CalcularDataAno( Almeida.Nascimento , DateTime.Now );
          System.Console.WriteLine(Almeida.MostrarAposentadoria());
          System.Console.WriteLine("Pegando dados do Próximo jogador...");
          System.Threading.Thread.Sleep(5000);
          System.Console.WriteLine("");

          Jogador Fusca = new Jogador();
          Fusca.Nome = "Matheus";
          Fusca.Posicao = "Defensor";
          Fusca.Nascimento = DateTime.Parse( "06/07/2004" );
          Fusca.Idade = Fusca.CalcularDataAno( Fusca.Nascimento , DateTime.Now );
          System.Console.WriteLine(Fusca.MostrarAposentadoria());
          System.Console.WriteLine("Pegando dados do Próximo jogador...");
          System.Threading.Thread.Sleep(5000);
          System.Console.WriteLine("");
         
          

          Jogador Samanta = new Jogador();
          Samanta.Nome = "Samanta";
          Samanta.Posicao = "Meio Campo";
          Samanta.Nascimento = DateTime.Parse( "17/09/2002" );
          Samanta.Idade = Samanta.CalcularDataAno( Samanta.Nascimento , DateTime.Now );
          System.Console.WriteLine(Samanta.MostrarAposentadoria());
          System.Threading.Thread.Sleep(1000);
          
          

        }
    }
}
