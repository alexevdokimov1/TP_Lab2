using System.Data.SqlTypes;
using System.Text;

namespace TP_Lab2
{
    class Student : IComparable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Addres { get; set; }
        public string PhoneNumber { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj is null) return false;
            return ((Student) obj) == this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Student(int id, string firstName, string middleName, string lastName, 
            string birthDate, string addres, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDate = birthDate;
            Addres = addres;
            PhoneNumber = phoneNumber;
        }

        public Student(string firstName, string middleName, string lastName, string birthDate, string addres, string phoneNumber)
            : this(-1, firstName, middleName, lastName, birthDate, addres, phoneNumber) { }

        public Student(int id, string firstName, string lastName, string birthDate, string addres, string phoneNumber)
            : this(id, firstName, "", lastName, birthDate, addres, phoneNumber) { }

        public Student(string firstName, string lastName, string birthDate, string addres, string phoneNumber)
            : this(firstName, "", lastName, birthDate, addres, phoneNumber) { }

        public override string ToString()
        {
            StringBuilder strBuild = new();
            strBuild.Append("Номер зачётной книжки: " + this.Id + "; ");
            strBuild.Append("ФИО: " + this.LastName + " " + this.FirstName);
            if(!string.IsNullOrEmpty(this.MiddleName)) strBuild.Append(" " + this.MiddleName + "; ");
            else strBuild.Append("; ");
            strBuild.Append("Дата рождения: " + this.BirthDate + "; ");
            strBuild.Append("Адресс: " + this.Addres + "; ");
            strBuild.Append("Номер телефона: " + this.PhoneNumber);
            return strBuild.ToString();
        }

        public static bool operator == (Student a, Student b) => 
            a.Id == b.Id && a.FirstName == b.FirstName && a.MiddleName == b.MiddleName
            && a.LastName == b.LastName && a.BirthDate == b.BirthDate 
            && a.Addres == b.Addres && a.PhoneNumber == b.PhoneNumber;

        public static bool operator != (Student a, Student b) => !(a == b);

        public int CompareTo(object? obj)
        {
            if (obj is Student stud) return LastName.CompareTo(stud.LastName);
            else throw new ArgumentException("Некорректное сравнение");
        }
    }
}