using System;
namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("============== Welcome to Address Book Program ===============");
            int choice;
            do
            {
                Console.WriteLine("\n1. Adding contacts details");
                Console.WriteLine("2. Adding New contacts details");

                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Contact details are as shown below");
                        //Adding contact information directly through object
                        CreatContacts creatContacts = new CreatContacts("Rajesh", "Ambavale", "Dadar", "Mumbai", "Maharashtra", "rajesh@gmail.com", 4000016, 9967872990);
                        creatContacts.DisplayDetails();
                        break;
                    case 2:
                        ContactPerson contactPerson = new ContactPerson();
                        contactPerson.AddingContactDetails();
                        contactPerson.DisplayDetails();
                        break;

                    default:
                        Console.WriteLine("Enter correct choice");
                        break;
                }
            } while (choice != 0);
        }
    }
}