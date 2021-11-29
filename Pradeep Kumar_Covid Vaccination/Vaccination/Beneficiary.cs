using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    /// <summary>
    /// Create Enum for Gender option
    /// </summary>
    public enum Gender
    {
        male=1,female,transgender
    }
     /// <summary>
     /// Create Class for Bemeficiary properties
     /// </summary>
    class Beneficiary
    {

        private static int autoIncreament = 100;
        
        public int RegisterNo { get; set; }
        public string Name { get; set; }
        public long PhoneNo { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        /// <summary>
        /// Create list for VaccinationDetails
        /// </summary>
        public List<Vaccination> VaccineDetails
        {
            get;set;
        }
        /// <summary>
        /// Create Constractor for Beneficiary
        /// </summary>
        /// <param name="name">Get name</param>
        /// <param name="phoneNo">Get PhoneNumber</param>
        /// <param name="city">Get City</param>
        /// <param name="age">Get age</param>
        /// <param name="gender">get Gender</param>

        public Beneficiary(string name,long phoneNo,string city,int age,Gender gender)
        {
            this.Name = name;
            this.PhoneNo = phoneNo;
            this.City = city;
            this.Age = age;
            this.Gender = gender;
            this.RegisterNo = autoIncreament++;
           
            
        }
        /// <summary>
        /// Create Method for Get Vaccin Details
        /// </summary>

        public void VaccinDetails(int regNo)
        {

            if (this.RegisterNo == regNo)
            {
                if (VaccineDetails != null)
                {

                    foreach (Vaccination dt in VaccineDetails)
                    {
                        Console.WriteLine($"Your Vaccinated dose  : {dt.Vtype}");
                        Console.WriteLine($"Vaccinated Date: {dt.VaccinatedDate}");
                    }
                }
            }

        }
        /// <summary>
        /// Create a method VaccinDueDate for show next DueDate information
        /// </summary>
        public void VaccinDueDate(int regNo)
        {
            if(this.RegisterNo == regNo)
            {
                if (VaccineDetails != null)
                {

                    foreach (Vaccination dt in VaccineDetails)
                    {
                        if (VaccineDetails.Count == 1)
                        {
                            Console.WriteLine($"Your Vaccinated dose by : {dt.Vtype}");
                            Console.WriteLine($"Vaccinated Date: {dt.VaccinatedDate.AddDays(30)}");

                        }
                        else if (VaccineDetails.Count == 2)
                        {
                            Console.WriteLine("You have completed the vaccination course. Thanks for your participation in the vaccination drive.");
                            break;
                        }


                    }
                }
            }

        }
    }
}
