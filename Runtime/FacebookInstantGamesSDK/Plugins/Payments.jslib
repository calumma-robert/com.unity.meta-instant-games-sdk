mergeInto(LibraryManager.library, {
    JS_Payments_getCatalogAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Payments_getCatalogAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["getCatalogAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Payments_purchaseAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Payments_purchaseAsync: function(uuidPtr, purchaseConfigUuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [JS_getInstance(purchaseConfigUuidPtr)];
        instance["purchaseAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Payments_getPurchasesAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Payments_getPurchasesAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["getPurchasesAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Payments_consumePurchaseAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Payments_consumePurchaseAsync: function(uuidPtr, purchaseTokenPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [UTF8ToString(purchaseTokenPtr)];
        instance["consumePurchaseAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Payments_onReady__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Payments_onReady: function(uuidPtr, taskPtr, callback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [(function() {
            {{{ makeDynCall('vi', 'callback')}}}(taskPtr);
        })];
        instance["onReady"](...args);
    }
});
