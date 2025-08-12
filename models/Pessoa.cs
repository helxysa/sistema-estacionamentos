using System;

namespace Exemplo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola {Nome}");
        }
    }
}