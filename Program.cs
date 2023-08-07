using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogodavelha
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz do jogo da velha
            char[,] mvelha = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

            Console.WriteLine("Bem-vindo ao jogo da velha!");
            Console.WriteLine("\nO jogador número 1 usará 'O' e o jogador 2 o 'X'.");

            //for que simula o jogo
            for (int v = 0; v < mvelha.Length; v++)
            {               

                //jogada do player 1
                Console.WriteLine("\n----- Vez do jogador 1 -----\n");

                //for que imprime o hash para o jogador ver
                for (int i = 0; i < mvelha.GetLength(0); i++)
                {
                    for (int j = 0; j < mvelha.GetLength(1); j++)
                    {
                        Console.Write(mvelha[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.Write("\nEscolha um número de 1 a 9: \n");
                char jogadaP1 = char.Parse(Console.ReadLine());

                


                if (mvelha[0, 0] != 'X' && mvelha[0, 0] != 'X' && jogadaP1 == '1')
                {
                    mvelha[0, 0] = 'O';
                }
                else if (mvelha[0, 1] != 'X' && mvelha[0, 1] != 'X' && jogadaP1 == '2')
                {
                    mvelha[0, 1] = 'O';
                }
                else if (jogadaP1 == '3')
                {
                    mvelha[0, 2] = 'O';
                }
                else if (jogadaP1 == '4')
                {
                    mvelha[1, 0] = 'O';
                }
                else if (jogadaP1 == '5')
                {
                    mvelha[1, 1] = 'O';
                }
                else if (jogadaP1 == '6')
                {
                    mvelha[1, 2] = 'O';
                }
                else if (jogadaP1 == '7')
                {
                    mvelha[2, 0] = 'O';
                }
                else if (jogadaP1 == '8')
                {
                    mvelha[2, 1] = 'O';
                }
                else if (jogadaP1 == '9')
                {
                    mvelha[2, 2] = 'O';
                }
                else
                {
                    Console.WriteLine("Número inválido!");
                    break;
                }

                //ver se alguém ganhou
                if (mvelha[0, 0] == mvelha[0, 1] && mvelha[0, 1] == mvelha[0, 2] || mvelha[1, 0] == mvelha[1, 1] && mvelha[1, 1] == mvelha[1, 2] || mvelha[2, 0] == mvelha[2, 1] && mvelha[2, 1] == mvelha[2, 2]
                    || mvelha[0, 0] == mvelha[1, 0] && mvelha[1, 0] == mvelha[2, 0] || mvelha[0, 1] == mvelha[1, 1] && mvelha[1, 1] == mvelha[2, 1] || mvelha[0, 2] == mvelha[1, 2] && mvelha[1, 2] == mvelha[2, 2]
                    || mvelha[0, 0] == mvelha[1, 1] && mvelha[1, 1] == mvelha[2, 2] || mvelha[0, 2] == mvelha[1, 1] && mvelha[1, 1] == mvelha[2, 0])
                {
                    Console.WriteLine("\nParabéns pela vitória, jogador 1!");
                     break;
                }
                else if (v == 9)
                {
                    Console.WriteLine("\nEmpate");
                    break;
                }
                
                //verificação

                /*if (mvelha[0, 0] == 'X' || mvelha[0, 1] == 'X' ||mvelha[0, 2] == 'X')
                {
                    Console.WriteLine("Ops, tente outra posição de 1 a 9: ");
                    jogadaP1 = char.Parse(Console.ReadLine());
                }*/

                //um if que se o que for escrito for o O e X dependendo de quem joga, ele pede pra inserir outro
                //precisa fazer um ngc de verificação, pensei em fazer assim, se a jogada for O
                // e o player 2 colocar na mesma casa, pede pra escolher outro numero pq esse n pode

                

                

                

                //jogada do player 2
                Console.WriteLine("\n----- Vez do jogador 2-----\n");

                for (int i = 0; i < mvelha.GetLength(0); i++)
                {
                    for (int j = 0; j < mvelha.GetLength(1); j++)
                    {
                        Console.Write(mvelha[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.Write("\nEscolha um número de 1 a 9: \n");

                char jogadaP2 = char.Parse(Console.ReadLine());

                if (jogadaP2 == '1')
                {
                    mvelha[0, 0] = 'X';
                }
                else if (jogadaP2 == '2')
                {
                    mvelha[0, 1] = 'X';
                }
                else if (jogadaP2 == '3')
                {
                    mvelha[0, 2] = 'X';
                }
                else if (jogadaP2 == '4')
                {
                    mvelha[1, 0] = 'X';
                }
                else if (jogadaP2 == '5')
                {
                    mvelha[1, 1] = 'X';
                }
                else if (jogadaP2 == '6')
                {
                    mvelha[1, 2] = 'X';
                }
                else if (jogadaP2 == '7')
                {
                    mvelha[2, 0] = 'X';
                }
                else if (jogadaP2 == '8')
                {
                    mvelha[2, 1] = 'X';
                }
                else if (jogadaP2 == '9')
                {
                    mvelha[2, 2] = 'X';
                }

                

                //ver se alguém ganhou
                if (mvelha[0,0] == mvelha[0,1] && mvelha[0, 1] == mvelha[0, 2] || mvelha[1, 0] == mvelha[1, 1] && mvelha[1, 1] == mvelha[1, 2] || mvelha[2, 0] == mvelha[2, 1] && mvelha[2, 1] == mvelha[2, 2]
                    || mvelha[0, 0] == mvelha[1, 0] && mvelha[1, 0] == mvelha[2, 0] || mvelha[0, 1] == mvelha[1, 1] && mvelha[1, 1] == mvelha[2, 1] || mvelha[0, 2] == mvelha[1, 2] && mvelha[1, 2] == mvelha[2, 2]
                    || mvelha[0, 0] == mvelha[1, 1] && mvelha[1, 1] == mvelha[2, 2] || mvelha[0, 2] == mvelha[1, 1] && mvelha[1, 1] == mvelha[2, 0])
                {
                    Console.WriteLine("\nParabéns pela vitória, jogador 2!");
                    break;
                }
                else if (v == 9)
                {
                    Console.WriteLine("\nEmpate");
                    break;
                }
                
               












            }


            Console.ReadLine();

            /*Console.Write("Insira a linha de 0 a 8");
                string strJogadaP1Linha = Console.ReadLine();
                if (!char.TryParse(strJogadaP1Linha, out char JogadaP1Linha))
                {
                    Console.WriteLine("Valor inválido!");
                    Environment.Exit(-1);
                }

                Console.Write("Insira a coluna de 0 a 8");
                string strJogadaP1Coluna = Console.ReadLine();
                if (!char.TryParse(strJogadaP1Coluna, out char JogadaP1Coluna))
                {
                    Console.WriteLine("Valor inválido!");
                    Environment.Exit(-1);
                }*/
        }
    }
}
