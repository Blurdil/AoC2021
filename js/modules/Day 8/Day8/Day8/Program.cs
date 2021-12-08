// See https://aka.ms/new-console-template for more information
using System.Linq;

var _env = 0;
Main();
void Main()
{
    List<string> input = new List<string>();
    List<string> output = new List<string>();
    List<string> fullContext = new List<string>();

    var file = ReadLines();
    foreach (var line in file)
    {
        string[] arrContext = line.Split('|').ToArray();
        fullContext.AddRange(arrContext);
    }

    int index = 0;
    foreach(var line in fullContext)
    {
        if(index % 2 == 0)
        {
            input.Add(line); 
        }
        else
        {
            output.Add(line); 
        }
        index++;
    }
    checkOutput(output);
}

void checkOutput(List<string> output)
{
    var counter = 0;
    foreach(string line in output)
    {
        var arr = line.Split(' ');
        for(var i = 0; i < arr.Length; i++)
        {
            if(arr[i].Length == 2 || arr[i].Length == 3 || arr[i].Length == 4 ||arr[i].Length == 7)
            {
                counter++;
            }
        }
    }
    Console.WriteLine(counter);
}
/// <summary>
/// 1 uses 2 sements ex. ab
/// 7 usese 3 segments ex. dab
/// 4 uses 4 segments ex. abcd
/// 
/// 8 uses 7 segments  abcdefg
/// 



List<string> ReadLines()
{
    List<string> input = new List<string>();
    var file = _env == 0 ? @"C:\Dev\Advent of Code 2021\js\modules\Day 8\InputTest.txt" : @"C:\Dev\Advent of Code 2021\js\modules\Day 8\Input.txt";
    foreach (string line in System.IO.File.ReadLines(file))
    {
        input.Add(line);
    }

    return input;
}
public class Numbers
{
    public int Num;
    public string Segment;
}








