using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "MA478D", modelo: "Nokia X+", imei: "123321123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram", nokia.Modelo);
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "NH9009-A", modelo: "iPhone 15 Pro", imei: "1233211234", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("SnapChat", iphone.Modelo);
iphone.ReceberLigacao();