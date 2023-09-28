using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// argumentos = numero, modelo, imei, memoria
Smartphone Nokia = new Nokia("11 9 5555 4444", "N9980", "008844887746", 256);
Smartphone Iphone = new Iphone("11 9 1144 8888", "Pro Max", "888866887744", 512);

Console.WriteLine("Teste Nokia");
Nokia.Ligar();
Nokia.InstalarAplicativo("Facebook");
Nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Teste Iphone...");
Iphone.Ligar();
Iphone.InstalarAplicativo("WhatsApp");
Iphone.ReceberLigacao();