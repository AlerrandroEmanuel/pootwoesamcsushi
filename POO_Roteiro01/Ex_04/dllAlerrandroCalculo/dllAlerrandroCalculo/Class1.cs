namespace dllAlerrandroCalculo
{
    public class Imc
    {
        public double AlerrandroImc()
        {
            Console.WriteLine("Escreva o valor do seu peso:");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor da sua altura:");
            double a = double.Parse(Console.ReadLine());

            double i = (p / (a * a));

            if (i <=18.5)
            {
                Console.WriteLine("Possui peso abaixo do normal: MAGREZA");
                return i;
            }
            if (i>18.5 && i<=24.9 )
            {
                Console.WriteLine("Possui peso normal: NORMAL");
                return i;
            }
            if (i >= 25.0 && i <= 29.9)
            {
                Console.WriteLine("Possui peso acima do normal: SOBREPESO");
                return i;
            }
            if (i >= 30.0 && i <= 39.9)
            {
                Console.WriteLine("Possui está um pouco acima do normal: OBESIDADE");
                return i;
            }
            if (i > 40.0)
            {
                Console.WriteLine("Possui peso bem acima do normal: OBESIDADE GRAVE");
                return i;
            }
            return 0;
        }
    }
}
