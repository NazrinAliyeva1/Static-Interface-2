using Static__Interface_2_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Interface_2_Task.Models
{
    internal class Student : ICodeAcademy
    {
        private static int Count = 0;
        public int Id { get; set; } = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set ; }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Count++;
            Id = Count;
            GenerateEmail();
        }
        public static void CheckName()
        {
            Console.WriteLine("CheckName metodu ise dusdu!");
        }
        public void GenerateEmail()
        {
            if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname))
            {
                string name = Name.ToLower();
                string surname = Surname.ToLower();
                CodeEmail = $"{name}.{surname}{Id}@code.edu.az";

            }
            else
            {
                Console.WriteLine("Ad ve soyad bos ola bilmez. Mail yaradilmadi. :( ");
            }


        }


    }
}
