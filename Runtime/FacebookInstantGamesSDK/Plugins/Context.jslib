mergeInto(LibraryManager.library, {
    JS_Context_switchAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Context_switchAsync: function(uuidPtr, idPtr, switchSilentlyIfSolo, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [UTF8ToString(idPtr), Boolean(switchSilentlyIfSolo)];
        instance["switchAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Context_chooseAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Context_chooseAsync: function(uuidPtr, optionsUuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [JS_getInstance(optionsUuidPtr)];
        instance["chooseAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Context_createAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Context_createAsync: function(uuidPtr, suggestedPlayerIdsUuid, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [JS_getInstance(suggestedPlayerIdsUuid)];
        instance["createAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Context_getPlayersAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Context_getPlayersAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["getPlayersAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    }
});
