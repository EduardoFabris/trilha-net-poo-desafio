using DesafioPOO.Models;

Console.WriteLine("Testando Nokia:");
Smartphone nokia = new Nokia("99999-9999", "Nokia 3310", "111111111111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("snake");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Testando iPhone:");
Smartphone iphone = new Iphone("88888-8888", "iPhone 13", "222222222222222", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
