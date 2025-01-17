mergeInto(LibraryManager.library, {
    JS_FBInstant__deps: ['$JS_saveReference'],
    JS_FBInstant: function()
    {
        const uuid = JS_saveReference(FBInstant);
        const bufferSize = lengthBytesUTF8(uuid) + 1;
        const buffer = _malloc(bufferSize);
        stringToUTF8(uuid, buffer, bufferSize);
        return buffer;
    }
});
