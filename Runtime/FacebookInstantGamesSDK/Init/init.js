/*
 * This file will only be included when targeting the Facebook Instant Games platform. It is copied from the package at build time and
 * as such any changes made to this file in the project assets will be overwritten.
*/

const SDK_VERSION = '7.1';

function createScriptAsync(src) {
    return new Promise((resolve, reject) => {
        const script = document.createElement("script");
        script.src = src;
        script.onload = () => resolve();
        script.onerror = () => reject(new Error(`Failed to load package script: ${src}`));
        document.body.appendChild(script);
    });
};

function runAsyncWithTimeout(timedPromise, waitTimeMs, errorMessage) {
    return Promise.race([
        timedPromise,
        new Promise((_, reject) => setTimeout(() => reject(new Error(errorMessage)), waitTimeMs))
    ]);
}

async function initializeSdkAsync(createScript = createScriptAsync, runWithTimeout = runAsyncWithTimeout) {
    await createScript(`https://connect.facebook.net/en_US/fbinstant.${SDK_VERSION}.js`);
    await runWithTimeout(FBInstant.initializeAsync(), 3000, 'FBInstant.initializeAsync timed out');
    await runWithTimeout(FBInstant.startGameAsync(), 3000, 'FBInstant.startGameAsync timed out');
}

async function bootstrapSdkAsync(initializeSdkAsync) {
    try {
        // Do not start engine main() until we have downloaded & initialized the SDK
        Module.addRunDependency('initializeSdkAsync');
        await initializeSdkAsync();
    } catch (e) {
        console.error(`Unable to initialize SDK - ${e.message}`);
    } finally {
        Module.removeRunDependency('initializeSdkAsync');
    }
}

// Only run this code in the main thread
if (!Module.ENVIRONMENT_IS_PTHREAD) {
    Module.preRun.push(() => bootstrapSdkAsync(initializeSdkAsync));
}

// Export CommonJS module for testing if running in NodeJS
if (typeof(module) !== 'undefined') {
    module.exports = {
        bootstrapSdkAsync,
        createScriptAsync,
        initializeSdkAsync,
        runAsyncWithTimeout,
    };
}
