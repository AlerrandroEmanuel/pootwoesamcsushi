namespace SystemPedidoOnline
{
    public class SysPO
    {
        public string UsuarioName()
        {
            Console.WriteLine("Digite seu nome:");
            string ua = Console.ReadLine(); 
            return ua;
           
        }

        public string ProdutoName()
        {
            Console.WriteLine("Digite o nome do produto que deseja:");
            string pna = Console.ReadLine();
            return pna;
        }
    }
}
