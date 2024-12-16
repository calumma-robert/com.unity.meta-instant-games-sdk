mergeInto(LibraryManager.library, {
    JS_Tournaments_createAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Tournaments_createAsync: function(uuidPtr, payloadUuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [JS_getInstance(payloadUuidPtr)];
        instance["createAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Tournaments_postScoreAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Tournaments_postScoreAsync: function(uuidPtr, score, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [score];
        instance["postScoreAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Tournaments_shareAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Tournaments_shareAsync: function(uuidPtr, payloadUuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [JS_getInstance(payloadUuidPtr)];
        instance["shareAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Tournaments_joinAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Tournaments_joinAsync: function(uuidPtr, tournamentIDPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [UTF8ToString(tournamentIDPtr)];
        instance["joinAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_Tournaments_getTournamentsAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_Tournaments_getTournamentsAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["getTournamentsAsync"](...args)
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
