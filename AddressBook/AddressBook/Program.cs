﻿using System;
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
                Console.WriteLine("5. Add multiple persons contacts");
                Console.WriteLine("6. Add Multiple Address Books");

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
                    case 5:
                        MultipleContacts multiple = new MultipleContacts();
                    Add:
                        Console.WriteLine("You want to enter details ? 1: Yes/ Other: No");
                        Console.Write("Enter your choice : ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (c == 1)
                        {
                            multiple.AddingContactDetails();
                            multiple.DisplayDetails();
                            goto Add;
                        }

                    //Asking user if he/she wanted to edit the contact details or not
                    Edit:
                        if (multiple.detailsList.Count > 0)
                        {
                            Console.WriteLine("Edit contact details using name ? 1: Yes/ OtherNumber: No");
                            Console.Write("Enter your choice : ");
                            int choice5 = Convert.ToInt32(Console.ReadLine());
                            if (choice5 == 1)
                            {
                                multiple.EditContactDetails();
                                multiple.DisplayDetails();
                                goto Edit;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contact details available to edit");
                        }

                    //Asking user if he/she wanted to delete the contact details or not
                    Delete:
                        if (multiple.detailsList.Count > 0)
                        {
                            Console.WriteLine("Delete person using person name ? 1. Yes/ OtherNumber:  No");
                            Console.Write("Enter your choice : ");
                            int choice52 = Convert.ToInt32(Console.ReadLine());
                            if (choice52 == 1)
                            {
                                multiple.DeleteContactDetails();
                                multiple.DisplayDetails();
                                goto Delete;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contact details available for deletion");
                        }
                        break;

                    case 6:
                        Console.Write("How many Address Books do you need : ");
                        int need = Convert.ToInt32(Console.ReadLine());
                        MultipleAddressBook addressBook = new MultipleAddressBook(need);
                    GoAgain:
                        addressBook.DisplayAllAddressBooks();
                        addressBook.AddingMultipleAddressBooks();
                        addressBook.DisplayAllAddressBooks();
                        addressBook.AccessingAddressBook();

                    Add1:
                        Console.Write("You want to enter details ? ( Press 1 for Yes / OtherNumber for No) : ");
                        int c6 = Convert.ToInt32(Console.ReadLine());
                        if (c6 == 1)
                        {
                            addressBook.AddingContactDetails();
                            addressBook.DisplayDetails();
                            goto Add1;
                        }

                    //Asking user if he/she wanted to edit the contact details or not
                    Edit1:
                        if (addressBook.detailsList[addressBook.addressBookIndex].Count > 0)
                        {
                            Console.Write("Edit contact details using name ? ( Press 1 for Yes / OtherNumber for No) : ");
                            int choice6 = Convert.ToInt32(Console.ReadLine());
                            if (choice6 == 1)
                            {
                                addressBook.EditContactDetails();
                                addressBook.DisplayDetails();
                                goto Edit1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contact details available to edit");
                        }

                    //Asking user if he/she wanted to delete the contact details or not
                    Delete1:
                        if (addressBook.detailsList[addressBook.addressBookIndex].Count > 0)
                        {
                            Console.Write("Delete person using person name ? ( Press 1 for Yes / OtherNumber for No) : ");
                            int choice62 = Convert.ToInt32(Console.ReadLine());
                            if (choice62 == 1)
                            {
                                addressBook.DeleteContactDetails();
                                addressBook.DisplayDetails();
                                goto Delete1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No contact details available for deletion");
                        }
                    //Asking user to search by city or state
                    Search:
                        Console.Write("Want to search by city or state ? ( Press 1 for city / 2 for state /  OtherNumber for No) : ");
                        int searchBy = Convert.ToInt32(Console.ReadLine());
                        if (searchBy == 1)
                        {
                            addressBook.SearchPersonByCity();
                            Console.Write("Want to search person by city or state again (Press 1 for yes) : ");
                            int searchAgain = Convert.ToInt32(Console.ReadLine());
                            if (searchAgain == 1)
                            {
                                goto Search;
                            }
                        }
                        if (searchBy == 2)
                        {
                            addressBook.SearchPersonByState();
                            Console.Write("Want ro search person by city or state again (Press 1 for yes) : ");
                            int searchAgain = Convert.ToInt32(Console.ReadLine());
                            if (searchAgain == 1)
                            {
                                goto Search;
                            }
                        }
                        Console.Write("Want to choose Address Book again ? ( Press 1 for Yes / OtherNumber for No) : ");
                        int start = Convert.ToInt32(Console.ReadLine());
                        if (start == 1)
                        {
                            goto GoAgain;
                        }
                        break;
                    


                    default:
                        Console.WriteLine("Enter correct choice");
                        break;
                }
            } while (choice != 0);
        } 
    }
}