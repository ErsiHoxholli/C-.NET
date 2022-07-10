// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

////Three Basic Arrays////

//Create an array to hold integer values 0 through 9//

int[] arrayOfInts = new int[10];

for (int i = 0; i < 10; i++ )
{
    arrayOfInts[i]=i;
    Console.WriteLine(arrayOfInts[i]);
}

//Create an array of the names "Tim", "Martin", "Nikki", & "Sara"//

string[] arrayOfStrings = new string[4] {"Tim", "Martin", "Nicki", "Sara"};

for (int i = 0; i < arrayOfStrings.Length; i++)
{
    Console.WriteLine(arrayOfStrings[i]);
}
    

//Create an array of length 10 that alternates between true and false values, starting with true//

bool[] arrayOfBoolean = new bool[10];

for (int i = 0; i < arrayOfBoolean.Length; i++)
{
    arrayOfBoolean[i] = true;
    if (i%2==1)
    {
        arrayOfBoolean[i] = false;
    }
    Console.WriteLine(arrayOfBoolean[i]);
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

////List of Flavors////

//Create a list of ice cream flavors that holds at least 5 different flavors//

List<string> icecream = new List<string>();

icecream.Add("Pistachio");
icecream.Add("Chocolate");
icecream.Add("Vanilla");
icecream.Add("Yougurt");
icecream.Add("Cookie");

//Output the length of this list after building it//

Console.WriteLine(icecream.Count);

//Output the third flavor in the list, then remove this value//
Console.WriteLine(icecream[2]);
icecream.RemoveAt(2);

//Output the new length of the list//
Console.WriteLine(icecream.Count);  

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

////User Info Dictionary////

//Create a dictionary that will store both string keys as well as string values//

Dictionary<string, string>  myDictionary = new Dictionary<string, string>();
Random rnd = new Random();

//Add key/value pairs to this dictionary where://
//  each key is a name from your names array//
//  each value is a randomly elected flavor from your flavors list.//

for (int i = 0; i < 4; i++)
{
        myDictionary.Add(arrayOfStrings[i], icecream[rnd.Next(0, 4)]);

}

//Loop through the dictionary and print out each user's name and their associated ice cream flavor//

foreach(KeyValuePair<string, string> ele1 in myDictionary)
{
    Console.WriteLine(ele1.Key + " - " + ele1.Value);
}