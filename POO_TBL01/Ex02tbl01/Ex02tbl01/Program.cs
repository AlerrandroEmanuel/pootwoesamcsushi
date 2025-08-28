using System;
using ModelProduto;
using ModelCarrinho;

var product = new produto();
carrinho car = new carrinho();

Console.WriteLine("Você deseja adicionar quantos produtos ao seu carrinho:");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < x; i++)
{
    car.ListaNome.Add(product.ProdutoNome());
    car.ListaValor.Add(product.ProdutoValor());
}


Console.WriteLine("Carrinho com Produto e seu valor correspondente:\n");
for (int i = 0; i < x; i++)
{
    Console.WriteLine($"{car.ListaNome[i]} = {car.ListaValor[i]}");
}
Console.WriteLine("Digite sua forma de pagamento:\n");
car.formadepagamento = Console.ReadLine();
Console.WriteLine($"Forma de Pagamento selecionada: {car.formadepagamento}");