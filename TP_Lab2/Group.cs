namespace TP_Lab2
{
    class Group
    {
        protected string _groupName;
        protected List<Student> _students;

        public Group(string groupName)
        {
            _groupName = groupName;
            _students = new List<Student>();
        }

        public Group(int number) : this(number.ToString()) { }

        public virtual Student this[int id]
        {
            get {
                for (int i = 0; i < _students.Count; i++)
                {
                    if (_students[i].id == id) return _students[i];
                }
                throw new ArgumentException($"Студента с номером зачётной {id} книжки не существует");
            }
        }

        public virtual void addStudent(Student student)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].id == student.id) throw new ArgumentException($"Студент уже существует");
            }
            _students.Add(student);
            _students.Sort();
        }

        public virtual void removeStudent(int id) {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].id == id) { _students.RemoveAt(i); return; }
            }
            throw new ArgumentException($"Студента с номером зачётной книжки {id} не существует; Удаление не произведено");
        }

        public virtual void removeStudent(Student student)
        {
            if (_students.Contains(student)) _students.Remove(student);
            else throw new ArgumentException("Студента не существует; Удаление не произведено");
        }

        public virtual string getInfo()
        {
            string str = string.Empty;
            str += "Группа " + _groupName + "\n";
            foreach (Student student in _students) {
                str += student.ToString() + "\n";
            }
            return str;
        }

        public override string ToString()
        {
            return this.getInfo();
        }
    }
}
