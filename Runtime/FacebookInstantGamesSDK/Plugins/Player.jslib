mergeInto(LibraryManager.library, {
    JS_Player_getName__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_Player_getName: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getName"](...args);
        return result === null ? null : JS_StringBuffer(result);
    },
    JS_Player_getPhoto__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_Player_getPhoto: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getPhoto"](...args);
        return result === null ? null : JS_StringBuffer(result);
    },
    JS_Player_getConnectedPlayersAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Player_getConnectedPlayersAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["getConnectedPlayersAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Player_getDataAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Player_getDataAsync: function(uuidPtr, keysUuid, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [JS_getInstance(keysUuid)];
        instance["getDataAsync"](...args)
            .then(function(promiseResult) {
                const result = JSON.stringify(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(result));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Player_setDataAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Player_setDataAsync: function(uuidPtr, dataPtr, taskPtr, successCallback, apiErrorCallback)
    {
        let data;
        try {
            data = JSON.parse(UTF8ToString(dataPtr));
        } catch {
            const errorUuid = JS_saveReference(new APIError({
                code: 'INVALID_PARAM',
                message: "The parameter passed + \"" + UTF8ToString(dataPtr) + "\" to the API is invalid"
            }));
            {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            return;
        }
        const instance = JS_getInstance(uuidPtr);
        const args = [data];
        instance["setDataAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Player_getSignedPlayerInfoAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Player_getSignedPlayerInfoAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["getSignedPlayerInfoAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Player_subscribeBotAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Player_subscribeBotAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["subscribeBotAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Player_canSubscribeBotAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Player_canSubscribeBotAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["canSubscribeBotAsync"](...args)
            .then(function(promiseResult) {
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, Boolean(promiseResult));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Player_getASIDAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Player_getASIDAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["getASIDAsync"](...args)
            .then(function(promiseResult) {
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(promiseResult));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    }
});
