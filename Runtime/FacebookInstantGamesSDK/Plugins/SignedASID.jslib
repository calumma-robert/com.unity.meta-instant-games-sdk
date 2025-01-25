mergeInto(LibraryManager.library, {
    JS_SignedASID_getASID__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_SignedASID_getASID: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getASID"](...args);
        return JS_StringBuffer(result);
    },
    JS_SignedASID_getSignature__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_SignedASID_getSignature: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getSignature"](...args);
        return JS_StringBuffer(result);
    }
});
