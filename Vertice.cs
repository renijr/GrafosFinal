using System;
using System.Collections.Generic;
using System.Text;

namespace GrafosFinal
{
    class Vertice
    {

        public string CodigoAntena { get; set; }
        public int QuantidadeUsuarios { get; set; }
        public string Bairro { get; set; }
        public int NivelSinal { get; set; }

        public Vertice() { }

        public Vertice(string novoBairro)
        {
            Bairro = novoBairro;
        }
       
        public Vertice(string codigoAntena, int quantidadeUsuarios, string bairro)
        {
            CodigoAntena = codigoAntena;
            QuantidadeUsuarios = quantidadeUsuarios;
            Bairro = bairro;

            //nível da conexão é inversamente proporcional a quantidade de usuários logado
            //quantidade de conexão igual a 100
            NivelSinal = 100 - quantidadeUsuarios;
        }
    }
}
