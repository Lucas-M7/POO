using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programacao_orientada_a_objetos.Models
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public override void EmitirSom() //POLIMORFISMO
        {
            Console.WriteLine("AU AU!\n"); 
        }
    }
}