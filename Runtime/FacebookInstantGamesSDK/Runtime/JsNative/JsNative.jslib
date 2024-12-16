mergeInto(LibraryManager.library, {
    $unityBoundReferences: {},
    $JS_saveReference__deps: ['$unityBoundReferences'],
    $JS_saveReference: function(instance) {
        const uuid = crypto.randomUUID();
        unityBoundReferences[uuid] = {
            instance,
            members: {},
        };
        return uuid;
    },
    $JS_getInstance__deps: ['$unityBoundReferences'],
    $JS_getInstance: function(uuidPtr) {
        const uuid = UTF8ToString(uuidPtr);
        const entry = unityBoundReferences[uuid];
        return entry && entry.instance;
    },
    $JS_saveMemberReference__deps: ['$unityBoundReferences'],
    $JS_saveMemberReference: function(parentUuid, memberName, memberUuid) {
        const parentEntry = unityBoundReferences[parentUuid];
        unityBoundReferences[parentUuid].members = Object.assign(parentEntry.members, {
            [memberName]: memberUuid,
        });
    },
    $JS_StringBuffer: function(str) {
        const bufferSize = lengthBytesUTF8(str) + 1;
        const buffer = _malloc(bufferSize);
        stringToUTF8(str, buffer, bufferSize);
        return buffer;
    },
    JS_jsNative_removeReference__deps: ['$unityBoundReferences'],
    JS_jsNative_removeReference: function(uuidPtr) {
        const uuid = UTF8ToString(uuidPtr);
        delete unityBoundReferences[uuid];
    },
    JS_jsNative_createObject__deps: ['$JS_saveReference', '$JS_StringBuffer'],
    JS_jsNative_createObject: function() {
        const uuid = JS_saveReference(Object.create(null));
        return JS_StringBuffer(uuid);
    },
    JS_jsNative_createArray__deps: ['$JS_saveReference', '$JS_StringBuffer'],
    JS_jsNative_createArray: function() {
        const uuid = JS_saveReference([]);
        return JS_StringBuffer(uuid);
    },
    JS_jsNative_getMemberString__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_jsNative_getMemberString: function(uuidPtr, memberNamePtr) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberValue = instance[memberName];
        if (typeof(memberValue) !== 'string') {
            return null;
        }
        return JS_StringBuffer(memberValue);
    },
    JS_jsNative_setMemberString__deps: ['$JS_getInstance'],
    JS_jsNative_setMemberString: function(uuidPtr, memberNamePtr, valuePtr) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberType = typeof(instance[memberName]);
        if (memberType !== "string" && memberType !== "undefined") {
            return;
        }
        const value = valuePtr === 0 ? undefined : UTF8ToString(valuePtr);
        instance[memberName] = value;
    },
    JS_jsNative_getMemberJsonSerializable__deps: ['$JS_getInstance', '$JS_StringBuffer'],
    JS_jsNative_getMemberJsonSerializable: function(uuidPtr, memberNamePtr) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberValue = instance[memberName];
        if (typeof(memberValue) !== 'object' || memberValue === null) {
            return null;
        }
        return JS_StringBuffer(JSON.stringify(memberValue));
    },
    JS_jsNative_setMemberJsonSerializable: function(uuidPtr, memberNamePtr, valuePtr) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberType = typeof(instance[memberName]);
        if (memberType !== "object" && memberType !== "undefined") {
            return;
        }
        const value = valuePtr === 0 ? undefined : JSON.parse(UTF8ToString(valuePtr));
        instance[memberName] = value;
    },
    JS_jsNative_getMemberNumber__deps: ['$JS_getInstance'],
    JS_jsNative_getMemberNumber: function(uuidPtr, memberNamePtr) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberValue = instance[memberName];
        if (typeof(memberValue) !== 'number') {
            return NaN;
        }
        return memberValue;
    },
    JS_jsNative_setMemberNumber__deps: ['$JS_getInstance'],
    JS_jsNative_setMemberNumber: function(uuidPtr, memberNamePtr, value) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberType = typeof(instance[memberName]);
        if (memberType !== "number" && memberType !== "undefined") {
            return;
        }
        instance[memberName] = value;
    },
    JS_jsNative_getMemberNullableNumber__deps: ['$JS_getInstance'],
    JS_jsNative_getMemberNullableNumber: function(uuidPtr, memberNamePtr) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberValue = instance[memberName];
        return typeof(memberValue) !== 'number' ? NaN : memberValue;
    },
    JS_jsNative_setMemberNullableNumber__deps: ['$JS_getInstance'],
    JS_jsNative_setMemberNullableNumber: function(uuidPtr, memberNamePtr, value) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberType = typeof(instance[memberName]);
        if (memberType !== "number" && memberType !== "undefined") {
            return;
        }
        // null can't be passed directly from C# to JS, so we use NaN as a sentinel value
        instance[memberName] = isNaN(value) ? null : value;
    },
    JS_jsNative_getMemberBoolean__deps: ['$JS_getInstance'],
    JS_jsNative_getMemberBoolean: function(uuidPtr, memberNamePtr) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberValue = instance[memberName];
        if (typeof(memberValue) !== 'boolean') {
            return false;
        }
        return memberValue;
    },
    JS_jsNative_setMemberBoolean__deps: ['$JS_getInstance'],
    JS_jsNative_setMemberBoolean: function(uuidPtr, memberNamePtr, value) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberType = typeof(instance[memberName]);
        if (memberType !== "boolean" && memberType !== "undefined") {
            return;
        }
        instance[memberName] = Boolean(value);
    },
    JS_jsNative_getMemberReference__deps: ['$unityBoundReferences', '$JS_getInstance', '$JS_saveMemberReference'],
    JS_jsNative_getMemberReference: function(uuidPtr, memberNamePtr) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberInstance = instance[memberName];

        if (typeof(memberInstance) !== 'object') {
            return 0;
        }

        const uuid = UTF8ToString(uuidPtr);
        const parentEntry = unityBoundReferences[uuid];
        const memberUuid = parentEntry.members[memberName] || JS_saveReference(memberInstance);
        if (parentEntry.members[memberName] === undefined) {
            JS_saveMemberReference(uuid, memberName, memberUuid)
        }
        return JS_StringBuffer(memberUuid);
    },
    JS_jsNative_setMemberReference__deps: ['$unityBoundReferences', '$JS_getInstance', '$JS_saveMemberReference'],
    JS_jsNative_setMemberReference: function(uuidPtr, memberNamePtr, memberUuidPtr) {
        const instance = JS_getInstance(uuidPtr);
        const memberName = UTF8ToString(memberNamePtr);
        const memberType = typeof(instance[memberName]);
        if (memberType !== "object" && memberType !== "undefined") {
            return;
        }

        const memberInstance = JS_getInstance(memberUuidPtr);
        if (typeof(memberInstance) !== 'object') {
            return;
        }
        instance[memberName] = memberInstance;

        const uuid = UTF8ToString(uuidPtr);
        const memberUuid = UTF8ToString(memberUuidPtr);
        JS_saveMemberReference(uuid, memberName, memberUuid)
    },
});
