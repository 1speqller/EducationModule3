Console.Write("Введите своё имя: ");
var name = Console.ReadLine();

for (int i = name.Length - 1; i >= 0; i--)
{
    Console.Write(name[i]);
}

Console.ReadKey();