// See https://aka.ms/new-console-template for more information
using System.Numerics;

Execute();

void Execute()
{
    //after birth timer = 6
    //new fish timer = 8, starts counting day after creating
    string[] days = strings.input.Split(',');
    //string[] days = strings.inputTest.Split(',');
    int daysToSim = 256;

    var fishes = new Fishes();
    fishes.fishList = new List<Fish>();
    foreach (string day in days)
    {
        switch (int.Parse(day))
        {

            case 0:
                var fish0 = fishes.fishList.Where(x => x.internalTimer == 0).FirstOrDefault();
                if (fish0 == null)
                {
                    fish0 = new Fish { internalTimer = 0, FishCount = 1 };
                    fishes.fishList.Add(fish0);
                }
                else
                {
                    fish0.FishCount++;
                }

                break;
            case 1:
                var fish1 = fishes.fishList.Where(x => x.internalTimer == 1).FirstOrDefault();
                if (fish1 == null)
                {
                    fish1 = new Fish { internalTimer = 1, FishCount = 1 };
                    fishes.fishList.Add(fish1);
                }
                else
                {
                    fish1.FishCount++;
                }

                break;
            case 2:
                var fish2 = fishes.fishList.Where(x => x.internalTimer == 2).FirstOrDefault();
                if (fish2 == null)
                {
                    fish2 = new Fish { internalTimer = 2, FishCount = 1 };
                    fishes.fishList.Add(fish2);
                }
                else
                {
                    fish2.FishCount++;
                }

                break;
            case 3:
                var fish3 = fishes.fishList.Where(x => x.internalTimer == 3).FirstOrDefault();
                if (fish3 == null)
                {
                    fish3 = new Fish { internalTimer = 3, FishCount = 1 };
                    fishes.fishList.Add(fish3);
                }
                else
                {
                    fish3.FishCount++;
                }

                break;
            case 4:
                var fish4 = fishes.fishList.Where(x => x.internalTimer == 4).FirstOrDefault();
                if (fish4 == null)
                {
                    fish4 = new Fish { internalTimer = 4, FishCount = 1 };
                    fishes.fishList.Add(fish4);
                }
                else
                {
                    fish4.FishCount++;
                }

                break;
            case 5:
                var fish5 = fishes.fishList.Where(x => x.internalTimer == 5).FirstOrDefault();
                if (fish5 == null)
                {
                    fish5 = new Fish { internalTimer = 5, FishCount = 1 };
                    fishes.fishList.Add(fish5);
                }
                else
                {
                    fish5.FishCount++;
                }

                break;
            case 6:
                var fish6 = fishes.fishList.Where(x => x.internalTimer == 6).FirstOrDefault();
                if (fish6 == null)
                {
                    fish6 = new Fish { internalTimer = 6, FishCount = 1 };
                    fishes.fishList.Add(fish6);
                }
                else
                {
                    fish6.FishCount++;
                }

                break;
        }
    }
    Console.Write("Initial: ");
    fishes.fishList.ForEach(fish =>
    {
        Console.Write(fish.internalTimer + "," + fish.FishCount + " | ");
    });
    Console.WriteLine(Environment.NewLine);
    for (var i = 0; i <= daysToSim; i++)
    {

        bool addToList = false;
        Fish newFish = new Fish { internalTimer = 7 };
        
        for (var j = -1; j <= 8; j++)
        {
            var fishListOneList = fishes.fishList.Where(x => x.internalTimer == j).ToList();

            if (fishListOneList != null)
            {
                foreach (var fishListOne in fishListOneList)
                {


                    if (fishListOne.internalTimer == -1)
                    {
                        addToList = true;
                        newFish.FishCount = newFish.FishCount + fishListOne.FishCount;
                        fishListOne.internalTimer = 6;
                    }
                    else
                    {
                        fishListOne.internalTimer--;
                    }
                }
            }
        }
        if (addToList)
            fishes.fishList.Add(newFish);
 
         
    }
    double c = 0;
    fishes.fishList.ForEach(x =>
    {
        c += (ulong)x.FishCount;
        
    });

    Console.WriteLine(c);
}

class Fish
{
    public int internalTimer { get; set; }
    public double FishCount { get; set; }
}

class Fishes
{
    public List<Fish> fishList { get; set; }

}


static class strings
{
    public static readonly string inputTest = @"3,4,3,1,2";
    public static readonly string input = @"2,5,3,4,4,5,3,2,3,3,2,2,4,2,5,4,1,1,4,4,5,1,2,1,5,2,1,5,1,1,1,2,4,3,3,1,4,2,3,4,5,1,2,5,1,2,2,5,2,4,4,1,4,5,4,2,1,5,5,3,2,1,3,2,1,4,2,5,5,5,2,3,3,5,1,1,5,3,4,2,1,4,4,5,4,5,3,1,4,5,1,5,3,5,4,4,4,1,4,2,2,2,5,4,3,1,4,4,3,4,2,1,1,5,3,3,2,5,3,1,2,2,4,1,4,1,5,1,1,2,5,2,2,5,2,4,4,3,4,1,3,3,5,4,5,4,5,5,5,5,5,4,4,5,3,4,3,3,1,1,5,2,4,5,5,1,5,2,4,5,4,2,4,4,4,2,2,2,2,2,3,5,3,1,1,2,1,1,5,1,4,3,4,2,5,3,4,4,3,5,5,5,4,1,3,4,4,2,2,1,4,1,2,1,2,1,5,5,3,4,1,3,2,1,4,5,1,5,5,1,2,3,4,2,1,4,1,4,2,3,3,2,4,1,4,1,4,4,1,5,3,1,5,2,1,1,2,3,3,2,4,1,2,1,5,1,1,2,1,2,1,2,4,5,3,5,5,1,3,4,1,1,3,3,2,2,4,3,1,1,2,4,1,1,1,5,4,2,4,3";
}
