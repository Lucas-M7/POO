using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programacao_orientada_a_objetos.Models
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public decimal Preco { get; set; }

        public void Acelerar(int velocidade)
        {
            velocidade += 10;

            Console.WriteLine($"{Modelo} de cor {Cor} está a {velocidade}KM/h!!!! " +
            $"O seu preço é de {Preco:c}.");
        }
    }
}