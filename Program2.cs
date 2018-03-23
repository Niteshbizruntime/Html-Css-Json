using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ConsoleApplication1
{


    [DataContract]
        public class User
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public int Age { get; set; }
        }
       
        class Program3
        {
        static MemoryStream stream;
        static User[] jsonData;
        static DataContractJsonSerializer jsonSerializer;

        static void Add()
        {
            Console.Write("How Many Record U Want To Add : ");
            int n = Convert.ToInt32(Console.ReadLine());
            jsonData = new User[n];
            for (int i = 0; i < n; i++)
            {
                User user = new User();
                Console.Write("Enter Name : ");
                user.Name = Console.ReadLine();
                Console.Write("Enter Age : ");
                user.Age = Convert.ToInt32(Console.ReadLine());
                jsonData[i] = user;
            }

        }

        static void JsonSerialize()
        {
            jsonSerializer = new DataContractJsonSerializer(typeof(User[]));
            stream = new MemoryStream();
            jsonSerializer.WriteObject(stream,jsonData);
            stream.Position = 0;
        }

        static void JsonDeSerialize()
        {
            User[] user = (User[])jsonSerializer.ReadObject(stream);
            foreach (User u in user)
            {
                Console.WriteLine(string.Concat("Hi My Name is "+ u.Name+ " I am " + u.Age +" Years Old"));
            }
        }
        static void Main(string[] args)
            {
            Add();
            JsonSerialize();
            JsonDeSerialize();
            Console.ReadKey();
            }
        }
    

}
