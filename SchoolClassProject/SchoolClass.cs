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
        public SchoolClass(int grade, string id, int monthlyPay ) 
        {
            Grade = grade;
            Id = id;
            MonthlyPay = monthlyPay;
        }
        public int Grade { get; set; }
        public string Id { get; set; }
        public int MonthlyPay { get; set; }




        public override string ToString()
        {
            return $"{Grade}{Id} ({MonthlyPay} Ft)";
        }

        public static bool EqualTo(SchoolClass schoolClass1, SchoolClass schoolclass2)
        {
            if (schoolClass1.Grade == schoolclass2.Grade && schoolClass1.Id == schoolclass2.Id && schoolClass1.MonthlyPay==schoolclass2.MonthlyPay)
                return true;
            else
                return false;
        }
    }
}
