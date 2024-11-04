using AcademicEntities;
using System.Net;
using System.Numerics;
namespace Tests
{
    [TestClass]
    public class StudentTest
    {
        string firstName = "FirstName";
        string middleName = "MiddleName";
        string lastName = "LastName";
        string birthDate = "04.11.24";
        string address = "Address";
        string phone = "Phone";

        [TestMethod]
        public void DataSetSafetyTest()
        {
            Student stud = new(firstName, middleName, lastName, birthDate, address, phone);

            Assert.IsNotNull(stud);
            StringAssert.Equals(firstName, stud.FirstName);
            StringAssert.Equals(middleName, stud.MiddleName);
            StringAssert.Equals(lastName, stud.LastName);
            StringAssert.Equals(birthDate, stud.BirthDate);
            StringAssert.Equals(address, stud.Address);
            StringAssert.Equals(phone, stud.PhoneNumber);
        }

        [TestMethod]
        public void EqualityTest()
        {
            Student stud1 = new(firstName, middleName, lastName, birthDate, address, phone);
            Student stud2 = new("AnotherFirstName", middleName, lastName, birthDate, address, phone);
            Assert.IsFalse(stud1.Equals(stud2));
            Assert.IsFalse(stud1 == stud2);
        }
    }
}
