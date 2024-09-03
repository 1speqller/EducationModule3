class Program
{
    static void Main(string[] args)
    {
        ShowUserInformation(GetQuestionnaire());
    }

    static (string FName, string LName, int Age, bool IsPetOwner, int PetCount, int ColorCount, string[] FavoriteColors, string[] NicknamesPet) GetQuestionnaire()
    {
        (string FName, string LName, int Age, bool IsPetOwner, int PetCount, int ColorCount, string[] FavoriteColors, string[] NicknamesPet) User;

        string str;
        string num;
        int intNum;

        Console.WriteLine("Добрый день! Заполните анкету по указанным ниже вопросам:");

        do
        {
            Console.Write("Ваша имя: ");
            str = Console.ReadLine();
        } while (CheckStr(str));

        User.FName = str;

        do
        {
            Console.Write("Ваша фамилия: ");
            str = Console.ReadLine();
        } while (CheckStr(str));

        User.LName = str;

        do
        {
            Console.Write("Сколько вам лет? ");
            num = Console.ReadLine();
        } while (CheckNum(num, out intNum) && CheckStr(num));

        User.Age = intNum;

        do
        {
            Console.Write("У вас есть питомец? Ответ запишите с маленькой буквы: ");
            str = Console.ReadLine();
            if (str == "да")
            {
                User.IsPetOwner = true;
                Console.Write("Сколько у вас питомцев? ");
                User.PetCount = Convert.ToByte(Console.ReadLine());

                do
                {
                    Console.Write("Сколько у вас питомцев? ");
                    num = Console.ReadLine();
                } while (CheckNum(num, out intNum) && CheckStr(num));

                User.PetCount = intNum;
                User.NicknamesPet = GetPetNickname(User.PetCount);
            }
        } while (CheckStr(str) && (str == "да" || str == "нет"));

        do
        {
            Console.Write("Сколько у вас любимых цветов? ");
            num = Console.ReadLine();
        } while (CheckNum(num, out intNum) && CheckStr(num));

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
        if (int.TryParse(num, out int intNum))
        {
            if (intNum > 0)
            {
                correctNum = intNum;
                return false;
            }
        }

        correctNum = 0;
        return true;
    }

    static bool CheckStr(string str)
    {
        if (string.IsNullOrEmpty(str) || str.Length > 20)
            return false;

        return true;
    }

    static void ShowUserInformation((string FName, string LName, int Age, bool IsPetOwner, int PetCount, int ColorCount, string[] FavoriteColors, string[] NicknamesPet) user)
    {
        Console.WriteLine($"{user}");
    }
}