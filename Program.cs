using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"123456", modelo:"C4", imei:"NABC123XZ", memoria:8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"654321", modelo:"I9", imei:"IABC123XZ", memoria:6);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");