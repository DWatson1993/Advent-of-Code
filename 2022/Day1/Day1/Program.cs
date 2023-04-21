// See https://aka.ms/new-console-template for more information

Part1();
Part2();

Dictionary<int, int[]> GetInput()
{ 
    Dictionary<int, int[]> result = new Dictionary<int, int[]>();

    int elfCount = 1;

    List<int> items = new List<int>();

    foreach (string line in File.ReadAllLines("input.txt"))
    {
        if (line != "")
        {
            items.Add(Convert.ToInt32(line));
        }
        else
        {
            result.Add(elfCount, items.ToArray());
            items.Clear();
            elfCount++;
        }
    }

    return result;
}

void Part1()
{
    var input = GetInput();

    var max = input.MaxBy(x => x.Value.Sum()).Value.Sum();

    Console.WriteLine(max);
}

void Part2()
{
    var input = GetInput();

    var result = 0;

    for (int i = 0; i < 3; i++)
    {
        var max = input.MaxBy(x => x.Value.Sum());

        result += max.Value.Sum();

        input.Remove(max.Key);
    }

    Console.WriteLine(result);
}