namespace Grocery.Core.Models
{
    // Representeert een item in een boodschappenlijst
    public class GroceryListItem : Model
    {
        
        public int GroceryListId { get; set; }

        
        public int ProductId { get; set; }

        
        public int Amount { get; set; }

        // Het gekoppelde Product object met productdetails
        public Product Product { get; set; } = new(0, "None", 0);

        // Constructor voor het maken van een nieuw GroceryListItem
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            //  de waarden toewijzen aan de properties
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;
        }

        // zonder parameter
        public GroceryListItem() : base(0, "")
        {
            // Standaardwaarden worden al gezet door property inzetting
        }

        // Override ToString voor betere debugging en logging
        public override string ToString()
        {
            return $"Item {Id}: {Amount}x {Product.Name} (GroceryListId: {GroceryListId})";
        }
    }
}
