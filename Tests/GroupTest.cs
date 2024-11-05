using AcademicEntities;
namespace Tests
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void Test()
        {
            

            Student stud = new(0, TestData.firstName, TestData.middleName, TestData.lastName, TestData.birthDate, TestData.address, TestData.phone);
            Student stud2 = new(1, TestData.firstName, TestData.middleName, TestData.lastName, TestData.birthDate, TestData.address, TestData.phone);
            Student stud3 = new(1, TestData.firstName, TestData.middleName, TestData.lastName, TestData.birthDate, TestData.address, TestData.phone);
            Student stud4 = new(2, TestData.firstName, TestData.middleName, TestData.lastName, TestData.birthDate, TestData.address, TestData.phone);

            AcademicEntities.Group group = new("Group"); 
            group.AddStudent(stud);
            group.AddStudent(stud2);
            Assert.AreEqual(group[0], stud);
            Assert.AreEqual(group[1], stud2);
            Assert.ThrowsException<ArgumentException>(() => group.AddStudent(stud));
            Assert.ThrowsException<ArgumentException>(() => group.AddStudent(stud3));
            Assert.ThrowsException<ArgumentException>(() => group.RemoveStudent(stud4));
            Assert.ThrowsException<ArgumentException>(() => group.RemoveStudent(3));
            Assert.ThrowsException<ArgumentException>(() => group[5]);
            Assert.ThrowsException<ArgumentException>(() => group[5] = stud);
        }
    }
}
