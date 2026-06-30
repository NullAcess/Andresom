namespace Andresom.Items
{
    public abstract class Item
    {
        public string Name { get; private set; }

        public Item(string name)
        {
            Name = name;
        }
    }
}
