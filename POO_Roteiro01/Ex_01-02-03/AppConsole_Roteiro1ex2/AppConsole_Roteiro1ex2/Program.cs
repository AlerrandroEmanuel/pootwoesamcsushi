using System;
using BibliotecaConversao_roteiro01;


var CV = new Conversao();

Console.WriteLine("Temp em Fahrenheit:" + CV.CelsiusFahrenheit(10));
Console.WriteLine("Km definidos:" + CV.MetrosKm(1000));


Console.WriteLine("O valor convertido será de: " + CV.ConversaodMoneda());
