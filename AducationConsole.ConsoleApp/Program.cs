Console.Write("Enter you name: ");
var name = Console.ReadLine();

Console.Write("Enter you age: ");
var age = checked((byte)int.Parse(Console.ReadLine()));

Console.WriteLine("Your name is {0} and age is {1} ", name, age);

Console.Write("Enter you birthdate: ");
var birthDay = Console.ReadLine();

Console.Write("Yor birthdate is: {0}", birthDay);
Console.ReadKey();