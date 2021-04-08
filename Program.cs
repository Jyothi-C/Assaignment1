using System;
using System.Collections.Generic;
using System.Collections;


namespace AssetManagement
{
    public class AssetInformation
    {
        //member variables
        int id;
        String name;
        int year;
        //member functions
        public void UserData()
        {
            //printing on output screen
            Console.WriteLine("Enter  Asset_id:");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Asset_name:");
            name = (Console.ReadLine());

            Console.WriteLine("Date of publishing");
            year = int.Parse(Console.ReadLine());
        }

        //Function to display the data
        public void Display()
        {
            Console.WriteLine(id + "\t\t" + name + "\t\t" + year);
        }
    }
    public class AssetHelper
    {
        static AssetInformation[] assetInformation = new AssetInformation[100];
        //Function for Adding Asset details
        public static void Add_Asset()
        {
            Console.WriteLine("Enter Number of items to add");
            int number = int.Parse(Console.ReadLine());
            int index;
            //details storing in array
            for (index = 0; index < number; index++)
            {
                assetInformation[index] = new AssetInformation();
                assetInformation[index].UserData();
            }
            Console.WriteLine("Asset_ID \t Asset_Name  \t year_of_publishing");
            //To display the list
            for (index = 0; index < number; index++)
            {
                assetInformation[index].Display();
            }
        }
        //Searching method
        public static void Search_Asset(int id)
        {
            Console.WriteLine("Enter the searching id");
            int keyId = int.Parse(Console.ReadLine());

            //if keyid matches with available id it prints successfull message
            if (id == keyId)
            {
                Console.WriteLine("Given Asset_id is available");
            }
            else
            {
                Console.WriteLine("Given Asset_Id not available");
            }
        }
        //Deleting information from list
        public static void Delete_Asset(int id)
        {

            Console.WriteLine("Enter the searching id");
            int keyId = int.Parse(Console.ReadLine());
            //if given id found enters in to if condition
            if (id == keyId)
            {
                //finding given id position
                int numIdx = Array.IndexOf(assetInformation, keyId);
                List<int> Item = new List<int> { 11, 22, 33, 44, 55 };
                //based on index the element will deleted
                Item.RemoveAt(numIdx);
                Console.WriteLine("Successfully removed");
            }
            else
            {
                Console.WriteLine("No Id is there");
            }
        }
        //insertion method
        public static void Insert()
        {
            for (int i = 0; i < 1; i++)
            {
                assetInformation[i] = new AssetInformation();
                assetInformation[i].UserData();
            }
        }
        public static void Update_Asset(int Id, String Name, int date)
        {
            //calling method
            Insert();
            //to display elements
            for (int i = 0; i < 1; i++)
            {
                assetInformation[i].Display();
            }
        }
        //main method
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter Which Asset you want");
            Console.WriteLine(" 1.Books\n 2.SoftwareLicence\n 3.Hardware\n");
            int asset = Convert.ToInt32(Console.ReadLine());
            //switch case to select the required asset
            switch (asset)
            {
                case 1:
                    Console.WriteLine("Welcome to Book Management");
                    Operations();
                    break;

                case 2:
                    Console.WriteLine("Welcome to SoftwareLicence Management");
                    Operations();
                    break;

                case 3:
                    Console.WriteLine("Welcome to Hardware Management");
                    Operations();
                    break;

                default:
                    Console.WriteLine("Wrong Entry");
                    break;

            }
        }
        //operations for all 3 assets
        public static void Operations()
        {
            Console.WriteLine("Enter which operation u want to perform\n 1.Adding\n2.Searching\n3.Deleting\n4.Updating");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    //calling add_asset function
                    AssetHelper.Add_Asset();
                    break;
                case 2:
                    //calling search_asset function
                    AssetHelper.Search_Asset(1);
                    break;
                case 3:
                    //calling.delete_asset function
                    AssetHelper.Delete_Asset(1);
                    break;
                case 4:
                    //calling Update_asset function
                    AssetHelper.Update_Asset(1, "Name", 1999);
                    break;
                default:
                    break;
            }
        }
    }
}