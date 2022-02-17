string[] nameArray = new string[5] { "Tom", "Fred", "Bill", "Chris", "Mike" };
string[] townArray = new string[5] { "Detroit", "Midland", "buffalo", "Saginaw", "Flint" };
string[] favFoodArray = new string[5] { "Pizza", "Hot Dogs", "Donuts", "Burgers", "Water" };
int studIdx;
bool result = true;
string yn = "y";
do
{ 
    do
    {
        Console.Write($"Which student would you like to learn about? Enter a name or a number from 1 to {nameArray.Length}: ");

        string nameOrInt = Console.ReadLine();
        result = int.TryParse(nameOrInt, out studIdx);
        if (result && studIdx > 0 && studIdx <= nameArray.Length) studIdx--;
        else
        {
            if (!nameArray.Contains(nameOrInt))
            {
                Console.WriteLine($"\nYour input, {nameOrInt}, was not valid.\n");
                result = false;
            }
            else
            {
                studIdx = Array.IndexOf(nameArray, nameOrInt);
                result = true;
            }
        }
    }
    while (!result);
    
    do
    {
        Console.WriteLine($"Student { studIdx + 1} is { nameArray[studIdx] }. Enter \"hometown\" or \"favorite food\": ");
        string studCategory = (Console.ReadLine()).ToLower();
    
        if (studCategory == "hometown" || studCategory.Contains("h"))
        {
            Console.WriteLine($"{nameArray[studIdx]} is from {townArray[studIdx]}.");
        }
        else if (studCategory == "favorite food" || studCategory.Contains("f"))
        {
            Console.WriteLine($"{nameArray[studIdx]}'s favorite food is {favFoodArray[studIdx]}.");
        }
        else
        {
            Console.WriteLine("That category does not exist. Please enter \"hometown\" or \"favorite food\": ");
            result = false;
        }
    }
    while (!result);

    Console.Write("\nWould you like to learn about another student or see a list? (y for yes or l for list or any other key to stop): ");
    yn = Console.ReadLine();
    if (yn == "l")
    {
        Console.WriteLine($"\nHere's everyone on the list:{ string.Join(", ", nameArray) } \n");
    }
}
while (yn == "y" || yn == "l") ;

