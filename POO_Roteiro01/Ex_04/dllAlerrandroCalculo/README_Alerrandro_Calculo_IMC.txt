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

Explicações:
Este daqui será a classe utilizada para fazer o calculo especifico meu que será o IMC:
"public class Imc"

Este daqui será o Método:
"public double AlerrandroImc()"

"IMC = Índice de Massa Corporal"

Fórmula -> IMC = Peso/(Altura²)

tem a função de verificar se o peso da pessoa está adequado a sua altura, sendo assim é uma métrica para identificar risco associados a desnutrição, sobrepeso ou obesidade.

Esta Dll irá ler os valores de Peso e Altura:
Sendo de Peso em Kg(obs: ao inserir o kg, deve-se usar  a ',' para separar o inteiro do decimal):
 Console.WriteLine("Escreva o valor do seu peso:");
 double p = double.Parse(Console.ReadLine());
Após a pessoa inserir o valor em kg do Peso, o seu valor será convertido em double, armazenando assim a variável na letra "p"

Sendo de Altura em M(obs: ao inserir o metro, deve-se usar  a ',' para separar o inteiro do decimal):
 Console.WriteLine("Escreva o valor da sua altura:");
 double a = double.Parse(Console.ReadLine());
Após a pessoa inserir o valor em metro da Altura, o seu valor será convertido em double, armazenando assim a variável na letra "a"

A fórmula do IMC foi aplicada de acordo com as letras correspondentes:
IMC = Peso/(Altura²)
double i = (p / (a * a));

Na qual o "double i", especificamente o "i" foi utilizado para representar o IMC.

Após a conta o IMC irá fazer uma verificação de onde o valor do seu IMC se encaixa
Nesta situação abaixo, caso o valor do "i" seja menor que 18.5 você se encaixa em MAGREZA, e retornará "i", o valor do seu IMC:
if (i <=18.5)
            {
                Console.WriteLine("Possui peso abaixo do normal: MAGREZA");
                return i;
            }

Nesta situação abaixo, caso o valor do "i" seja maior que 18.5  e menor que 24.9 você se encaixa em NORMAL, e retornará "i", o valor do seu IMC:
if (i>18.5 && i<=24.9 )
            {
                Console.WriteLine("Possui peso normal: NORMAL");
                return i;
            }

Nesta situação abaixo, caso o valor do "i" seja maior que 25.0  e menor que 29.9 você se encaixa em SOBREPESO, e retornará "i", o valor do seu IMC:
if (i >= 25.0 && i <= 29.9)
            {
                Console.WriteLine("Possui peso acima do normal: SOBREPESO");
                return i;
            }

Nesta situação abaixo, caso o valor do "i" seja maior que 30.0 e menor que 39.9 você se encaixa em OBESIDADE, e retornará "i", o valor do seu IMC:
if (i >= 30.0 && i <= 39.9)
            {
                Console.WriteLine("Possui está um pouco acima do normal: OBESIDADE");
                return i;
            }

Nesta situação abaixo, caso o valor do "i" seja maior que 40.0 você se encaixa em OBESIDADE GRAVE, e retornará "i", o valor do seu IMC:
if (i > 40.0)
            {
                Console.WriteLine("Possui peso bem acima do normal: OBESIDADE GRAVE");
                return i;
            }

Este foi a documentação do meu Dll e também deixarei uma dica de como puxar o meu Dll através do código de appconsole:


using System;
using dllAlerrandroCalculo;

var IMC = new Imc();

Console.WriteLine("Aqui está o valor calculado do seu IMC: "+ IMC.AlerrandroImc());