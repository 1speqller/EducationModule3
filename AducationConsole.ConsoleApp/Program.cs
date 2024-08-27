(string FName, string LName, string Login, int LoginLength, bool IsPetOwner, int Age, string[] FavColors) User;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Введите имя");
    User.FName = Console.ReadLine();

    Console.WriteLine("Введите фамилию");
    User.LName = Console.ReadLine();

    Console.WriteLine("Введите логин");
    User.Login = Console.ReadLine();
    User.LoginLength = User.Login.Length;

    Console.WriteLine("Есть ли у вас животные? Да или Нет");
    string petAnswer = Console.ReadLine();

    if (petAnswer == "Да")
        User.IsPetOwner = true;

    Console.WriteLine("Введите возраст пользователя");
    User.Age = Convert.ToInt32(Console.ReadLine());

    User.FavColors = new string[3];
    Console.WriteLine("Введите три любимых цвета пользователя");

    for (int j = 0; j < User.FavColors.Length; j++)
    {
        User.FavColors[j] = Console.ReadLine();
    }
}

Console.ReadKey();