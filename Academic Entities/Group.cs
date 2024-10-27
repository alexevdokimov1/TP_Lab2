using System.Text;
namespace AcademicEntities
{
    public class Group(string groupName)
    {
        private string groupName = groupName;
        private List<Student> students = [];
        public Student this[int id]
        {
           get {
               Student? found = students.Find(x => x.Id == id);
               if (found is not null) return found;
               throw new ArgumentException($"Студента с номером зачётной книжки {id} не существует");
           }
           set
           {
               Student? found = students.Find(x => x.Id == id);
               if (found is null) throw new ArgumentException($"Студента c №{id} не возможно заменить; " +
                       "такого номера зачётной книжки ещё не существет; нужно добавить студента");
               int indexOfStudent = students.IndexOf(found);
               value.Id = id;
               students[indexOfStudent] = value;
               students.Sort();
            }
        }

        public void AddStudent(Student student)
        {
           if(student.Id < 0) throw new ArgumentException($"Студент с номером зачётной книжки {student.Id} не может быть создан");
           Student? found = students.Find(x => x.Id == student.Id);
           if (found is not null) throw new ArgumentException($"Студент уже существует");
           students.Add(student);
           students.Sort();
        }

        public void RemoveStudent(int id) {
           Student? found = students.Find(x => x.Id == id);
           if (found is null) throw new ArgumentException($"Студента с номером зачётной книжки {id} не существует");
           students.Remove(found);
        }

        public void RemoveStudent(Student student)
        {
           if (!students.Contains(student)) throw new ArgumentException($"Студента {student.LastName} не существует");
           students.Remove(student);
        }

        public string GetInfo()
        {
           StringBuilder stringBuilder = new();
           stringBuilder.Append($"Группа {groupName}\n");
           foreach (Student student in students) {
               stringBuilder.Append(student.ToString() + "\n");
           }
           return stringBuilder.ToString();
        }
        public override string ToString()
        {
           return this.GetInfo();
        }
    }
}