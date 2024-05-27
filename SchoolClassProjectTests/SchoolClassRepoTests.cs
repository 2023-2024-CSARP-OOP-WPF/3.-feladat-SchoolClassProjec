using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Tests
{
    [TestClass()]
    public class SchoolClassRepoTests
    {
        [TestMethod()]
        public void MostPaidSchoolClassTestEmptyList()
        {
            // arrange
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(new List<SchoolClass>());
            // act
            string actualSchoolClass = schoolClassRepo.MostPaidSchoolClass();
            string expectedSchoolClass = string.Empty;
            // assert
            Assert.AreEqual(expectedSchoolClass, actualSchoolClass);
        }

        [TestMethod()]
        public void MostPaidSchoolClassTestsamePaid()
        {
            // arrange
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(
               new List<SchoolClass>
               {
        new SchoolClass(9,".a" ,1000 , 10),
        new SchoolClass(9,".b" ,1000 , 10),
               }
           );
            // act
            string actualSchoolClass = schoolClassRepo.MostPaidSchoolClass();
            string expectedSchoolClass = "Ugyan annyi jut egy főre";
            // assert
            Assert.AreEqual(expectedSchoolClass, actualSchoolClass);
        }

        [TestMethod()]
        public void MostPaidSchoolClassTestsamePaidLessStudent()
        {
            // arrange
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(
               new List<SchoolClass>
               {
        new SchoolClass(9,".a" ,1000 , 10),
        new SchoolClass(9,".b" ,1000 , 15),
               }
           );
            // act
            string actualSchoolClass = schoolClassRepo.MostPaidSchoolClass();
            string expectedSchoolClass = "Ugyan annyi jut egy főre";
            // assert
            Assert.AreEqual(expectedSchoolClass, actualSchoolClass);
        }

        [TestMethod()]
        public void MostPaidSchoolClassTestPaidMoreSameStudent()
        {
            // arrange
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(
               new List<SchoolClass>
               {
        new SchoolClass(9,".a" ,1500 , 10),
        new SchoolClass(9,".b" ,1000 , 10),
               }
           );
            // act
            string actualSchoolClass = schoolClassRepo.MostPaidSchoolClass();
            string expectedSchoolClass = "9.a";
            // assert
            Assert.AreEqual(expectedSchoolClass, actualSchoolClass);
        }
    }

}