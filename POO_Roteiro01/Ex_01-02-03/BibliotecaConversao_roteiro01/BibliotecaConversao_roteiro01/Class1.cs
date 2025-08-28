namespace BibliotecaConversao_roteiro01
{
    public class Conversao
    {
        public double CelsiusFahrenheit(double c)
        {
            return ((c*9/5) - 32);
        }

        public double MetrosKm(double m)
        {
            return m/1000;
        }

        public double ConversaodMoneda()
        {
            Console.WriteLine("Escreva o valor da moeda:");
            double v = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a taxa de cambio:");
            double t = double.Parse(Console.ReadLine());
            double u = v * t;
            return u;
        }

    }
}
