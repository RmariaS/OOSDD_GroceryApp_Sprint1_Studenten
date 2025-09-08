namespace Grocery.Core.Models
{
    public class GroceryList : Model
    {
        public DateOnly Date { get; set; }
        public int ClientId { get; set; }
        public string Color { get; set; }

        public GroceryList(int id, string name, DateOnly date, string color, int clientId) : base(id, name)
        {
            Id = id;
            Name = name;
            Date = date;
            Color = color;
            ClientId = clientId;
        }

    }
}
