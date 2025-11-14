using ExercicioPolimorfismo;

PagamentoPix compraPix = new PagamentoPix();
compraPix.ValorCompra = 15000;

float valorPagar = compraPix.CalcularTotal();
Console.WriteLine($"Produto: Smartphone");
Console.WriteLine($"Preco: {compraPix.ValorCompra}");
Console.WriteLine($"Forma de Pagamento: Pix");
Console.WriteLine($"Pagamento com Desconto: {valorPagar}");

Console.WriteLine();

PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao .ValorCompra = 50;

Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preco: {compraCartao.ValorCompra}");
Console.WriteLine($"Forma de Pagamento: Cartao");
Console.WriteLine($"Pagamento com Acrescimo: {compraCartao.CalcularTotal()}");