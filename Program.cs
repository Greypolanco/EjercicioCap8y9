
namespace Ejercicios
{
    public class Ejercicios
    {
        public static void Main(String[] args){
            dateTime();
            System.Console.WriteLine("----------");
            Chain();

            
            
        }

        public static void dateTime(){
            
            DateTime Date = DateTime.Now;

            Date.ToString(" HH:mm dddd, M, yyyy");
            System.Console.WriteLine(Date);
        }

        public static void Chain(){
            int result = 0;
            string? chain1, chain2;
            System.Console.WriteLine("introduca una palabra: ");
            chain1 = Console.ReadLine();
            System.Console.WriteLine("Introduzca otra palabra ");
            chain2 = Console.ReadLine();

            result = string.Compare(chain1, chain2);

            if(result <= 0)
            {
                System.Console.WriteLine(chain1 + "\n" + chain2);
            }
            else
            {
                System.Console.WriteLine(chain2 + "\n" + chain1);
            }

        }
    }

    public struct Product
    {
        public string product {get; set;}
        public int quantity_product{get; set;}
        public decimal precie {get; set;}

        Product(string pproduct, int pquantity_product, decimal pprecie)
        {
            product = pproduct;
            quantity_product = pquantity_product;
            precie = pprecie;
        }

    }

    public class Store
    {
        public List<Product> products{get; set;}

        public Store()
        {
            products = new List<Product>();
        }

        public void Addproduct(Product product)
        {
            products.Add(product);

        }
    }

    enum StarType{
        RedGiant,
        WhiteDwarf,
        NeutronStar,
        BlackHole
    };
}






