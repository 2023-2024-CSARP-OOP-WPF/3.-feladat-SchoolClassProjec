using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolClassProject
{
    public class SchoolClass
    {
        public SchoolClass(int grade, string id, int monthlyPay, int numberOfStudent ) 
        {
            Grade = grade;
            Id = id;
            MonthlyPay = monthlyPay;
            NumberOfStudent = numberOfStudent;
        }
        public int Grade { get; set; }
        public string Id { get; set; }
        public int MonthlyPay { get; set; }
        public int NumberOfStudent { get; set; }


        public override string ToString()
        {
            return $"{Grade}{Id} ({MonthlyPay} Ft)\nAz osztályba {NumberOfStudent}db diák jár\n";
        }


        public static bool EqualTo(SchoolClass schoolClass1, SchoolClass schoolclass2)
        {
            if (schoolClass1.MonthlyPay==schoolclass2.MonthlyPay)
                return true;
            else
                return false;
        }
    }
}
