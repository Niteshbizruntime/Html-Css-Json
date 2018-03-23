using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    class Employee
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
    class Program
    {
        static List<Employee> list = new List<Employee>();
        static void Add()
        {
            Console.Write("How Many Record U Want To Add In List : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Employee e = new Employee();
                Console.Write("Enter Name : ");
                e.Name = Console.ReadLine();
                Console.Write("Enter Age : ");
                e.Age = Console.ReadLine();
                list.Add(e);
            }

        }

        static void ConvertIntoJson()
        {

            StreamWriter sw = new StreamWriter(new FileStream("New.json", FileMode.Create));
            var s = JsonConvert.SerializeObject(list);
            sw.Write(s);
            sw.Close();
        }

        static void ConverIntoString()
        {
            string json = File.ReadAllText("New.json");
            Employee[] s1 = JsonConvert.DeserializeObject<Employee[]>(json);
            int i = 1;
            foreach (Employee s2 in s1)
            {
                Console.WriteLine("\n" + i + " Record");
                Console.WriteLine("Name : " + s2.Name);
                Console.WriteLine("Age  : " + s2.Age);
                i++;
            }
        }
        static void Main(string[] args)
        {
            Add();
            ConvertIntoJson();
            ConverIntoString(); 
            Console.ReadKey();
        }
    }
}
