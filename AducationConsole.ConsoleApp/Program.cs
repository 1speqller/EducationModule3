Console.Write("What is your favorite day of week? ");
byte favoriteDay = (byte)int.Parse(Console.ReadLine());
Console.WriteLine("You favorite day is {0} ", (DaysOfWeek)favoriteDay);

enum DaysOfWeek : byte
{
    Monday = 1, 
    Tuesday, 
    Wednesday, 
    Friday, 
    Saturday,
    Sunday
}