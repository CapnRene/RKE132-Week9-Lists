List<string> myShoppingList = getItemsFromUser();
ShowItemsFromList(myShoppingList);

static List<string> getItemsFromUser() {
    List<string> userList = new List<string>();

    while (true)
    {
                Console.WriteLine("Add an item (add) / Exit (exit)");
        string userChoice = Console.ReadLine();
        if (userChoice == "add")
        {
            Console.WriteLine("Enter the item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else if (userChoice == "exit")
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return userList;
}

static void ShowItemsFromList(List<string> someList) {

    Console.Clear();

    int listLenght = someList.Count;
    Console.WriteLine($"You have added {listLenght} items to your shopping list.");

    int i = 1;
    foreach (string item in someList)
    {
    Console.WriteLine($"{ i}. {item}");
    i++;
    }
}