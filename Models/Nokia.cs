using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Random random = new Random();

            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
            Console.WriteLine($"{random.Next(10,25)}%...");
            Thread.Sleep(random.Next(1000, 1750));
            Console.WriteLine($"{random.Next(50,80)}%...");
            Thread.Sleep(random.Next(1000, 2000));
            Console.WriteLine($"100%\nO aplicativo {nomeApp} foi instalado com sucesso");
        }
    }
}