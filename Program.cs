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

    bool continueProgram = true;
    List<FoodItem> foodItems = new List<FoodItem>();
    String userInput = "";

    while (continueProgram == true)
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Add food item");
        Console.WriteLine("2. Delete food item");
        Console.WriteLine("3. List food items");
        Console.WriteLine("4. Exit");
        
        userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Option A.");
                    
                    break;
                case 2:
                    Console.WriteLine("You selected Option B.");
                    break;
                case 3:
                    Console.WriteLine("You selected Option C.");
                    break;
                case 4:
                    Console.WriteLine("Exiting the program.");
                    continueProgram = false; 
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid number (1-3).");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        
    }