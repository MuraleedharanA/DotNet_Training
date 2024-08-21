using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace MileStone1_Assessment
{
    class Doctor
    {
        public double regNumber;
        public string docName;
        public string city;
        public string areaOfSpecialization;
        public string address;
        public string timimg;
        public string contact;
        
        //method to capture doctor details from user
        public void acceptDocDetails()
        {
            Console.WriteLine("Enter Doctor Details ");
            Console.Write("\nRegistration Number : ");
            bool isValidRegNum = Double.TryParse(Console.ReadLine(),out this.regNumber);
            if(!isValidRegNum )
            {
                Console.WriteLine("Registraion number can have only numbers!");
                Console.Write("Registration Number : ");
                isValidRegNum = Double.TryParse(Console.ReadLine(), out this.regNumber);
            }
            Console.Write("Doctor Name : ");
            this.docName = Console.ReadLine();
            Console.Write("City : ");
            this.city = Console.ReadLine();
            Console.Write("Area of Specialization : ");
            this.areaOfSpecialization = Console.ReadLine();
            Console.Write("Clinic Timimg : ");
            this.timimg = Console.ReadLine();
            Console.Write("Address : ");
            this.address = Console.ReadLine();
            Console.Write("Contact : ");
            this.contact = Console.ReadLine();
        }

        //prints doc details based on ref obj
        public void printDocDetails()
        {
            Console.WriteLine("Registration Number : " + this.regNumber);
            Console.WriteLine("Doctor Name : " + this.docName);
            Console.WriteLine("Area of Specialization : " + this.areaOfSpecialization);
            Console.WriteLine("City : " + this.city);
            Console.WriteLine("Address : " + this.address);
            Console.WriteLine("Contact : " + this.contact);
            Console.WriteLine("Clinic Timimg : " + this.timimg);
            
        }

    }
    internal class DoctorManagement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t******************Doctor Management System******************");

            
            int option = 0, subOption;
            //holds all doc. key is regNumber
            Dictionary<double, Doctor> doctorDictionary = new Dictionary<double, Doctor>();
            //looping until exit is pressed
            do
            {
                //display menu items and get selection from user
                Console.Write("\nMenu\n----\n\n1. Display Doctor Details\n2. Add Doctor details\n3. Delete Doctor details\n4. Exit\nEnter your Option : ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        display();
                        break;
                    case 2:
                        addDoctor();
                        break;
                    case 3:
                        removeDoc();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Menu.....");
                        break;
                    default:
                        Console.WriteLine("Invalid selection!");
                        break;
                }

            } while (option != 4);

            //Code for displaying Doctor details
            void display()
            {
                Console.Write("\nEnter Registration Number of Doctor to Display details.Press any key for displaying all Doctors:");
                double displayregNum;
                bool isdoublevalentered= double.TryParse(Console.ReadLine(),out displayregNum);
                if (doctorDictionary.Keys.Contains(displayregNum))
                {
                    Console.WriteLine("\nDoctor Details\n-------------");
                    doctorDictionary[displayregNum].printDocDetails();

                }
                else
                {
                    for (int i = 0; i < doctorDictionary.Count; i++)
                    {
                        Console.WriteLine("\nDoctor Details "+(i+1)+"\n---------------");
                        doctorDictionary[doctorDictionary.Keys.ElementAt(i)].printDocDetails();
                    }
                }
            }

            //code to add doc. validations will be done once data is entered by user
            void addDoctor()
            {
                Console.WriteLine("\nAdding Doctor Details\n----------------");
                Doctor newDoc = new Doctor();
                newDoc.acceptDocDetails();
                if (doctorDictionary.Keys.Contains(newDoc.regNumber))
                {
                    Console.WriteLine("Registration number " + newDoc.regNumber + " already exist in system \n");

                }
                else
                {   //validate details entered before adding
                    bool isDocDetailsValid = validate(newDoc);
                    if (isDocDetailsValid)
                    {
                        doctorDictionary.Add(newDoc.regNumber, newDoc);
                    }
                }
            }

            //code to remove doctor based on reg number
            void removeDoc()
            {
                Console.Write("\nDeleting Doctor Details\n\nEnter Registration Number : ");
                double displayRegNum;
                bool isValidRegNum = double.TryParse(Console.ReadLine(),out displayRegNum);
                if (doctorDictionary.Keys.Contains(displayRegNum))
                {
                    doctorDictionary.Remove(displayRegNum);
                    Console.WriteLine("\nDoctor details deleted.");
                }
                else
                {
                    Console.WriteLine("\nInvalid Registration Number!");
                }

            }

            //validate details entered by user
            Boolean validate(Doctor doc)
            {

                bool validDoc = true;


                //mandatory field check
                bool mandateCheck = (doc.regNumber.ToString().Length == 0 || String.IsNullOrWhiteSpace(doc.regNumber.ToString()))
                                    || (doc.docName.Length == 0 || String.IsNullOrWhiteSpace(doc.docName))
                                    || (doc.address.Length == 0 || String.IsNullOrWhiteSpace(doc.address)) 
                                    || (doc.areaOfSpecialization.Length == 0 || String.IsNullOrWhiteSpace(doc.areaOfSpecialization))
                                    || (doc.city.Length == 0 || String.IsNullOrWhiteSpace(doc.city)) 
                                    || (doc.contact.Length == 0 || String.IsNullOrWhiteSpace(doc.contact))
                                    || (doc.timimg.Length == 0 || String.IsNullOrWhiteSpace(doc.timimg));
                if (mandateCheck)
                {
                    Console.WriteLine("\n\nAll details are mandatory for adding a doctor. Please try again!");
                    validDoc = false;
                }
                else
                {

                    //reg number check
                    if (doc.regNumber.ToString().Length != 7)
                    {
                        Console.WriteLine("\n\nInvalid Registration Number!Registration Number should be 7 digit!");
                        validDoc = false;
                    }

                    //name can have alphabets only
                    String pattern = @"^[a-zA-Z]+$";
                    if (!Regex.IsMatch(doc.docName, pattern))
                    {
                        Console.WriteLine("\n\nInvalid Doctor Name.Name can contain only alphabets!");
                        validDoc = false;
                    }

                    //area od specialization can have alphabets only
                    if (!Regex.IsMatch(doc.areaOfSpecialization, pattern))
                    {
                        Console.WriteLine("\n\nInvalid Area of Specialization.Area of Specialization can contain only alphabets!");
                        validDoc = false;
                    }

                    //timimg can have alphabet, numers, characters
                    string timimgPattern = @"^[\w\p{P}\p{S}]+$";
                    if (!Regex.IsMatch(doc.timimg, timimgPattern))
                    {
                        Console.WriteLine("\n\nInvalid timimg!");
                        validDoc = false;
                    }

                    //phone number shld be digits and length is 10
                    string phoneNumberPattern = @"^\d{10}$";
                    if (!Regex.IsMatch(doc.contact, phoneNumberPattern))
                    {
                        Console.WriteLine("\n\nInvalid phone Number!");
                        validDoc = false;
                    }
                }
                return validDoc;

            }
        }
    }
}