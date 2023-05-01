﻿string folderPath = @"C:\temp";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<String> myShoppingList = new List<String>();

if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);

}
else
{ 
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created!");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);

}


static List<String> GetItemsFromUser()
{ 


List<string> userList = new List<string>();

while(true)
{
    Console.WriteLine("Add an item (add)/ Exit:");
    string userChoice = Console.ReadLine();

    if(userChoice == "add")
    {
        Console.WriteLine("Enter an item:");
        string userItem = Console.ReadLine();
        userList.Add(userItem);
    }
    else
    {
        Console.WriteLine("Bye!");
        break;
    }
}
return userList;

}

static void ShowItemsFromList(List<string> someList)
{ 

Console.Clear();

int listLength = someList.Count;
Console.WriteLine($"You have added {listLength} items to yor shopping list");

int i = 1;
foreach(string item in someList)
{
    Console.WriteLine($"{i}. {item}");
    i++;
}
}