using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssetManagement
{
    public class Program
    {
        public class AssetHelper
        {
            static List<AssetInformation> assetList = new List<AssetInformation>();
            // To Add the information into Assets
            public static void AddAsset()
            {
                Console.WriteLine("Enter how many records you want records:");
                int noOfRecords = Convert.ToInt32(Console.ReadLine());
                for (int item = 0; item < noOfRecords; item++)
                {
                    AssetInformation obj = new AssetInformation();
                    Console.WriteLine("Enter Id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter year");
                    int year = Convert.ToInt32(Console.ReadLine());
                    obj.Id = id;
                    obj.Name = name;
                    obj.Year = year;
                    assetList.Add(obj);
                }
                Console.WriteLine("Id\tName\tyear\t");
                assetList.ForEach((AssetInformation) => Console.WriteLine("{0}\t{1}\t{2}", AssetInformation.Id, AssetInformation.Name, AssetInformation.Year));
            }
            //To search the given asset
            public static void SearchAsset()
            {
                Console.WriteLine("Enter the searching id");
                int keyId = int.Parse(Console.ReadLine());

                assetList.ForEach((AssetInformation) =>
                {
                    if (AssetInformation.Id == keyId)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", AssetInformation.Id, AssetInformation.Name, AssetInformation.Year);
                        Console.WriteLine("search id is available");
                    }
                });
            }
            //To update the given asset
            public static void UpdateAsset()
            {
                Console.WriteLine("which field you want to update:1.Name/t2.year");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter which name you want to change");
                        string keyName = (Console.ReadLine());

                        assetList.ForEach((AssetInformation) =>
                    {
                        if (AssetInformation.Name == keyName)
                        {
                            Console.WriteLine("Enter new name");
                            string newName = Console.ReadLine();
                            AssetInformation.Name = newName;
                            Console.WriteLine("{0}\t{1}\t{2}", AssetInformation.Id, AssetInformation.Name, AssetInformation.Year);
                        }
                    });
                        break;
                    case 2:
                        Console.WriteLine("Enter which year you want to change");
                        int keyYear = int.Parse(Console.ReadLine());

                        assetList.ForEach((AssetInformation) =>
                       {
                           if (AssetInformation.Year == keyYear)
                           {
                               Console.WriteLine("Enter new year");
                               int newYear = int.Parse(Console.ReadLine());
                               AssetInformation.Year = newYear;
                               Console.WriteLine("{0}\t{1}\t{2}", AssetInformation.Id, AssetInformation.Name, AssetInformation.Year);
                           }
                       });
                        break;

                    default:
                        break;
                }
            }
            //  for delete an existing asset
            public static void DeleteAsset()
            {
                Console.WriteLine("which Id you want to delete");
                int keyId = int.Parse(Console.ReadLine());
                int availableIndex = assetList.FindIndex(item => item.Id == keyId);
                if (availableIndex > -1)
                {
                    assetList.RemoveAt(availableIndex);
                    Console.WriteLine("Deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Given id not available to delete");
                }
            }
            //Main method
            public static void Main(string[] args)
            {
                string choice;
                do
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
                    Console.WriteLine("Do you want to continue y/n:");
                    choice = Console.ReadLine();

                } while (choice == "y");

            }
            public static void Operations()
            {
                Console.WriteLine("Enter which operation u want to perform\n 1.Adding\n2.Searching\n3.Updating\n4.Deleting");
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        //calling add_asset function
                        AssetHelper.AddAsset();
                        break;
                    case 2:
                        //calling search_asset function
                        AssetHelper.SearchAsset();
                        break;
                    case 3:
                        //calling Update_asset function
                        AssetHelper.UpdateAsset();
                        break;
                    case 4:
                        //calling.delete_asset function
                        AssetHelper.DeleteAsset();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}





























