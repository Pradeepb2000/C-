using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    /// <summary>
    /// Creating CovidVaccination Class
    /// </summary>
    
    class CovidVaccination
    {
        /// <summary>
        /// Creating List for userDetails 
        /// </summary>
       
        private static List<Beneficiary> UserDetails = new List<Beneficiary>();
        static void Main(string[] args)
        {
            string choice;
            CovidVaccination covidObj = new CovidVaccination();

            //Add Default user details in the List
            UserDetails.Add(new Beneficiary("pradeep",9500997791, "cheenai", 21, (Gender)1));
            UserDetails.Add(new Beneficiary("Dhoni",9500997792, "Jarkhand", 21, (Gender)1));
            UserDetails.Add(new Beneficiary("Virat",9500997793, "Banglore", 21, (Gender)1));
            do
            {
                Console.WriteLine("***********Welcome to \"COVID-VACCINATION\"***************");
                Console.WriteLine("*******Available Options*****");
                Console.WriteLine("1.User Registration \n2.Vaccination \n3.Exit");
                Console.WriteLine("Choose the option-->>");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        covidObj.BeneficiaryRegistration();
                       
                        break;
                    case 2:
                        covidObj.Vaccin();
                       
                        break;
                    case 3:
                        Environment.Exit(-1);
                        break;

                }
                Console.WriteLine("Do you want continue (yes/no)? ");
                choice = Console.ReadLine();
            } while (choice == "yes");

        }
        /// <summary>
        /// Get user Details in BeneficiaryRegistrationMethod and add in the list
        /// </summary>
        public void BeneficiaryRegistration()
        {

            Console.WriteLine("Enter the Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number:");
            long PhoneNo = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the City:");
            string City = Console.ReadLine();
            Console.WriteLine("Enter your Age:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Male \n2.Female \n3.Transgender");
            Gender Gender =(Gender)int.Parse(Console.ReadLine());
            Beneficiary add = new Beneficiary(Name, PhoneNo, City, Age, Gender);
            UserDetails.Add(add);
            Console.WriteLine("User Registration Successfull");
            Console.WriteLine("Your Registration ID: " + add.RegisterNo);
        }
        /// <summary>
        /// Creating vaccin method for get Vaccin details
        /// </summary>
        public void Vaccin()
        {
            string choice;
            Console.Write("Enter the Registration ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (Beneficiary data in UserDetails)
            {
                if (id == data.RegisterNo)
                {
                    do
                    {
                        // vaccination Methods
                        Console.WriteLine("1.Take Vaccination \n2.Vaccination History \n3.Next Due Date \n4.Exit");
                        Console.Write("Choose option-->");
                        
                        int option = int.Parse(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                //Vaccine Type
                                Console.WriteLine("1.Covid-Shield \n2.Covaccin \n3.sputnic");
                                Console.WriteLine("Which Dose you want?");
                                VaccinType vacType = (VaccinType)int.Parse(Console.ReadLine());

                                Vaccination user = new Vaccination(vacType, DateTime.Now);
                                if (data.VaccineDetails == null)
                                {

                                    data.VaccineDetails = new List<Vaccination>();
                                }
                                data.VaccineDetails.Add(user);
                                
                                Console.WriteLine("Successfully vaccinated!...");

                                break;
                            case 2:                               
                                foreach (Beneficiary history in UserDetails)
                                {
                                    if (history.VaccineDetails != null)
                                    {
                                        //Call Vaccindetail method from beneficiary Class
                                        history.VaccinDetails(id);                                       
                                    }
                                }

                                break;
                            case 3:
                                foreach (Beneficiary Duedate in UserDetails)
                                {
                                    //Call VaccinDueDate method from beneficiary Class
                                    Duedate.VaccinDueDate(id);
                                }
                                break;
                            case 4:                             
                                Environment.Exit(-1);
                                break;
                            default:
                                Console.WriteLine("Please Choose Correct option.....!");
                                break;

                        }
                        Console.WriteLine("Do you want continue (yes/no)? ");
                        choice = Console.ReadLine();

                    } while (choice == "yes");
                    
                }
               

            }
           
            
        }
    }
}
