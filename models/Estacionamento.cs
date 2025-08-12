using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private readonly decimal _precoInicial;
        private readonly decimal _precoPorHora;
        private readonly List<string> _veiculos;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
            _precoPorHora = precoPorHora;
            _veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine()?.Trim().ToUpper();

            if (string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
                return;
            }

            if (_veiculos.Contains(placa))
            {
                Console.WriteLine("Este veículo já está estacionado.");
                return;
            }

            _veiculos.Add(placa);
            Console.WriteLine($"Veículo {placa} estacionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine()?.Trim().ToUpper();

            if (string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
                return;
            }

            if (_veiculos.Any(x => x == placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                if (!int.TryParse(Console.ReadLine(), out int horas) || horas < 0)
                {
                    Console.WriteLine("Quantidade de horas inválida. Tente novamente.");
                    return;
                }

                decimal valorTotal = _precoInicial + (_precoPorHora * horas);
                _veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (_veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in _veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}