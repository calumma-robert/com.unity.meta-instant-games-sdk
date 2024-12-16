mergeInto(LibraryManager.library, {
    JS_AdInstance_getPlacementID__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_AdInstance_getPlacementID: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getPlacementID"](...args);
        return JS_StringBuffer(result);
    },
    JS_AdInstance_loadAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_AdInstance_loadAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["loadAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_AdInstance_showAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_AdInstance_showAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["showAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    }
});
