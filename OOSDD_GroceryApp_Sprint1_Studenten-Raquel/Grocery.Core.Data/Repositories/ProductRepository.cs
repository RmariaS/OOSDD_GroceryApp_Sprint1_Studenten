using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories

    public class Product
{
    public int Id { get; set; }
    public string Naam { get; set; }
    public int Voorraad { get; set; }

    // Constructor zonder Id — handig voor testdata, maar Id blijft 0!
    public Product(string naam, int voorraad)
    {
        Naam = naam;
        Voorraad = voorraad;
        // Id blijft 0 — dat is een probleem als je meerdere producten hebt!
    }

{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;
        public ProductRepository()
        {
            products = [
                new Product("Melk", 300),
                new Product("Kaas", 100),
                new Product("Brood", 400),
                new Product("Cornflakes", 0)
				];
        }
        public List<Product> GetAll()
        {
            return products; //wijzig dit in de gemaakte lijst uit de constructo
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
