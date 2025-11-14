
using Heranca;


Carro fusca = new Carro();
Veiculo generic = new Veiculo();

 //Quais propriedades tem variavel fusca?
 //Quais propriedades tem generic fusca?

Moto Honda = new Moto();

Honda.Marca = "Honda";
Honda.Modelo = "Honda ADV";
Honda.Ano = 2020;
Honda.SomDaMoto();
Honda.Acelerar();


Aviao AirbusA320 = new Aviao();

AirbusA320.Marca = "LATAM Airlines";
AirbusA320.Modelo = "Airbus 320";
AirbusA320.Ano = 2022;
AirbusA320.qtbAsas = 2;
AirbusA320.Voar();
AirbusA320.Acelerar();



Cachorro Pinscher = new Cachorro();
Gato Persa = new Gato();

Pinscher.Nome = "Billy";
Pinscher.Raca = "Pinscher";
Pinscher.Idade = 7;
Pinscher.ExibirInfo();
Pinscher.FazerSom();

Persa.Nome = "Mia";
Persa.Raca = "Persa";
Persa.Idade = 5;
Persa.ExibirInfo();
Persa.FazerSom();

