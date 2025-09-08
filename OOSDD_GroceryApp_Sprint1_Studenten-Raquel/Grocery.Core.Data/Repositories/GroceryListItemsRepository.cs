using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class GroceryListItemsRepository : IGroceryListItemsRepository
    {
        // Member variabele omgezet naar property
        private List<GroceryListItem> GroceryListItems { get; }

        //  Constructor met parameter - doorgegeven waarden koppelen aan properties
        public GroceryListItemsRepository(List<GroceryListItem> groceryListItems)
        {
            GroceryListItems = groceryListItems; // Doorgegeven waarde gekoppeld aan property
        }

        public List<GroceryListItem> GetAll()
        {
            return GroceryListItems;
        }

        public List<GroceryListItem> GetAllOnGroceryListId(int id)
        {
            return GroceryListItems.Where(g => g.GroceryListId == id).ToList();
        }

        public GroceryListItem Add(GroceryListItem item)
        {
            throw new NotImplementedException();
        }

        public GroceryListItem? Delete(GroceryListItem item)
        {
            throw new NotImplementedException();
        }

        public GroceryListItem? Get(int id)
        {
            throw new NotImplementedException();
        }

        public GroceryListItem? Update(GroceryListItem item)
        {
            throw new NotImplementedException();
        }
    }
}
