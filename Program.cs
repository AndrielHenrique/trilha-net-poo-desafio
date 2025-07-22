using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Nokia:");
            Nokia nokia = new Nokia(numero: "40028922", modelo: "Nokia 3210", imei: "111999333", memoria: 12);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Testando iPhone:");
            Iphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 15 Pro", imei: "444555666", memoria: 256);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

        }
    }
}