namespace Meta.InstantGames
{
    /// <summary>
    /// Represents an individual purchase of a game product.
    /// </summary>
    public partial class Purchase : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of Purchase
        /// </summary>
        public Purchase() : base() { }

        private Purchase(string instanceUUID) : base(instanceUUID) { }

        internal static Purchase FromJs(string uuid)
        {
            return new Purchase(uuid);
        }

        /// <summary>
        /// A developer-specified string, provided during the purchase of the product
        /// </summary>
        public string DeveloperPayload
        {
            get => GetMemberString("developerPayload");
        }

        /// <summary>
        /// Whether or not the purchase has been consumed
        /// </summary>
        public bool IsConsumed
        {
            get => GetMemberBoolean("isConsumed");
        }

        /// <summary>
        /// The current status of the purchase, such as 'charge' or 'refund'
        /// </summary>
        public string PaymentActionType
        {
            get => GetMemberString("paymentActionType");
        }

        /// <summary>
        /// The identifier for the purchase transaction
        /// </summary>
        public string PaymentID
        {
            get => GetMemberString("paymentID");
        }

        /// <summary>
        /// The product's game-specified identifier
        /// </summary>
        public string ProductID
        {
            get => GetMemberString("productID");
        }

        /// <summary>
        /// The platform associated with the purchase, such as "FB" for Facebook and "GOOGLE" for Google.
        /// </summary>
        public PurchasePlatform PurchasePlatform
        {
            get
            {
               var purchasePlatform = GetMemberString("purchasePlatform");
                return (PurchasePlatform) System.Enum.Parse(typeof(PurchasePlatform), purchasePlatform);
            }
        }

        /// <summary>
        /// Contains the local amount and currency associated with the purchased item
        /// </summary>
        public string PurchasePrice
        {
            get => GetMemberJsonSerializable("purchasePrice");
        }

        /// <summary>
        /// Unix timestamp of when the purchase occurred
        /// </summary>
        public string PurchaseTime
        {
            get => GetMemberString("purchaseTime");
        }

        /// <summary>
        /// A token representing the purchase that may be used to consume the purchase
        /// </summary>
        public string PurchaseToken
        {
            get => GetMemberString("purchaseToken");
        }

        /// <summary>
        /// Server-signed encoding of the purchase request
        /// </summary>
        public string SignedRequest
        {
            get => GetMemberString("signedRequest");
        }
    }
}
