using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "932868333", modelo: "Nokia 110 Dual Chip", imei: "123456", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "932868333", modelo: "Iphone 11 ProMax", imei: "123456", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Tiktok");
