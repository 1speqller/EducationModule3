class Program
{
    static void Main(string[] args)
    {

        ShowUserInformation(GetQuestionnaire());
    }

    static (string FName, string LName, int Age, bool IsPetOwner, int PetCount, int ColorCount, string[] FavoriteColors, string[] NicknamesPet) GetQuestionnaire()
    {
        (string FName, string LName, int Age, bool IsPetOwner, int PetCount, int ColorCount, string[] FavoriteColors, string[] NicknamesPet) User = new();

        string str;
        string num;
        int intNum;

        Console.WriteLine("Добрый день! Заполните анкету по указанным ниже вопросам:");

        do
        {
            Console.Write("Ваше имя: ");
            str = Console.ReadLine();
        } while (CheckStr(str) || str.All(char.IsDigit));

        User.FName = str;

        do
        {
            Console.Write("Ваша фамилия: ");
            str = Console.ReadLine();
        } while (CheckStr(str) || str.All(char.IsDigit));

        User.LName = str;

        do
        {
            Console.Write("Сколько вам лет? ");
            num = Console.ReadLine();
        } while (CheckNum(num, out intNum) || CheckStr(num));

        User.Age = intNum;

        do
        {
            Console.Write("У вас есть питомец? да или нет: ");
            str = Console.ReadLine();
            if (str == "да")
            {
                User.IsPetOwner = true;
                do
                {
                    Console.Write("Сколько у вас питомцев? ");
                    num = Console.ReadLine();
                } while (CheckNum(num, out intNum) && CheckStr(num));

                User.PetCount = intNum;
                User.NicknamesPet = GetPetNickname(User.PetCount);
            }
        } while (!(str == "да" || str == "нет") || CheckStr(str));

        do
        {
            Console.Write("Сколько у вас любимых цветов? ");
            num = Console.ReadLine();
        } while (CheckNum(num, out intNum) || CheckStr(num));

        User.ColorCount = intNum;
        User.FavoriteColors = GetFavoriteColor(User.ColorCount);
        
       return User;
    }

    static string[] GetPetNickname(int PetCount)
    {
        string str;
        string[] nicknames = new string[PetCount];
        for (int i = 0; i < PetCount; i++)
        {
            do
            {
                Console.Write("Ваш питомец #{0}: ", i+1);
                str = Console.ReadLine();
            } while (CheckStr(str));
            nicknames[i] = str;
        }
        return nicknames;
    }

    static string[] GetFavoriteColor(int colorCount)
    {
        string str;
        string[] favColors = new string[colorCount];
        for (int i = 0; i < colorCount; i++)
        {
            do
            {
                Console.Write("Любимый цвет #{0}: ", i+1);
                str = Console.ReadLine();
            } while (CheckStr(str));

            favColors[i] = str;
        }
        return favColors;
    }

    static bool CheckNum(string num, out int correctNum)
    {
        if (num.All(char.IsDigit))
        {
            if (int.TryParse(num, out int intNum))
            {
                if (intNum > 0)
                {
                    correctNum = intNum;
                    return false;
                }
            }
        }

        correctNum = 0;
        return true;
    }

    static bool CheckStr(string str)
    {
        if (string.IsNullOrEmpty(str) || str.Length > 20)
            return true;

        return false;
    }

    static void ShowUserInformation((string FName, string LName, int Age, bool IsPetOwner, int PetCount, int ColorCount, string[] FavoriteColors, string[] NicknamesPet) user)
    {
        Console.WriteLine("Ваша анкета: ");
        Console.WriteLine("Имя: {0}", user.FName);
        Console.WriteLine("Фамилия: {0}", user.LName);
        Console.WriteLine("Возраст: {0}", user.Age);
        Console.WriteLine("Владеет питомцем: {0}", user.IsPetOwner);
        if (user.IsPetOwner)
        {
            Console.Write("Список питомцев: ");
            foreach (var pet in user.NicknamesPet)
                Console.Write($"{pet}  ");
        }
        Console.WriteLine();

        Console.Write("Любимые цвета: ");
        foreach (var color in user.FavoriteColors)
            Console.Write($"{color}  ");
    }
}