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
                Console.WriteLine("3. Editing Existing contacts details");
                Console.WriteLine("4. Delete added Person Contact using name");

                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Contact details are as shown below");
                        //Adding contact information directly through object
                        Details details = new Details("Rajesh", "Ambavale", "Dadar", "Mumbai", "Maharashtra", "rajesh@gmail.com", 4000016, 9967872990);
                        details.DisplayDetails();
                        break;
                    case 2:
                        ContactPerson newContact = new ContactPerson();
                        newContact.AddingContactDetails();
                        newContact.DisplayDetails();
                        break;
                    case 3:
                        ContactPerson editContact = new ContactPerson();
                        editContact.AddingContactDetails();
                        editContact.DisplayDetails();

                        //Asking user if he/she wanted to edit the contact details or not
                        Console.WriteLine("Edit contact details using name ? 1: Yes/ Other: No");
                        Console.Write("Enter your choice : ");
                        int choice3 = Convert.ToInt32(Console.ReadLine());
                        if (choice3 == 1)
                        {
                            editContact.EditContactDetails();
                            editContact.DisplayDetails();
                        }
                        break;
                    case 4:
                        ContactPerson deleteContact = new ContactPerson();
                        deleteContact.AddingContactDetails();
                        deleteContact.DisplayDetails();

                        //Asking user if he/she wanted to edit the contact details or not
                        Console.WriteLine("Edit contact details using name ? 1: Yes/ Other: No");
                        Console.Write("Enter your choice : ");
                        int choice4 = Convert.ToInt32(Console.ReadLine());
                        if (choice4 == 1)
                        {
                            deleteContact.EditContactDetails();
                            deleteContact.DisplayDetails();
                        }

                        //Asking user if he/she wanted to delete the contact details or not
                        Console.WriteLine("Delete person using person name ? 1. Yes/ Other:  No");
                        Console.Write("Enter your choice : ");
                        int choice42 = Convert.ToInt32(Console.ReadLine());
                        deleteContact.DeleteContactDetails();
                        //person4.DisplayDetails();
                        break;

                    default:
                        Console.WriteLine("Enter correct choice");
                        break;
                }
            } while (choice != 0);
        }
    }
}