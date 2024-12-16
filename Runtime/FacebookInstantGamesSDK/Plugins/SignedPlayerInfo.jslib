mergeInto(LibraryManager.library, {
    JS_SignedPlayerInfo_getPlayerID__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_SignedPlayerInfo_getPlayerID: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getPlayerID"](...args);
        return JS_StringBuffer(result);
    },
    JS_SignedPlayerInfo_getSignature__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_SignedPlayerInfo_getSignature: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getSignature"](...args);
        return JS_StringBuffer(result);
    }
});
