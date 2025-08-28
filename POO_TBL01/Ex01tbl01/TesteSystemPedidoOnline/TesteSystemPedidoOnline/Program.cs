using System;
using SystemPedidoOnline;



var spo = new SysPO();
Console.WriteLine("Deseja fazer pedido: \ndigite\n1 para sim\n2 para não");
int v = int.Parse(Console.ReadLine());
int a = v;
if (a == 1)
{
    string ua = spo.UsuarioName();
    string pna = spo.ProdutoName();

    Console.WriteLine($"Senhor(a) {ua} você fez um pedido do produto {pna}.");
}
if (a == 2)
{
    Console.WriteLine("Então caso necessite de pedido, rode o programa novamente");
}
