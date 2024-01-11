using programacao_orientada_a_objetos.Models;

// ABSTRAÇÃO

Carro carro1 = new Carro();

carro1.Modelo = "Uno com Escada";
carro1.Cor = "Branco";
carro1.Preco = 77500M;

// carro1.Acelerar(130);

Carro carro2 = new Carro();

carro2.Modelo = "Ferrari";
carro2.Cor = "Vermelho";
carro2.Preco = 55000M;

// carro2.Acelerar(80);

// ENCAPSULAMENTO

ContaCorrente conta1 = new ContaCorrente(123, 20000);
conta1.ExibirSaldo();
conta1.Sacar(100);
conta1.ExibirSaldo();