namespace ElfThing;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: ElfThing.exe <input-file>, or drag and drop file onto the exe.");
            goto end;
        }

        StreamReader textFile = new StreamReader(args[0]);
        int total = 0;

        string? currentLine = textFile.ReadLine();

        while (currentLine != null)
        {
            total += GetNumberFromLine(currentLine);
            currentLine = textFile.ReadLine();
        }

        Console.WriteLine(total);
        end: ;
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    public static int GetNumberFromLine(string line)
    {
        int backPointer = line.Length - 1;
        int frontPointer = 0;

        while (!char.IsDigit(line[frontPointer]))
        {
                frontPointer++;
        }

        while (!char.IsDigit(line[backPointer]))
        {
            backPointer--;
        }

        return int.Parse(
            line[frontPointer].ToString()) * 10
               + int.Parse(line[backPointer].ToString()
        );
    }
}