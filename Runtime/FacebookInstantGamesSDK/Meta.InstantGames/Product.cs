namespace Meta.InstantGames
{
    /// <summary>
    /// Represents a game's product information.
    /// </summary>
    public partial class Product : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of Product
        /// </summary>
        public Product() : base() { }

        private Product(string instanceUUID) : base(instanceUUID) { }

        internal static Product FromJs(string uuid)
        {
            return new Product(uuid);
        }

        /// <summary>
        /// The title of the product
        /// </summary>
        public string Title
        {
            get => GetMemberString("title");
        }

        /// <summary>
        /// The product's game-specified identifier
        /// </summary>
        public string ProductID
        {
            get => GetMemberString("productID");
        }

        /// <summary>
        /// The product description
        /// </summary>
        public string Description
        {
            get => GetMemberString("description");
        }

        /// <summary>
        /// A link to the product's associated image
        /// </summary>
        public string ImageURL
        {
            get => GetMemberString("imageURI");
        }

        /// <summary>
        /// The price of the product
        /// </summary>
        public string Price
        {
            get => GetMemberString("price");
        }

        /// <summary>
        /// The currency code for the product
        /// </summary>
        public string PriceCurrencyCode
        {
            get => GetMemberString("priceCurrencyCode");
        }

        /// <summary>
        /// The numeric price of a product
        /// </summary>
        public double PriceAmount
        {
            get => GetMemberNumber("priceAmount");
        }
    }
}
