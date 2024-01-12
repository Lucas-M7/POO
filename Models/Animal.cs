using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programacao_orientada_a_objetos.Models
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Som genérico do animal");
        }
    }
}