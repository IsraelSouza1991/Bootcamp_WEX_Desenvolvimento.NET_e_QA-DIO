using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Pessoa
    {
        //Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Métodos / funções
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu" +
             "nome é {Nome}\n, e tenho {Idade} anos");
        }
    }
}