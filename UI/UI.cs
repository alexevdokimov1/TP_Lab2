using AcademicEntities;
namespace UI
{
    class UI
    {
        public static void Main()
        {
            
                Group group = new("245");
                
                bool isRunning = true;
                int currentAddedIndex = 0;
                while (isRunning)
                {
                try
                {
                    Console.Write("Введите команду:\n0 - выход\n1 - добавить студента\n2 - удалить студента\n3 - посмотреть студентов\n");
                    int code = Convert.ToInt32(Console.ReadLine());
                    switch (code)
                    {
                        case 0: isRunning = false; break;
                        case 1:
                            Console.WriteLine("Введите имя");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите фамилию");
                            string sourname = Console.ReadLine();
                            
                            group.AddStudent(new Student(currentAddedIndex, name, sourname, "неизвестно", "неизвестно", "неизвестно"));
                            currentAddedIndex++;
                            break;
                        case 2:
                            Console.WriteLine("Введите номер студента");
                            group.RemoveStudent(Convert.ToInt32(Console.ReadLine()));
                            break;
                        case 3:
                            Console.WriteLine(group);
                            break;
                        default:
                            Console.WriteLine("Нет такой команды");
                            break;
                    }
                }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
           
        }
    }
}