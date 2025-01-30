mergeInto(LibraryManager.library, {
    JS_FBInstant_quit__deps: ['$JS_getInstance'],
    JS_FBInstant_quit: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["quit"](...args);
    },
    JS_FBInstant_initializeAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_initializeAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["initializeAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_startGameAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_startGameAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["startGameAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_createShortcutAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_createShortcutAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["createShortcutAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_performHapticFeedbackAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_performHapticFeedbackAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["performHapticFeedbackAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_getSupportedAPIs__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_getSupportedAPIs: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getSupportedAPIs"](...args);
        const resultUuid = JS_saveReference(result);
        return JS_StringBuffer(resultUuid);
    },
    JS_FBInstant_getTournamentAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_getTournamentAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["getTournamentAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_updateAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_updateAsync: function(uuidPtr, payloadUuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [JS_getInstance(payloadUuidPtr)];
        instance["updateAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_canCreateShortcutAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_canCreateShortcutAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["canCreateShortcutAsync"](...args)
            .then(function(promiseResult) {
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, Boolean(promiseResult));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_loadBannerAdAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_loadBannerAdAsync: function(uuidPtr, placementIDPtr, bannerPositionPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [UTF8ToString(placementIDPtr), UTF8ToString(bannerPositionPtr)];
        instance["loadBannerAdAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_hideBannerAdAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_hideBannerAdAsync: function(uuidPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        instance["hideBannerAdAsync"](...args)
            .then(function() {
                {{{ makeDynCall('vi', 'successCallback')}}}(taskPtr);
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_getInterstitialAdAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_getInterstitialAdAsync: function(uuidPtr, placementIDPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [UTF8ToString(placementIDPtr)];
        instance["getInterstitialAdAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_getRewardedVideoAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_getRewardedVideoAsync: function(uuidPtr, placementIDPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [UTF8ToString(placementIDPtr)];
        instance["getRewardedVideoAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_getRewardedInterstitialAsync__deps: ['$JS_getInstance', '$JS_StringBuffer', '$JS_saveReference'],
    JS_FBInstant_getRewardedInterstitialAsync: function(uuidPtr, placementIDPtr, taskPtr, successCallback, apiErrorCallback)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [UTF8ToString(placementIDPtr)];
        instance["getRewardedInterstitialAsync"](...args)
            .then(function(promiseResult) {
                const resultUuid = JS_saveReference(promiseResult);
                {{{ makeDynCall('vii', 'successCallback')}}}(taskPtr, JS_StringBuffer(resultUuid));
            })
            .catch(function(error) {
                const errorUuid = JS_saveReference(error);
                {{{ makeDynCall('vii', 'apiErrorCallback')}}}(taskPtr, JS_StringBuffer(errorUuid));
            });
    },
    JS_FBInstant_getLocale__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_FBInstant_getLocale: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getLocale"](...args);
        return result === null ? null : JS_StringBuffer(result);
    },
    JS_FBInstant_getPlatform__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_FBInstant_getPlatform: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getPlatform"](...args);
        return result === null ? null : JS_StringBuffer(result);
    }
});
