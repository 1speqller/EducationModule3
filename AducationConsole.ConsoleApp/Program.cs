
string filePath = "/Users/hoshi/Desktop/BinaryFile.bin";

if (File.Exists(filePath))
{
    string stringValue;

    using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Open)))
    {
        writer.Write($"Файл изменён: {DateTime.Now} на компьютере {Environment.OSVersion}");
    }

    using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
    {
        stringValue = reader.ReadString();
    }

    Console.WriteLine("Из файла считано: " + stringValue);
}