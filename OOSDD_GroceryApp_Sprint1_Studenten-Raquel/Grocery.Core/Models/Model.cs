namespace Grocery.Core.Models
{
    public abstract class Model(int id, string name)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
    }
}
