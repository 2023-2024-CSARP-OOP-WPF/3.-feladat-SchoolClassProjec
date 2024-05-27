using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> _schoolclasses = new List<SchoolClass>();

        public SchoolClassRepo(List<SchoolClass> schoolclasses)
        {
            _schoolclasses = schoolclasses;
        }

        public List<SchoolClass> FindAll() => _schoolclasses;

        public string MostPaidSchoolClass()
        {
            if (!_schoolclasses.Any())
            {
                return string.Empty;
            }
            if (_schoolclasses.Select(sclass => sclass.MonthlyPay).Distinct().Count() == 1)
            {
                return "Ugyan annyi jut egy főre";
            }
            return $"{_schoolclasses.OrderByDescending(sclass => sclass.MonthlyPay).ThenBy(sclass => sclass.NumberOfStudent).First().Grade}{_schoolclasses.OrderByDescending(sclass => sclass.MonthlyPay).ThenBy(sclass => sclass.NumberOfStudent).First().Id}";
        }

    }
}
