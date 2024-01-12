using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programacao_orientada_a_objetos.Models
{
    public class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        {
        }

        public override void EmitirSom() //POLIMORFISMO
        {
            Console.WriteLine("MIAU!\n");
        }
    }
}