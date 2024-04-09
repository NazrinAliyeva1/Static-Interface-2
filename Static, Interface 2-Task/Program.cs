using Static__Interface_2_Task.Models;

namespace Static__Interface_2_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student("NazRIN", "AlIYEva");
            Console.WriteLine($"Id of Student: {student.Id}");
            student.GenerateEmail();
            Console.WriteLine($"CodeEmail of Student: {student.CodeEmail}");

            Console.WriteLine("\n");

            Student student2 = new Student("sefa", "MikayILova");
            Console.WriteLine($"Id of Student: {student2.Id}");
            student2.GenerateEmail();
            Console.WriteLine($"CodeEmail of Student: {student2.CodeEmail}");

            Console.WriteLine("\n");
            Student.CheckName();

        }
    }
}
