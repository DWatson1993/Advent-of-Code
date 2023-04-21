// See https://aka.ms/new-console-template for more information

Part1();
Part2();

void Part1()
{
    string[] input = File.ReadAllLines("input.txt");

    double total = 0;

    foreach (string line in input)
    {
        var matchItem = line.Take(line.Length / 2).ToArray().Intersect(line.Skip(line.Length / 2).ToArray()).Single();

        total += Tools.ItemValue(matchItem);
    }

    Console.WriteLine(total);
}

void Part2()
{
    string[] input = File.ReadAllLines("input.txt");

    double total = 0;

    for (int i = 0; i < input.Length-2; i += 3)
    {
        var matchItem = input[i].Intersect(input[i + 1].Intersect(input[i + 2])).Single();

        total += Tools.ItemValue(matchItem);
    }

    Console.WriteLine(total);
}

public static class Tools
{
    public static int ItemValue(char item)
    {
        var value = (int)item % 32;

        if (Char.IsUpper(item))
        {
            value += 26;
        }

        return value;
    }
}