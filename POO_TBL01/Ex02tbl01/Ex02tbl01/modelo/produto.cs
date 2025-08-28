using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProduto
{
    public class produto
    {
        public string ProdutoNome()
        {
            Console.WriteLine("\nEscreva o nome do Produto: ");
            string pn = Console.ReadLine();
            return pn;
        }

        public double ProdutoValor()
        {
            Console.WriteLine("Escreva o valor do Produto: ");
            double pv = double.Parse(Console.ReadLine());
            return pv;
        }
    }
}
