namespace BinApi.Repositories.Item
{
    /// <summary>
    /// Describes an Item record in the database.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The unique identifier for the Item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The short description of the Item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The current inventory quantity of the Item.
        /// </summary>
        public int Quantity { get; set; }
    }
}
