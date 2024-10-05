namespace TP_Lab2
{
    class UI
    {
        public static void Main(string[] args)
        {
            try
            {
                Student student = new Student(0, "Александр", "Владимирович", "Евдокимов", "НД", "НД", "НД");
                Student student2 = new Student(2, "Артём","Андреевич", "Блохин", "НД", "НД", "НД");
                Student student3 = new Student(3, "Михаил", "Коньков", "НД", "НД", "НД");

                Group group = new Group(245);
                group.addStudent(student);
                group.addStudent(student2);
                group.addStudent(student3);

                Console.Write(group.getInfo());
            }
            catch (Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
    }
}