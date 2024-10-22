namespace TP_Lab2
{
    class UI
    {
        public static void Main(string[] args)
        {
            try
            {
                Student student = new Student(4, "Никита", "Аверин", "НД", "НД", "НД");
                Student student2 = new Student(0, "Александр", "Владимирович", "Евдокимов", "НД", "НД", "НД");
                Student student3 = new Student(1, "Владислав", "Бекренёв", "НД", "НД", "НД");
                Student student4 = new Student(2, "Артём", "Андреевич", "Блохин", "НД", "НД", "НД");
                Student student5 = new Student(3, "Михаил", "Коньков", "НД", "НД", "НД");

                student3.phoneNumber = "+7 960 570 25 14";

                Group group = new Group(245);
                group.addStudent(student);
                group.addStudent(student2);
                group.addStudent(student3);
                group.addStudent(student4);
                group.addStudent(student5);

                group.removeStudent(0);

                group.removeStudent(student);

                Console.WriteLine("Студент с номером зачётной книжки 3: \n" + group[3]);

                Console.Write(group.getInfo());
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }
}