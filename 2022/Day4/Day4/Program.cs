// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

Part1();

void Part1()
{
    var input = File.ReadAllLines("input.txt");

    int total = 0;

    List<string[]> splitValues = input.Select(x => x.Split(',')).ToList();
















    //var input = PrepInput();

    //int total = 0;

    //foreach (Section section in input)
    //{
    //    bool isSubset = false;

    //    if (section.firstIds.Length > section.secondIds.Length)
    //    {
    //        isSubset = !section.secondIds.Except(section.firstIds).Any();
    //    }
    //    else
    //    {
    //        isSubset = !section.firstIds.Except(section.secondIds).Any();
    //    }

    //    if (isSubset)
    //    {
    //        total++;
    //    }
    //}

    //Console.WriteLine(total);
}

//List<Section> PrepInput()
//{
//    List<Section> sections = new List<Section>();

//    foreach (var line in File.ReadAllLines("input.txt"))
//    {
//        string[] lineSplit = line.Split(',');
//        int[] firstSection = GetPositions(lineSplit[0]);
//        int[] secondSection = GetPositions(lineSplit[1]);

//        Section sectionToAdd = new Section();
//        sectionToAdd.firstIds = firstSection;
//        sectionToAdd.secondIds = firstSection;

//        sections.Add(sectionToAdd);
//    }

//    return sections;
//}

//int[] GetPositions(string input)
//{
//    List<int> positions = new List<int>();
//    int start   = Convert.ToInt32(input.Split('-')[0]);
//    int end     = Convert.ToInt32(input.Split('-')[1]);

//    for (int i = start; i <= end; i++)
//    {
//        positions.Add(i);
//    }

//    return positions.ToArray();
//}

public class Section
{
    public int[] firstIds { get; set; }

    public int[] secondIds { get; set; }
}