using System;
namespace DojoPOO
{


    public class Jogador
    {
        public string Time { get; set; }

        public int Idade { get; set; }
        
        public string Nome { get; set; }

        public string Posicao { get; set; }

        public DateTime Nascimento { get; set; }

        public string Pais { get; set; }
        
        public float Altura { get; set; }
        
        public float Peso { get; set; }

        public int Aposentar { get; set; }

        

    
        public void MostrarDadosJogador(){
            Console.WriteLine($"O nome do jogador é: {Nome}, A posição que o jogador atua é:{Posicao}, O jogador nasceu: {Nascimento}, A nacionalidade dele é: {Pais}, A altura dele é {Altura}, O peso dele é {Peso}");
         
        }

        public int CalcularDataAno(DateTime anoInicial, DateTime anoFinal){ 

            int AnoIni = Int32.Parse( anoFinal.ToString().Split("/")[2].Split(" ")[0] );            
            int AnoFim = Int32.Parse( anoInicial.ToString().Split("/")[2].Split(" ")[0] );

            Idade = AnoIni - AnoFim;

            return Idade;
        }

        public string MostrarAposentadoria(){

            string Retornar = "";
            
            if(Idade >= 35 && Posicao == "Atacante"){
                Retornar = $"O {Nome} pode se aposentar";
            }
            else if(Idade >= 38 && Posicao == "Meio Campo"){
                Retornar = $"O {Nome} pode se aposentar";
            }
            else if(Idade >= 40 && Posicao == "Defensor"){
                Retornar = $"O {Nome} pode se aposentar";
            } else{
                MostrarIdadeAposentadoria();
                int restante = Aposentar - Idade;
                Retornar = $"O(A) jogador(a) {Nome} ainda faltam {restante} anos para se aposentar";
            }

            return Retornar;

        }


        public void MostrarIdadeAposentadoria(){

            switch (Posicao)
            {

                case "Atacante":
                Aposentar = 35;
                break;

                case "Meio Campo":
                Aposentar = 38;
                break;

                case "Defensor":
                Aposentar = 40;
                break;
                
                default:
                Aposentar = 40;
                break;
            }

        }
           
                
            
        
       

    
    }
    
}
