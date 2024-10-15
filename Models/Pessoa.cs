using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplosFundamentos.Models
{
    public class Pessoa
    {
        //ATRIBUTOS
        public string? Nome { get; set; }
        public int? Idade { get; set; }

        //METODO
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}