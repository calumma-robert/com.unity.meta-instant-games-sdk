mergeInto(LibraryManager.library, {
    JS_Tournament_getID__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_Tournament_getID: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getID"](...args);
        return JS_StringBuffer(result);
    },
    JS_Tournament_getContextID__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_Tournament_getContextID: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getContextID"](...args);
        return JS_StringBuffer(result);
    },
    JS_Tournament_getEndTime__deps: ['$JS_getInstance'],
    JS_Tournament_getEndTime: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getEndTime"](...args);
        return result;
    },
    JS_Tournament_getTitle__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_Tournament_getTitle: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getTitle"](...args);
        return result === null ? null : JS_StringBuffer(result);
    },
    JS_Tournament_getPayload__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_Tournament_getPayload: function(uuidPtr)
    {
        const instance = JS_getInstance(uuidPtr);
        const args = [];
        const result = instance["getPayload"](...args);
        return result === null ? null : JS_StringBuffer(JSON.stringify(result));
    }
});
