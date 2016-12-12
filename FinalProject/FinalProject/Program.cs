// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{
    public static void Main()
    {

        int ItemDBSize = 0;
        ItemData[] itemData = new ItemData[10];  // create an array of your ItemData struct
        int icount = itemData.Length;  // use an interger to keep track of the count of items in your inventory

        while (true)
        {
            // use a never ending loop that shows the user what options they can select 
            // as long as no one Quits, continue the inventory update
            // in that loop, show what user can select from the list
            Console.WriteLine();
            Console.WriteLine("Please choose from the menu below by entering corresponding number.");
            Console.WriteLine(); // Extra line before the menu
            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Change an item (by giving its item number)");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. List all items in the database");
            Console.WriteLine("5. Quit");

            // read the user's input and then create what case it falls
            string strx = Console.ReadLine();	// read user's input	
            int optx = int.Parse(strx); // convert the given string to integer to match our case types shown below
            Console.WriteLine(); // provide an extra blank line on screen

            switch (optx)
            {
                case 1: // add an item to the list if this option is selected
                    {
                        // Each item must have the following information: 
                        // Item #, Description, Price per item, Quantity on hand, Our cost per item, Value of item (price*quantity)

                        if (ItemDBSize >= 100)
                        {
                            Console.WriteLine("Database is full.");
                            break;
                        }

                        if (itemData.Length == ItemDBSize) // identify if it will exceed length
                        {

                            int n = itemData.Length + 1;             // create a new array with a longer length
                            ItemData[] newitemData = new ItemData[n];

                            itemData.CopyTo(newitemData, 0); // copy the old into the new 

                            itemData = newitemData; // delete the old array

                        }

                        Console.WriteLine("Enter Item #: ");
                        string stritemIDNo = Console.ReadLine();
                        itemData[ItemDBSize].itemIDNo = int.Parse(stritemIDNo); // The input from user is converted from a string and placed in the array.

                        Console.WriteLine("Description of Item: ");
                        itemData[ItemDBSize].sDescription = Console.ReadLine();

                        Console.WriteLine("Price per item: ");
                        string strPricePerItem = Console.ReadLine();
                        itemData[ItemDBSize].dblPricePerItem = double.Parse(strPricePerItem);

                        Console.WriteLine("Quantity on hand: ");
                        string striQuantityOnHand = Console.ReadLine();
                        itemData[ItemDBSize].iQuantityOnHand = int.Parse(striQuantityOnHand);

                        Console.WriteLine("Our cost per item: ");
                        string strOurCost = Console.ReadLine();
                        itemData[ItemDBSize].dblOurCostPerItem = double.Parse(strOurCost);

                        double ValueofItem = (itemData[ItemDBSize].dblPricePerItem) * (itemData[ItemDBSize].iQuantityOnHand);
                        itemData[ItemDBSize].dblValueOfItem = ValueofItem;
                        Console.WriteLine("Value of item = {0}", ValueofItem);

                        ItemDBSize++;

                        break;
                    }

                case 2: //change items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;

                        //         icount = itemData.Length;
                        for (int x = 0; x < ItemDBSize; x++)
                        {
                            if (itemData[x].itemIDNo == chgid)
                            {
                                fFound = true;
                                // code to show what has to happen if the item in the list is found

                                // display all that specific item information
                                Console.WriteLine();
                                Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                                Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");
                                Console.Write("{0,5}  ", x + 1);
                                Console.Write("{0,6}  ", itemData[x].itemIDNo);
                                Console.Write("{0,-20}  ", itemData[x].sDescription);
                                Console.Write("{0,5}  ", itemData[x].dblPricePerItem);
                                Console.Write("{0,3}  ", itemData[x].iQuantityOnHand);
                                Console.Write("{0,4}  ", itemData[x].dblOurCostPerItem);
                                Console.Write("{0,5}  ", itemData[x].dblValueOfItem);
                                Console.WriteLine();

                                // Asking if user would like to edit specific parts of this item or edit entire item
                                Console.WriteLine();
                                Console.WriteLine("Please choose what you would like to edit from menu below by entering the corresponding list number: ");
                                Console.WriteLine("1. Item # ");
                                Console.WriteLine("2. Description of Item ");
                                Console.WriteLine("3. Price per item ");
                                Console.WriteLine("4. Quantity on Hand");
                                Console.WriteLine("5. Our Cost Per Item");
                                Console.WriteLine("6. Multiple parts of this item");

                                string stredit = Console.ReadLine();
                                int edit = int.Parse(stredit);

                                if (edit == 1)
                                {
                                    Console.Write("Edit Item #: ");
                                    string stritemIDNo = Console.ReadLine();
                                    itemData[x].itemIDNo = int.Parse(stritemIDNo); // The input from user is converted from a string and placed in the array.
                                }
                                if (edit == 2)
                                {
                                    Console.WriteLine("Edit Description: ");
                                    itemData[x].sDescription = Console.ReadLine();
                                }
                                if (edit == 3)
                                {
                                    Console.Write("Edit Price Per Item: ");
                                    string strPricePerItem = Console.ReadLine();
                                    itemData[x].dblPricePerItem = double.Parse(strPricePerItem);
                                }
                                if (edit == 4)
                                {
                                    Console.WriteLine("Edit Quantity on hand: ");
                                    string striQuantityOnHand = Console.ReadLine();
                                    itemData[x].iQuantityOnHand = int.Parse(striQuantityOnHand);
                                }
                                if (edit == 5)
                                {
                                    Console.WriteLine("Edit Our cost per item: ");
                                    string strOurCost = Console.ReadLine();
                                    itemData[x].dblOurCostPerItem = double.Parse(strOurCost);
                                }
                                if (edit == 6)
                                {
                                    Console.WriteLine("Enter Item #: ");
                                    string stritemIDNo = Console.ReadLine();
                                    itemData[x].itemIDNo = int.Parse(stritemIDNo); // The input from user is converted from a string and placed in the array.

                                    Console.WriteLine("Description of Item: ");
                                    itemData[x].sDescription = Console.ReadLine();

                                    Console.WriteLine("Price per item: ");
                                    string strPricePerItem = Console.ReadLine();
                                    itemData[x].dblPricePerItem = double.Parse(strPricePerItem);

                                    Console.WriteLine("Quantity on hand: ");
                                    string striQuantityOnHand = Console.ReadLine();
                                    itemData[x].iQuantityOnHand = int.Parse(striQuantityOnHand);

                                    Console.WriteLine("Our cost per item: ");
                                    string strOurCost = Console.ReadLine();
                                    itemData[x].dblOurCostPerItem = double.Parse(strOurCost);

                                }

                                double ValueofItem = (itemData[x].dblPricePerItem) * (itemData[x].iQuantityOnHand);
                                itemData[x].dblValueOfItem = ValueofItem;
                                Console.WriteLine("Value of item = {0}", ValueofItem);
                                if (edit < 1 || edit > 6)
                                {
                                    Console.WriteLine("Invalid entry.");
                                    break;
                                }
                                // reset the count to show a new count for your list 
                                // (Note: your list is now increased by one item)
                            }
                        }
                        if (!fFound) // and if not found
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                        }

                        break;
                    }

                case 3: //delete items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strnewid = Console.ReadLine();
                        int newid = int.Parse(strnewid);

                        bool fDeleted = false;

                        // What happens if user wants to delete upper bound index of array?
                        int index = 0;
                        for (index = newid - 1; index < ItemDBSize; index++)
                        {
                            if (itemData[index].itemIDNo == newid)
                            {
                                fDeleted = true;
                                for (; index < itemData.Length - 1; index++)
                                {
                                    itemData[index] = itemData[index + 1];  // delete the item if you found it                                                                    	
                                }
                                ItemDBSize--;   // reset the count to show a new count for your list                                             
                            }                   //(Note: your list is now reduced by one item)
                        }

                        if (fDeleted) // hint the user that you deleted the requested item
                        {
                            Console.WriteLine("Item deleted");
                        }
                        else // if did not find it, hint the user that you did not find it in your list
                        {
                            Console.WriteLine("Item {0} not found", newid);
                        }

                        break;
                    }

                case 4:  //list all items in current database if this option is selected
                    {
                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");
                        icount = itemData.Length;
                        for (int x = 0; x < icount; x++)
                        {
                            if (itemData[x].itemIDNo != 0) //Only display if the item number is not 0 -- only the array index with item info will display
                            {
                                Console.Write("{0,5}  ", x + 1);
                                Console.Write("{0,6}  ", itemData[x].itemIDNo);
                                Console.Write("{0,-20}  ", itemData[x].sDescription);
                                Console.Write("{0,5}  ", itemData[x].dblPricePerItem);
                                Console.Write("{0,3}  ", itemData[x].iQuantityOnHand);
                                Console.Write("{0,4}  ", itemData[x].dblOurCostPerItem);
                                Console.Write("{0,5}  ", itemData[x].dblValueOfItem);
                                Console.WriteLine();
                            }
                        }
                        // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it

                        break;
                    }

                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        if (strresp == "y")
                        {
                            optx = 0;   //as long as it is not 5, the process is not breaking	
                        }
                        break;
                    }

                default:
                    {
                        Console.Write("Invalid Option, try again");
                        break;
                    }
            }
        }
    }
}