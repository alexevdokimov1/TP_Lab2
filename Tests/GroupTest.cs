using AcademicEntities;
namespace Tests
{
    [TestClass]
    public class GroupTest
    {
        [TestMethod]
        public void Test()
        {
            string firstName = "FirstName";
            string middleName = "MiddleName";
            string lastName = "LastName";
            string birthDate = "04.11.24";
            string address = "Address";
            string phone = "Phone";

            Student stud = new(0, firstName, middleName, lastName, birthDate, address, phone);
            Student stud2 = new(1, firstName, middleName, lastName, birthDate, address, phone);
            Student stud3 = new(1, firstName, middleName, lastName, birthDate, address, phone);
            Student stud4 = new(2, firstName, middleName, lastName, birthDate, address, phone);

            AcademicEntities.Group group = new("Group"); 
            group.AddStudent(stud);
            group.AddStudent(stud2);
            Assert.ThrowsException<ArgumentException>(() => group.AddStudent(stud));
            Assert.ThrowsException<ArgumentException>(() => group.AddStudent(stud3));
            Assert.ThrowsException<ArgumentException>(() => group.RemoveStudent(stud4));
            Assert.ThrowsException<ArgumentException>(() => group.RemoveStudent(3));
            Assert.AreEqual(group[0], stud);
            Assert.ThrowsException<ArgumentException>(() => group[5]);
            Assert.ThrowsException<ArgumentException>(() => group[5] = stud);
        }
    }
}
