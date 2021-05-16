using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
            //string codigo, int quantidadeUsuarios, string bairro, int nivelSinal
            /*
             * 3      
                [0]
                [1] x > x > x > x
                [2]                 
            antenas,
            cenario1, cenario2, cenario3  
             */

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
            Console.WriteLine("Digite 1 para bairro Belmonte: ");
            string opcao = Console.ReadLine();  //uso local
            ConectarUsuario(opcao);
        }

        public static void ConectarUsuario(string opcao)
        {
            if (opcao == "1")
            {
                int maiorSinal = 0;
                int indice = 0;
                foreach (Vertice a in GrafoLista[0])
                {
                    if (maiorSinal < a.NivelSinal)
                    {
                        maiorSinal = a.NivelSinal;
                        indice++;
                    }
                }
                //Console.WriteLine("conectado a Antena: {0} com sinal: {1}%",
                GrafoLista[0][indice].QuantidadeUsuarios++;
                GrafoLista[0][indice].NivelSinal--;
            }
        }

        public static void MostrarGrafo()
        {

            foreach (Vertice a in GrafoLista[0])
            {
                Console.WriteLine("Antena utilizada: {0}, Bairro: {1}, Nível de Sinal: {2}%, Quantidade de usuários conectados: {3}",
                    a.CodigoAntena, a.Bairro, a.NivelSinal, a.QuantidadeUsuarios);
            }
        }

    }
}
