using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProduto;

namespace ModelCarrinho
{
    public class carrinho
    {
       public List <string> ListaNome = new List<string>();
       public List<double> ListaValor = new List<double>();

        public double Soma = 0;
        public string formadepagamento;

        public void CarrinhoSoma(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Soma += this.ListaValor[i];
            }

            Console.WriteLine($"Valor Total do carrinho: {Soma}");
        }

      
    }

}
