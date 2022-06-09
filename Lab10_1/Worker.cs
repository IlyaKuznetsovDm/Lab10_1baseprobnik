using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_1
{
    internal class Worker
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public int DateOfBirth { get; set; }
        public int NumberWorkshop { get; set; }
        public int ServiceNumber { get; set; }
        public string Education { get; set; }
        public int YearOfAdmissionToWork {  get; set; }

        public override string ToString()
        { 
            return Surname+"\n"+Name+ "\n" + Patronymic +"\n"+ PostalCode.ToString()+ "\n" +
                Country+ "\n"+ Region + "\n" + District + "\n" + City + "\n" + Street + "\n"+
                House + "\n"+ Apartment + "\n"+ DateOfBirth.ToString()+ "\n" + NumberWorkshop.ToString() + "\n" +
                ServiceNumber.ToString()+ "\n" + Education + "\n" + YearOfAdmissionToWork.ToString() + "\n";
        }
    }
  
}
