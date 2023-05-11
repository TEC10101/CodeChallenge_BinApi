namespace BinApi.Repositories.Bin
{
    /// <summary>
    /// Describes a Bin record in the database.
    /// </summary>
    public class Bin
    {
        /// <summary>
        /// The unique identifier for the Bin.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// A short description of the Bin.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The current Items in the bin.
        /// </summary>
        public List<Item.Item> Items { get; set; }
    }
}
