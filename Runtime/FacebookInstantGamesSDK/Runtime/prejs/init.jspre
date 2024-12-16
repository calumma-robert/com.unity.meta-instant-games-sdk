const SDK_VERSION = '7.1';

function createScriptAsync(src) {
    return new Promise((resolve, reject) => {
        const script = document.createElement("script");
        script.src = src;
        script.onload = resolve;
        script.onerror = () => reject(new Error(`Failed to load package script: ${src}`));
        document.body.appendChild(script);
    });
};

async function initializeSdkAsync() {
    await createScriptAsync(`https://connect.facebook.net/en_US/fbinstant.${SDK_VERSION}.js`);
    await FBInstant.initializeAsync();
    await FBInstant.startGameAsync();
}

async function bootstrapSdkAsync() {
    try {
        // Do not start engine main() until we have downloaded & initialized the SDK
        Module.addRunDependency('initializeSdkAsync');
        await initializeSdkAsync();
        Module.removeRunDependency('initializeSdkAsync');
    } catch (e) {
        Module.startupErrorHandler(e.message);
        console.error(`Unable to initialize SDK - ${e.message}`);
    }
}

// Only run this code in the main thread
if (!Module.ENVIRONMENT_IS_PTHREAD) {
    Module.preRun.push(bootstrapSdkAsync);
}
