mergeInto(LibraryManager.library, {
    JS_ContextPlayer_getID__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_ContextPlayer_getID: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getID"](...args);
        return JS_StringBuffer(result);
    },
    JS_ContextPlayer_getName__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_ContextPlayer_getName: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getName"](...args);
        return result === null ? null : JS_StringBuffer(result);
    },
    JS_ContextPlayer_getPhoto__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_ContextPlayer_getPhoto: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getPhoto"](...args);
        return result === null ? null : JS_StringBuffer(result);
    }
});
