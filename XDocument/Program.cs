using System.Xml.Linq;

namespace X_Document
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*XDocument doc = new XDocument(
                new XElement("RootElement",  // Корневой каталог
                new XElement("ChieldElement", "Value"), // Вложенный каталог в корневой каталог
                new XElement("AnotherChield",  // Вложенный каталог в корневой каталог, 
                    new XAttribute("Attribute", "AttributeValue") // Ещё одно вложение (третий уровень)
                )
                ) 
                );
            doc.Root.Add(new XElement("NewChild")); // Добавляем новую подпупку в корневую
            XElement childElement = doc.Element("RootElement").Element("ChildElement");
            IEnumerable<XElement> childElements = doc.Element("RootElement").Elements("ChildElement"); // Список из дочек корневого каталога
            childElement.Value = "NewValue";
            doc.Root.Element("ChildElement").Add(new XAttribute("NewAttribute", "AttributeValue"));
           
            XElement childAnother = doc.Element("RootElement").Element("AnotherElement");
            childAnother.SetAttributeValue("Attribute", "asd"); // Вместо "AttributeValue" будет "asd"*/

            // Задача 1 - Каталог продуктов
            Catalog catalog = new Catalog();
            catalog.AddProduct(new Product { Id = 1, Name = "Product 1", Price = 10.5, Category = "Category 1" });
            catalog.AddProduct(new Product { Id = 2, Name = "Product 2", Price = 20.75, Category = "Category 2" });
            catalog.SaveToJson("Produts.json");
            catalog.LoadFromJson("Produts.json");
            foreach(var i in catalog.products)
            {
                Console.WriteLine($"ID: {i.Id}, Name: {i.Name}, Price: {i.Price}, Category: {i.Category}");
            }
            catalog.SaveToXML("Produts.xml");
            catalog.LoadFromXML("Produts.xml");
            foreach (var i in catalog.products)
            {
                Console.WriteLine($"ID: {i.Id}, Name: {i.Name}, Price: {i.Price}, Category: {i.Category}");
            }
            IEnumerable<Product> sortedProducts = catalog.FiltrSortProductByPrice();
            foreach (var i in sortedProducts)
            {
                Console.WriteLine($"ID: {i.Id}, Name: {i.Name}, Price: {i.Price}, Category: {i.Category}");
            }
        }
    }
}
