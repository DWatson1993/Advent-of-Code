// See https://aka.ms/new-console-template for more information

Part1();
Part2();

List<string[]> GetInput()
{
    var result = File.ReadAllLines("input.txt").Select(x => x.Split(' ')).ToList();

    return result;
}


void Part1()
{
    var input = GetInput();

    int total = 0;

    foreach (var game in input)
    {
        string[] actions = { GameCalculate.ActionName(game[0]), GameCalculate.ActionName(game[1]) };

        total += (GameCalculate.GameScore(actions)) + (GameCalculate.ActionScore(actions[1]));
    }

    Console.WriteLine(total);
}

void Part2()
{
    var input = GetInput();

    int total = 0;

    foreach (var game in input)
    {
        string oppAction = GameCalculate.ActionName(game[0]);

        string returnAction = GameCalculate.ReturnAction(oppAction, game[1]);

        string[] actions = { oppAction, returnAction };

        total += (GameCalculate.GameScore(actions)) + (GameCalculate.ActionScore(actions[1]));
    }

    Console.WriteLine(total);
}

public static class GameCalculate
{
    public static string ActionName(string input)
    {
        return input switch
        {
            "A" => "Rock",
            "B" => "Paper",
            "C" => "Scissors",
            "X" => "Rock",
            "Y" => "Paper",
            "Z" => "Scissors",
            _   => ""
        };
    }

    public static int GameScore(string[] actions)
    {
        if (actions[0] == actions[1])
        {
            return 3;
        }
        else if ((actions[1] == "Rock" && actions[0] != "Paper")
            || (actions[1] == "Paper" && actions[0] != "Scissors")
            || (actions[1] == "Scissors" && actions[0] != "Rock"))
        {
            return 6;
        }
        else
        {
            return 0;
        }
    }

    public static int ActionScore(string input)
    {
        return input switch
        {
            "Rock"      => 1,
            "Paper"     => 2,
            "Scissors"  => 3,
            _           => default
        };
    }

    public static string ReturnAction(string oppAction, string result)
    {
        if (result == "X")
        {
            return oppAction switch
            {
                "Rock"      => ActionName("C"),
                "Paper"     => ActionName("A"),
                "Scissors"  => ActionName("B"),
                _           => ""
            };
        }
        else if (result == "Y")
        {
            return oppAction;
        }
        else
        {
            return oppAction switch
            {
                "Rock"      => ActionName("B"),
                "Paper"     => ActionName("C"),
                "Scissors"  => ActionName("A"),
                _           => ""
            };
        }
    }
}