using System.Runtime.InteropServices;

namespace Meta.InstantGames
{
    /// <summary>
    /// Contains functions and properties related to payments and purchases of game products.
    /// </summary>
    public partial class Payments : JsNative.JsNative
    {
        /// <summary>
        /// Construct an instance of Payments
        /// </summary>
        public Payments() : base() { }

        private Payments(string instanceUUID) : base(instanceUUID) { }

        internal static Payments FromJs(string uuid)
        {
            return new Payments(uuid);
        }

        #if UNITY_WEBGL && !UNITY_EDITOR

        [DllImport("__Internal")]
        private static extern void JS_Payments_getCatalogAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Payments_purchaseAsync(
            string instanceUUID,
            string purchaseConfigUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Payments_getPurchasesAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Payments_consumePurchaseAsync(
            string instanceUUID,
            string purchaseToken,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback);

        [DllImport("__Internal")]
        private static extern void JS_Payments_onReady(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback callback);

        #else

        private static void JS_Payments_getCatalogAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_Payments_purchaseAsync(
            string instanceUUID,
            string purchaseConfigUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_Payments_getPurchasesAsync(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.ResultCallback<string> successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr, "fake value from stub implementation");

        private static void JS_Payments_consumePurchaseAsync(
            string instanceUUID,
            string purchaseToken,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback successCallback,
            Runtime.ResultCallback<string> apiErrorCallback)
            => successCallback(taskPtr);

        private static void JS_Payments_onReady(
            string instanceUUID,
            System.IntPtr taskPtr,
            Runtime.VoidResultCallback callback)
            => callback(taskPtr);

        #endif

        /// <summary>
        /// Fetches the game's product catalog. Exceptions: CLIENT_UNSUPPORTED_OPERATION, PAYMENTS_NOT_INITIALIZED, NETWORK_FAILURE
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> containing a list of <see cref="Meta.InstantGames.Product"/>.</returns>
        public async Runtime.WebTask<Product[]> GetCatalogAsync()
        {
            var resultUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Payments_getCatalogAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return JsNative.JsRefArray<Meta.InstantGames.Product>.FromJs(resultUuid).Values;
        }

        /// <summary>
        /// Begins the purchase flow for a specific product. Will immediately reject if called before FBInstant.startGameAsync() has resolved. Exceptions: CLIENT_UNSUPPORTED_OPERATION, PAYMENTS_NOT_INITIALIZED, INVALID_PARAM, NETWORK_FAILURE, INVALID_OPERATION, USER_INPUT
        /// </summary>
        /// <param name="purchaseConfig">The purchase's configuration details.</param>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> containing a <see cref="Meta.InstantGames.Purchase"/>.</returns>
        public async Runtime.WebTask<Purchase> PurchaseAsync(PurchaseConfig purchaseConfig)
        {
            var purchaseConfigUuid = purchaseConfig.Uuid;

            var resultUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Payments_purchaseAsync(Uuid, purchaseConfigUuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return Meta.InstantGames.Purchase.FromJs(resultUuid);
        }

        /// <summary>
        /// Fetches all of the player's unconsumed purchases. The game must fetch the current player's purchases as soon as the client indicates that it is ready to perform payments-related operations, i.e. at game start. The game can then process and consume any purchases that are waiting to be consumed. Exceptions: CLIENT_UNSUPPORTED_OPERATION, PAYMENTS_NOT_INITIALIZED, NETWORK_FAILURE
        /// </summary>
        /// <returns>A <see cref="Runtime.WebTask{T}"/> containing a list of <see cref="Meta.InstantGames.Purchase"/>.</returns>
        public async Runtime.WebTask<Purchase[]> GetPurchasesAsync()
        {
            var resultUuid = await new Runtime.WebTask<string>((System.IntPtr taskPtr) =>
                JS_Payments_getPurchasesAsync(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleStringFailure)
            );

            return JsNative.JsRefArray<Meta.InstantGames.Purchase>.FromJs(resultUuid).Values;
        }

        /// <summary>
        /// Consumes a specific purchase belonging to the current player. Before provisioning a product's effects to the player, the game should request the consumption of the purchased product. Once the purchase is successfully consumed, the game should immediately provide the player with the effects of their purchase. Exceptions: CLIENT_UNSUPPORTED_OPERATION, PAYMENTS_NOT_INITIALIZED, INVALID_PARAM, NETWORK_FAILURE
        /// </summary>
        /// <param name="purchaseToken">The purchase token of the purchase that should be consumed.</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when the operation is complete.</returns>
        public async Runtime.WebTask ConsumePurchaseAsync(string purchaseToken)
        {
            await new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_Payments_consumePurchaseAsync(Uuid, purchaseToken, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess, APIError.HandleVoidFailure)
            );
        }

        /// <summary>
        /// Sets a callback to be triggered when Payments operations are available.
        /// </summary>
        /// <param name="callback">The callback function to be executed when Payments are available.</param>
        /// <returns>A <see cref="Runtime.WebTask"/> that resolves when payments are available.</returns>
        public Runtime.WebTask OnReady()
        {
            return new Runtime.WebTask((System.IntPtr taskPtr) =>
                JS_Payments_onReady(Uuid, taskPtr, Runtime.WebTaskAsyncResult.HandleSuccess)
            );
        }
    }
}
