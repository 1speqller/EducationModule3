(string Name, string[] Dishes) User;
User.Dishes = new string[5];

Console.Write("Введите свое имя: ");
User.Name  = Console.ReadLine();

Console.WriteLine("Введите 5 любимых блюд: ");
for (int i = 0; i < User.Dishes.Length; i++)
{
    User.Dishes[i] = Console.ReadLine();
}

foreach (string Dishes in User.Dishes)
    { 
        Console.WriteLine(Dishes); 
    }

Console.ReadKey();