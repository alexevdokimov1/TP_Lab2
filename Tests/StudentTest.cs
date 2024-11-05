using AcademicEntities;
using System.Net;
using System.Numerics;
namespace Tests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void DataSetSafetyTest()
        {
            Student stud = new(TestData.firstName, TestData.middleName, TestData.lastName, TestData.birthDate, TestData.address, TestData.phone);

            Assert.IsNotNull(stud);
            StringAssert.Equals(TestData.firstName, stud.FirstName);
            StringAssert.Equals(TestData.middleName, stud.MiddleName);
            StringAssert.Equals(TestData.lastName, stud.LastName);
            StringAssert.Equals(TestData.birthDate, stud.BirthDate);
            StringAssert.Equals(TestData.address, stud.Address);
            StringAssert.Equals(TestData.phone, stud.PhoneNumber);
        }

        [TestMethod]
        public void EqualityTest()
        {
            Student stud1 = new(TestData.firstName, TestData.middleName, TestData.lastName, TestData.birthDate, TestData.address, TestData.phone);
            Student stud2 = new(TestData.anotherFirstName, TestData.middleName, TestData.lastName, TestData.birthDate, TestData.address, TestData.phone);
            Student stud2_copy = stud2;
            Assert.IsFalse(stud1.Equals(stud2));
            Assert.IsFalse(stud1 == stud2);
            Assert.IsTrue(stud2 != stud1);
            Assert.IsFalse(stud2 != stud2_copy);
        }
    }
}