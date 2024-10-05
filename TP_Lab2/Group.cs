namespace TP_Lab2
{
    class Group
    {
        protected int _number;
        protected List<Student> _students;

        public Group(int number)
        {
            this._number = number;
            _students = new List<Student>();
        }

        public virtual Student this[int id]
        {
            set
            {
                for (int i = 0; i < _students.Count; i++)
                {
                    if (_students[i].id == id)
                    {
                        _students[i] = value;
                       
                        return;
                    }
                }
                throw new ArgumentException($"Студента c № {id} не возможно заменить; " +
                        "такого номера зачётной книжки ещё не существет");
            }
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
            str += "Группа " + _number + "\n";
            foreach (Student student in _students) {
                str += student.ToString() + "\n";
            }
            return str;
        }
    }
}
