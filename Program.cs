using System;
using System.Collections.Generic;
using System.Collections;


namespace Asset_Management
{
    
    
        
         public class Management
         {
             //member variables
            int Id;
            String Name;
            int Date;
            
            
            //member functions
             public void Data()
            {

                //printing on output screen
                Console.WriteLine("Enter  Asset_id:");
                //user input 
                Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Asset_name:");
                Name = (Console.ReadLine());

                Console.WriteLine("Date of publishing");
                Date =int.Parse(Console.ReadLine());

            }
            //Function to display the data
             public void display()
             {
                Console.WriteLine(Id + "\t\t" + Name + "\t\t" + Date);
             }
    

             
         }   
            
        public class Common
        {
           
            //
            static Management[] Methods = new Management[100];


            //Function for Adding Asset details 
             public static void Add_Asset(int Id,String Name,int Date)
            {
                    Common[] Functions = new Common[100];
                    Console.WriteLine("Enter Number of items to add");
                    int Number =int.Parse(Console.ReadLine());

                
                 int i;
                 //details storing in array
                 for( i=0; i<Number; i++)
                 {
                    Methods[i] = new Management();
                    Methods[i].Data();
                 }

                 Console.WriteLine("Asset_ID \t Asset_Name  \t year_of_publishing");

                 //To display the list
                 for(i=0;i<Number;i++)
                 {  
                   Methods[i].display();
                 }
                
            }

             //Searching method
             public static void Search_Asset(int Id)
             {
                 Console.WriteLine("Enter the searching id");
                 int Key_Id = int.Parse(Console.ReadLine());

                 //if keyid matches with available id it prints successfull message
                 if(Id == Key_Id)
                 {
                     Console.WriteLine("Given Asset_id is available");
                 }
                 else
                 {
                      Console.WriteLine("Given Asset_Id not available");
                 }
             }
              
             
              //Deleting information from list
              public static void Delete_Asset(int Id)
             {
                 Console.WriteLine("Enter the searching id");
                 int Key_Id = int.Parse(Console.ReadLine());
                           
                 //if given id found enters in to if condition          
                 if(Id == Key_Id)
                 {
                    //finding given id position 
                    int numIdx = Array.IndexOf(Methods, Key_Id);
                    List<int> Item = new List<int> {11,22,33,44,55};
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
                  for(int i=0; i<1; i++)
                 {
                    Methods[i] = new Management();
                    Methods[i].Data();
                 }

             }

             public static void Update_Asset(int Id,String Name,int date)
             {
                 //calling method
                 Insert();
                 //to display elements
                 for(int i=0;i<1;i++)
                 {  
                   Methods[i].display();
                 }

             }
        
                 
                    
            
        

            //main program
            public static void Main(String[] args)
            {
                Console.WriteLine("Enter Which Asset you want");
                Console.WriteLine(" 1.Books\n 2.SoftwareLicence\n 3.Hardware\n");
                int Asset = Convert.ToInt32(Console.ReadLine());
                
                //switch case to select the required asset
                switch(Asset)
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
            
            //all operations for 3 assets
      public static void Operations()
      {
          
         
            Console.WriteLine("Enter which operation u want to perform\n 1.Adding\n2.Searching\n3.Deleting\n4.Updating");
            int Num = int.Parse(Console.ReadLine());
        
            switch (Num)
            {
                case 1:
                       //calling add_asset function
                      Common.Add_Asset(1,"Name",12);
                       break;
                 case 2:
                      //calling search_asset function
                      Common.Search_Asset(1);
                       break;
                case 3:
                     //calling.delete_asset function
                     Common.Delete_Asset(1);
                       break;   
                case 4:
                     //calling Update_asset function
                     Common.Update_Asset(1,"Name",1999);
                     break;          
                 
                default:
                    break;
            }

        
        
      }
                
   }
}
    
            
            
        
       
    

    
