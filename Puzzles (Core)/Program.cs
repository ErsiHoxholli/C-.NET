// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int[] randomArray()
{
    Random rnd = new Random();
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(5, 26);
        Console.WriteLine(arr[i] + " this is " + i + " index");
    
    }
    return arr;    
}

static int sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

static int min(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

static int max(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i > arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

static string tossCoin()
{
    Random rnd = new Random();
    Console.WriteLine("Tossing a Coin!\n");
    int b = rnd.Next(0, 2);
    if (b == 0)
    {
        Console.WriteLine("Heads");
        return "Heads";
    }
    else
    {
        Console.WriteLine("Tails");
        return "Tails";
    }
}

static double tossMultipleCoins(int num)
{
    int headCount = 0;
    for (int o = 0; o < num; o++)
    {
        string result = tossCoin();
        if ("Heads".Equals(result))
        {
            headCount++;
        }
    }
    return headCount / (double)num;
}

static List<string> names();
{
    List<string> fsList = new List<string>(5);
    List<string> scList = new List<string>(5);
    fsList.Add("Todd");
    fsList.Add("Tiffany");
    fsList.Add("Charlie");
    fsList.Add("Geneva");
    fsList.Add("Sydney");

    for (int i = 0; i < fsList.Count; i++)
    {
        if (fsList[i].Length > 5)
            scList.Add(fsList[i]);
    }
    return scList;
}

static void shufle(List<string> list1)
{
    Random rnd = new Random();
    for (int i = 0; i < list1.Count; i++)
    {
        int rand = rnd.Next(0, list1.Count);
        string temp = list1[i];
        list1[i] = list1[rand];
        list1[rand] = temp;
    }
}