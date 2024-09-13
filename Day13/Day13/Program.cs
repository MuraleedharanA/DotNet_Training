using System.Xml;

namespace Day13
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Double Salary { get; set; }
        public string Gender { get; set; }
    }
    internal class Program
    {

        public static void Main()
        {


            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Id = 1, Name = "Athi", Salary = 90000, Gender = "Female" });
            list.Add(new Employee() { Id = 1, Name = "Syam", Salary = 8000, Gender = "male" });
            list.Add(new Employee() { Id = 1, Name = "Akshay", Salary = 70000, Gender = "male" });
            list.Add(new Employee() { Id = 1, Name = "Yeshwika", Salary = 190000, Gender = "Female" });
            list.Add(new Employee() { Id = 1, Name = "Gayathri", Salary = 9022000, Gender = "Female" });
            list.Add(new Employee() { Id = 1, Name = "Reshma", Salary = 906777000, Gender = "Female" });

            XmlWriter writer = XmlWriter.Create("C:\\Users\\Administrator\\source\\repos\\Day13\\Day13\\xmlcontent\\xmlTest2.xml");
            //writer.WriteStartElement("employee");
            //writer.WriteElementString("ID", "12");
            //writer.WriteElementString("Name", "Athi");
            //writer.WriteElementString("Salary", "12000");
            //writer.WriteElementString("Genter", "F");
            //writer.WriteEndElement();
            //writer.Close();
            //writer.Flush();

            XmlReader reader = new XmlTextReader("C:\\Users\\Administrator\\source\\repos\\Day13\\Day13\\xmlcontent\\xmlTest.xml");
            //Console.WriteLine(reader.Name);
            //    Console.WriteLine(reader.BaseURI);
            //Console.WriteLine(reader.LocalName);
            //while(reader.Read())
            //{
            //    if(reader.HasValue)
            //    {
            //        Console.WriteLine(reader.Value);
            //    }
            //}
            
            while (reader.Read())
            {
                if (reader.NodeType==XmlNodeType.Element)
                {
                    writer.WriteNode(reader,true); 
                }
            }
            writer.Close();
        }
    }
}