using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace GrafosFinal
{
    class Grafo
    {
        private static List<Vertice>[] GrafoLista;

        private static Vertice VerticeGrafo;
        static public void Leitor()
        {
            StreamReader arquivo = new StreamReader("arquivo.txt");
            GrafoLista = new List<Vertice>[int.Parse(arquivo.ReadLine())];
            arquivo.ReadLine();
            GrafoLista[0] = new List<Vertice>();
            string linha;
            string[] vetorLinha;

            while (!arquivo.EndOfStream)
            {
                linha = arquivo.ReadLine();
                vetorLinha = linha.Split(';');
                Vertice verticeAuxiliar = new Vertice(vetorLinha[0], int.Parse(vetorLinha[1]), vetorLinha[2]);
                GrafoLista[0].Add(verticeAuxiliar);
            }
            arquivo.Close();
        }
        public static void EscolherBairro()
        {
            int op;
            Console.WriteLine("Informe a quantidade de usuários que deseja conectar: ");
            op = Convert.ToInt32(Console.ReadLine());

            Processing();

            Console.WriteLine("Digite 1 para bairro Belmonte: ");
            string opcao = Console.ReadLine();  //uso local

            Processing();

            for (int i = 0; i < op; i++)
            {
                if (CheckStatusRede())
                {
                    ConectarUsuario(opcao);
                }
                else
                {
                    Console.WriteLine("***Atenção******Atenção******Atenção******Atenção***");
                    Console.WriteLine("                  \nRede cheia");
                    Console.WriteLine("****************************************************");
                    Console.WriteLine("               {0} - Tentativas de conexão falharam", op - i);
                    break;
                }

            }
        }
        public static void ConectarUsuario(string opcao)
        {


            if (opcao == "1")
            {
                int maiorSinal = 0;
                string codAnt = "";
                foreach (Vertice a in GrafoLista[0])
                {
                    if (maiorSinal < a.NivelSinal && a.QuantidadeUsuarios < 100)
                    {
                        maiorSinal = a.NivelSinal;
                        codAnt = a.CodigoAntena;
                    }
                }
                foreach (Vertice a in GrafoLista[0])
                {
                    if (a.CodigoAntena == codAnt)
                    {
                        //Console.WriteLine("conectado a Antena: {0} com sinal: {1}%",
                        a.QuantidadeUsuarios++;
                        a.NivelSinal--;
                    }
                }
            }



        }

        public static void StatusRede()
        {
            int quantUsers = 0;
            int totalCapacidade = 0;
            totalCapacidade = GrafoLista[0].Count * 100;
            foreach (Vertice a in GrafoLista[0])
            {
                quantUsers += a.QuantidadeUsuarios;

            }
            Console.WriteLine("A capacidade da rede é de {0} e nestes momento temos {1} usuários conectados", totalCapacidade, quantUsers);
        }
        public static bool CheckStatusRede()
        {
            int quantUsers = 0;
            int totalCapacidade = 0;
            totalCapacidade = GrafoLista[0].Count * 100;
            foreach (Vertice a in GrafoLista[0])
            {
                quantUsers += a.QuantidadeUsuarios;

            }
            return (quantUsers < 600);
        }
        public static void MostrarGrafo()
        {
            foreach (Vertice a in GrafoLista[0])
            {
                Console.WriteLine("Antena utilizada: {0}, Bairro: {1}, Nível de Sinal: {2}%, Quantidade de usuários conectados: {3}",
                    a.CodigoAntena, a.Bairro, a.NivelSinal, a.QuantidadeUsuarios);
            }
        }
        public static void Processing()
        {
            int aux = 0;
            Console.Write("Processing");
            while (aux < 10)
            {
                Thread.Sleep(50);
                Console.Write(".");
                aux++;
            }
            Console.WriteLine("Done!!! \n");
        }
    }
}
