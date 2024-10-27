using AcademicEntities;
namespace UI
{
    class UI
    {
        public static void Main()
        {
            try
            {
                Student student = new(4, "Никита", "Аверин", "НД", "НД", "НД");
                Student student2 = new(0, "Александр", "Владимирович", "Евдокимов", "НД", "НД", "НД");
                Student student3 = new(1, "Владислав", "Бекренёв", "НД", "НД", "НД");
                Student student4 = new(2, "Артём", "Андреевич", "Блохин", "НД", "НД", "НД");
                Student student5 = new(3, "Михаил", "Коньков", "НД", "НД", "НД");

                Group group = new("245");
                group.AddStudent(student);
                group.AddStudent(student2);
                group.AddStudent(student3);
                group.AddStudent(student4);
                group.AddStudent(student5);

                group[3]=new("Ирина", "Кочеткова", "НД", "НД", "НД");
                group[3].PhoneNumber = "8 800 555 35 35";

                group.RemoveStudent(0);

                group.RemoveStudent(student);

                Console.WriteLine("Студент с номером зачётной книжки 3: \n" + group[3]);

                Console.Write(group.GetInfo());

                group.RemoveStudent(student2);
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }
}