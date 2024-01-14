using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "1324", modelo: "Model-1", imei: "11112222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "9764", modelo: "Model-5", imei: "44448888", memoria: 256);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
