// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Televisao tv = new Televisao(55f);

Console.WriteLine($"A tv é do tamanho {tv.Tamanho}");

tv.LigarTelevisao();

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.AbaixarVolume();
Console.WriteLine($"Volume {tv.Volume}");


tv.SubirCanal();
Console.WriteLine($"Canal {tv.Canal}");

tv.DescerCanal();
Console.WriteLine($"Canal {tv.Canal}");

tv.DesligarTelevisao();





//tv.AbaixarVolume();
//Console.WriteLine($"Volume {tv.AbaixarVolume}");

