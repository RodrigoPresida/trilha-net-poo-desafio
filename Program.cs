using DesafioPOO.Models;

Console.WriteLine("Iphone");
Smartphone iphoneplus = new Iphone(numero: "2345678", modelo: "iphoneplus", imei: "0102030405", memoria: 128);
iphoneplus.Ligar();
iphoneplus.ReceberLigacao();
iphoneplus.InstalarAplicativo("Instagram");

Console.WriteLine("Nokia");
Smartphone lumia = new Nokia(numero: "2345678", modelo: "Nokia Lumia", imei: "0102030405", memoria: 128);
lumia.Ligar();
lumia.ReceberLigacao();
lumia.InstalarAplicativo("WhatsApp");