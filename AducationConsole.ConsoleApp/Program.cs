User user = new User();
user.Email = "asdasdasd";

class User
{
    private int age;
    private string login;
    private string email;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 18)
                Console.WriteLine("Возраст должен быть не меньше 18");
            
            else
                age = value;
            
        }
    }

    public string Login
    {
        get
        {
            return login;
        }
        set
        {
            if (login.Length < 3)
                Console.WriteLine("Поле логин должно иметь длину больше 3-х символов!");

            else
                login = value;
        }
    }

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            if (email.Contains('@'))
                email = value;
                

            else
                Console.WriteLine("Поле email должно включать символ @");
        }
    }
}