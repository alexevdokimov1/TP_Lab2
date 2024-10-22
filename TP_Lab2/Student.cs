using System.Text;

namespace TP_Lab2
{
    class Student : IComparable
    {
        protected int _id;
        protected string _firstName;
        protected string _middleName;
        protected string _lastName;
        protected string _birthDate;
        protected string _addres;
        protected string _phoneNumber;

        public int id {
            get => _id;
            set => _id = value;
        }
        public string firstName
        { 
            get => _firstName;
            set => _firstName = value;
        }
        public string middleName
        {
            get => _middleName;
            set => _middleName = value;
        }
        public string lastName { 
            get => _lastName;
            set => _lastName = value;
        }
        public string birthDate {
            get => _birthDate; 
            set => _birthDate = value;
        }
        public string addres { 
            get => _addres; 
            set => _addres = value;
        }
        public string phoneNumber { 
            get => _phoneNumber;
            set {  if (value.IndexOf("8", 0, 1) != -1 || value.IndexOf("+7", 0, 2) != -1)
                    _phoneNumber = value;
                else throw new ArgumentException($"Код номер страны должен принадлежать РФ (+7/8):\n{value}");
            }
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) return false;
            return ((Student) obj) == this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Student(int id, string firstName, string middleName, string lastName, string birthDate, string addres, string phoneNumber)
        {
            _id = id;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _birthDate = birthDate;
            _addres = addres;
            _phoneNumber = phoneNumber;
        }

        public Student(int id, string firstName, string lastName, string birthDate, string addres, string phoneNumber)
            : this(id, firstName, "", lastName, birthDate, addres, phoneNumber) { }

        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append("Номер зачётной книжки: " + this._id + "; ");
            strBuild.Append("ФИО: " + this._lastName + " " + this._firstName);
            if(!string.IsNullOrEmpty(this._middleName)) strBuild.Append(" " + this._middleName + "; ");
            else strBuild.Append("; ");
            strBuild.Append("Дата рождения: " + this._birthDate + "; ");
            strBuild.Append("Адресс: " + this._addres + "; ");
            strBuild.Append("Номер телефона: " + this._phoneNumber);
            return strBuild.ToString();
        }

        public static bool operator == (Student a, Student b) => 
            a.id == b.id && a.firstName == b.firstName && a.middleName == b.middleName
            && a.lastName == b.lastName && a.birthDate == b.birthDate 
            && a.addres == b.addres && a.phoneNumber == b.phoneNumber;

        public static bool operator != (Student a, Student b) =>
            a.id != b.id || a.firstName != b.firstName || a.middleName != b.middleName
            || a.lastName != b.lastName || a.birthDate != b.birthDate
            || a.addres != b.addres || a.phoneNumber != b.phoneNumber;

        public int CompareTo(object? obj)
        {
            if (obj is Student stud) return lastName.CompareTo(stud.lastName);
            else throw new ArgumentException("Некорректное сравнение");
        }
    }
}