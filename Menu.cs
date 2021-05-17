using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GrafosFinal
{
    class Menu
    {       
        public static void ShowMenu()
        {
            Console.WriteLine("\n*****************************************************");
            Console.WriteLine("                  Controle de Antenas");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("   Digite 1 - Conectar (x) usuários a rede  ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("   Digite 2 -  Status da Rede  ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("   Digite 3  -Imprimir status detalhado da rede   ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("   Digite 9 para limpar a tela   ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("   Digite 0 - Para finalizar   ");

        }
        public static void MenuActions (int op)
        {
            
            if (op == 1)
            {
                Console.Clear();
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Status Antenas - ANTES da inserção\n");
                Grafo.MostrarGrafo();
                Console.WriteLine("*****************************************************");
                Console.WriteLine(" Conectar usuário(s) a rede   ");
                Console.WriteLine("*****************************************************");
                Grafo.EscolherBairro();
                Console.WriteLine("\nStatus Antenas - APOS  inserção");
                Grafo.MostrarGrafo();                
            }
            else if (op == 2 )
            {
                Console.Clear();
                Console.WriteLine("Status Detalhado das Antenas \n");
                Grafo.MostrarGrafo();
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*            Status da Rede - Quantidade de usuários X capacidade");
                Console.WriteLine("*****************************************************");
                //Grafo.EscolherBairro();
                //Console.WriteLine("\nStatus Antenas - APOS  inserção");
                //Grafo.MostrarGrafo();
                Grafo.StatusRede();
            }
            else if (op == 3 )
            {
                Console.Clear();
                Console.WriteLine("*****************************************************");
                Console.WriteLine("*    Imprimir Status detalhado da Rede (Antenas)*");
                Console.WriteLine("*****************************************************");
                Grafo.MostrarGrafo();
            }
            else if (op == 9)
            {
                Console.Clear();
            }
                       
        }
    }

}

