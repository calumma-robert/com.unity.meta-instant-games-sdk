mergeInto(LibraryManager.library, {
    JS_ConnectedPlayer_getID__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_ConnectedPlayer_getID: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getID"](...args);
        return JS_StringBuffer(result);
    },
    JS_ConnectedPlayer_getName__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_ConnectedPlayer_getName: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getName"](...args);
        return result === null ? null : JS_StringBuffer(result);
    },
    JS_ConnectedPlayer_getPhoto__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_ConnectedPlayer_getPhoto: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getPhoto"](...args);
        return result === null ? null : JS_StringBuffer(result);
    }
});
