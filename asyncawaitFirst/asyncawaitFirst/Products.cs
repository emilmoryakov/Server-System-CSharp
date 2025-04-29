using System.Xml.Linq;

namespace asyncawaitFirst
{
    public class Products
    {
        public int responseCode { get; set; }
        public Product[] products { get; set; }

    }

    public class Product
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? price { get; set; }
        public string? brand { get; set; }
        public Category? category { get; set; }

        public override string ToString()
        {
            string returnString =
                $"Product ID: {id}\n" +
                $"Product ID: {name}\n" +
                $"Product ID: {price}\n" +
                $"Product ID: {brand}\n";


            returnString.Concat(category.ToString());


            return returnString;
        }
    }

    public class Category
    {
        public Usertype usertype { get; set; }
        public string category { get; set; }

        public override string ToString()
        {
            string returnString =
                $"Category Name: {category}";

            returnString.Concat(usertype.ToString());

        
            return returnString;
        }



    }

    public class Usertype
    {
        public string? usertype { get; set; }

    }

}
