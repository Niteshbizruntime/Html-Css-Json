using System;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication1
{


    public class Student
        {
            public string Name { get; set; }
            public string Age { get; set; }
           public string Address { get; set; }
    }
        class Program1
        {
           


             static void Main(string[] args)
            {
            string jsonData = @"['Name':'Bala','Age':'23','Address':'BTM']";
            var details = JObject.Parse(jsonData);
              
                Console.WriteLine(string.Concat("Hi My Name is ", details["Name"], ", I am  " + details["Age"] + " Years Old"+" I Lives in "+ details["Address"]));
            
                Console.ReadLine();
            }
        }
    

}
