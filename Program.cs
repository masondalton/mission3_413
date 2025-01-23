// See https://aka.ms/new-console-template for more information
/*
 * A food item consists of:
   • Name (e.g., "Canned Beans")
   • Category (e.g., "Canned Goods", "Dairy", "Produce")
   • Quantity (e.g., 15 units)
   • Expiration Date
   
   Your system should provide a menu to allow the user to:
   • Add Food Items
   • Delete Food Items
   • Print List of Current Food Items
   • Exit the Program
   
   There should be at least two classes in the program (you can add more if you would like):
   • Program.cs: Main class that controls the flow of the program and allows the user to choose
   what they would like to do and executes those tasks.
   • FoodItem: Stores the information for an individual food item.
   Use the constructor of the FoodItem to set the information for that food item when it is added.
   
   HINT: You can use a List of FoodItem type to easily add and remove food items objects as
   needed.
   
   Make sure to include basic error handling (i.e. make sure the user selects a valid choice, no
   negative quantities, etc.)
*/

// Display options
    // Add food item
    // Get name, category, quantity, expiration date
    // Save
    
    // Delete Food items
    
    // Print list of current food items
    
    // Exit the program
    using mission3;

    bool stopProgram = false;
    List<FoodItem> foodItems = new List<FoodItem>();

    while (stopProgram == false)
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Add food item");
        Console.WriteLine("2. Delete food item");
        Console.WriteLine("3. List food items");
        Console.WriteLine("4. Exit");

        string userInput = Console.ReadLine() ?? "empty"; // Pass value that will automatically say is an invalid input
        if (int.TryParse(userInput, out int choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add food item");
                    
                    // Get food item information from user for name
                    Console.WriteLine("Enter food item name: ");
                    string foodName;
                    while (string.IsNullOrWhiteSpace(foodName = Console.ReadLine()))
                    {
                        Console.WriteLine("Food name cannot be empty. Please enter a valid name:");
                    }
                    
                    // Food category entry from user
                    Console.WriteLine("Enter food item category: ");
                    string foodCategory;
                    while (string.IsNullOrWhiteSpace(foodCategory = Console.ReadLine()))
                    {
                        Console.WriteLine("Food category cannot be empty. Please enter a valid name:");   
                    }
       
                    
                    // Get units of food
                    Console.WriteLine("Enter food quantity: ");
                    // Verify integer entry from user
                    int foodQuantity;
                    while (!int.TryParse(Console.ReadLine(), out foodQuantity) || foodQuantity < 0)
                    {
                        Console.WriteLine("Invalid quantity. Please enter a non-negative number:");
                    }
                    
                    // Get expiration date. Verifies it is in correct format
                    Console.WriteLine("Enter food expiration: ");
                    DateTime expirationDate;
                    while (!DateTime.TryParse(Console.ReadLine(), out expirationDate))
                    {
                        Console.WriteLine("Invalid date format. Please enter a valid date (MM/dd/yyyy):");
                    }
                    
                    // Add information to object and add to list of food items
                    foodItems.Add(new FoodItem(foodName, foodCategory, foodQuantity, expirationDate));
                    break;
                case 2:
                    // Delete food item object from the list in pantry
                    Console.WriteLine("Delete a food item");
                    Console.WriteLine("Enter food item name: ");
                    string foodItemName = Console.ReadLine() ?? "No food item name";
                    FoodItem itemToDelete = foodItems.Find(item => item.Name.Equals(foodItemName, StringComparison.OrdinalIgnoreCase));
                    
                    // Continue program when user has deleted item
                    if (itemToDelete != null)
                    {
                        foodItems.Remove(itemToDelete);
                        Console.WriteLine("Deleted: " + itemToDelete.Name);
                    }
                    else
                    {
                        Console.WriteLine("Item not found. Nothing to delete.");
                    }

                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("List of food items");
                    // Loop through list and print current items, added styling with line break
                    foreach (FoodItem foodItem in foodItems)
                    {
                        Console.WriteLine($"Name: {foodItem.Name}");
                        Console.WriteLine($"Category: {foodItem.Category}");
                        Console.WriteLine($"Quantity: {foodItem.Quantity} units");
                        Console.WriteLine($"Expiration Date: {foodItem.ExpirationDate:MM/dd/yyyy}");
                        Console.WriteLine(new string('-', 20));
                    }
                    
                    // Continue program when user is finished viewing list
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    break;
                case 4:
                    // For communicating exit of program and changing value for looping program. Ends it.
                    Console.WriteLine("Exiting the program.");
                    stopProgram = true; 
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid number (1-4).");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        
    }