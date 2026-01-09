using DesafioPOO.Models;
namespace DesafioPOO;

class Program
{
    static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Nokia");
        Smartphone nokia = new Nokia("123456", "Modelo 1", "111111", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake Game");
        Console.WriteLine("==========\nIPhone");
        Smartphone iphone = new Iphone("456789", "Modelo 2", "123333", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("SoundCloud");
    }

}