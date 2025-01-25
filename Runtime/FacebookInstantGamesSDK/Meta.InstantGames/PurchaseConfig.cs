namespace Meta.InstantGames
{
    /// <summary>
    /// The configuration of a purchase request for a product registered to the game.
    /// </summary>
    public partial class PurchaseConfig : JsNative.JsNative
    {
        /// <summary>
        /// Creates a new instance of PurchaseConfig
        /// </summary>
        /// <param name="productID">The identifier of the product to purchase</param>
        /// <param name="developerPayload">An optional developer-specified payload, to be included in the returned purchase's signed request.</param>
        public PurchaseConfig(string productID, string developerPayload = null)
        {
            ProductID = productID;
            DeveloperPayload = developerPayload;
        }

        /// <summary>
        /// The identifier of the product to purchase
        /// </summary>
        public string ProductID
        {
            get => GetMemberString("productID");
            private set => SetMemberString("productID", value);
        }

        /// <summary>
        /// An optional developer-specified payload, to be included in the returned purchase's signed request.
        /// </summary>
        public string DeveloperPayload
        {
            get => GetMemberString("developerPayload");
            private set => SetMemberString("developerPayload", value);
        }
    }
}
