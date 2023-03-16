using System;
using System.Linq;

namespace DiamanteComLetra
{
    class Program
    {
        static void Main(string[] args)
        {
            const string SAIR = "S";
            string respostaSAIR = "";

            while (respostaSAIR.ToUpper() != SAIR)
            {
                int linha = 1;
                int letraEmInt = 65;
                Console.WriteLine("\n------------------");

                

                Console.WriteLine("Até Qual Letra vai o Diamante: ");
                char char1 = Convert.ToChar(Console.ReadLine());
                int tamanho = Convert.ToInt32(char1) - 65;

                string charParaString = Convert.ToString(char1);
                bool isNumeric = charParaString.All(char.IsDigit);

                if (isNumeric)
                {
                    Console.WriteLine("Erro: O valor deve ser letra...");
                    continue;
                }




                #region Pra Cima
                for (int i = 1; tamanho > 0; i++)
                {

                    for (int j = 1; j <= tamanho; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= linha; j++)
                    {
                        if (j == 1 || j == linha)
                        {
                            Console.Write(Convert.ToChar(letraEmInt));
                        }
                        Console.Write(" ");
                    }

                    tamanho--;
                    linha += 2;
                    letraEmInt += 1;
                    Console.WriteLine("");

                }
                #endregion

                #region Pra Baixo
                for (int i = 1; linha > 0; i++)
                {

                    for (int j = 1; j <= tamanho; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= linha; j++)
                    {
                        if (j == 1 || j == linha)
                        {
                            Console.Write(Convert.ToChar(letraEmInt));
                        }
                        Console.Write(" ");
                    }

                    tamanho++;
                    linha -= 2;
                    letraEmInt -= 1;
                    Console.WriteLine("");
                    
                }
                #endregion

                Console.WriteLine("Sair S/N");
                respostaSAIR = Console.ReadLine();

            }
            Console.ReadLine();
        }
    }
}
