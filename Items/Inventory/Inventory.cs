namespace Andresom.Items.Inventoryes
{
    internal class Inventory
    {
        public List<Item> Items { get; private set; } = new List<Item>();

        public void AddItem(Item item)
        {
            if (item != null)
            {
                Items.Add(item);
            }
        }
    }
}
