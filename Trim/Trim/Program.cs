// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zadejte číslo:");
string retezec = Console.ReadLine();
Console.WriteLine("Zadal jste text:" + retezec);
Console.WriteLine("Text pro funkci trim:" + retezec.Trim());
int a = int.Parse(retezec);
Console.WriteLine("Převedl jsem zadaný text na číslo parsováním, zadal jste:" + a);
Console.ReadKey();



