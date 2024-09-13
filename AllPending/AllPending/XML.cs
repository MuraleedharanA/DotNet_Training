using System.Xml;
using System.Text;


namespace AllPending
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
    }
    internal class XML
    {
        static void MainXML(string[] args)
        {
            List<Employee> list = new List<Employee>()
                {
                new Employee { Id = 1,Name="Athira",Dept="IT"},
                new Employee { Id = 2,Name="Syam", Dept="FIFA"},
                new Employee { Id = 3,Name="Akshay",Dept="Finance"}
                };
            //XmlWriter writer = XmlWriter.Create("C:\\Users\\Administrator\\source\\repos\\AllPending\\AllPending\\Files\\testFile.xml");
            //writer.WriteStartElement("Employee");
            //foreach (Employee e in list)
            //{

            //    writer.WriteElementString("ID", (e.Id).ToString());
            //    writer.WriteElementString("Name", e.Name);
            //    writer.WriteElementString("Dept", e.Dept);
            //    //writer.WriteEndAttribute();
            //}
            //writer.WriteEndDocument();
            //writer.Flush();
            //writer.Close();
            //XmlTextReader reader = new XmlTextReader("C:\\Users\\Administrator\\source\\repos\\AllPending\\AllPending\\Files\\testFile.xml");
            //XmlTextWriter writer =new XmlTextWriter("C:\\Users\\Administrator\\source\\repos\\AllPending\\AllPending\\Files\\testFileNew.xml",null);


            //while(reader.Read())
            //{
            //    if(reader.NodeType == XmlNodeType.Element)
            //    {
            //        writer.WriteNode(reader, true);
            //    }
            //}
            //writer.Close();
            //XmlDocument xmlDoc = new XmlDocument();
            //String filePath = "C:\\Users\\Administrator\\source\\repos\\AllPending\\AllPending\\Files\\testFile.xml";
            //xmlDoc.Load(filePath);
            //xmlDoc.Save(Console.Out);

            XmlDocument xmlDoc2 = new XmlDocument();
            XmlTextReader reader = new XmlTextReader("C:\\Users\\Administrator\\source\\repos\\AllPending\\AllPending\\Files\\testFile.xml");
            xmlDoc2.Load(reader);
            xmlDoc2.Save(Console.Out);

            XmlTextWriter writer = new XmlTextWriter("C:\\Users\\Administrator\\source\\repos\\AllPending\\AllPending\\Files\\testFileNew.xml", null);
            writer.Formatting = Formatting.Indented;

            XmlDocumentFragment frag = xmlDoc2.CreateDocumentFragment();
            frag.InnerXml=("<IDD>123</IDD>");
            XmlNode node = xmlDoc2.DocumentElement;
            node.AppendChild(frag);
            xmlDoc2.Save(writer);


        
        
        
        }   
    }
}