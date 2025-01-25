# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [1.0.0-pre.3] - 2025-01-25

### Added

* General APIs:
  * Player.GetSignedASIDAsync

## [1.0.0-pre.2] - 2025-01-25

### Added

* General APIs:
  * FBInstant.GetLocale
  * Player.GetASIDAsync
* Payments APIs:
  * FBInstant.Payments
  * Payments.GetCatalogAsync
  * Payments.PurchaseAsync
  * Payments.GetPurchasesAsync
  * Payments.ConsumePurchaseAsync
  * Payments.OnReady

## [1.0.0-pre.1] - 2025-01-06

### Removed
* Moved test code to separate package `com.unity.meta-instant-games-sdk.tests`.

### Changed
* Made `Meta.InstantGames.APIError` throwable and removed property `JsException` and its corresponding class

## [0.0.1-exp.3] - 2024-12-17

### Added

* Function `WaitForCompletion` in WebTask and WebTask<T> so that they are compatible with coroutines
* Build preprocessor that selectively includes auto-bootstrapping of the SDK when building for `UNITY_FACEBOOK_INSTANT_GAMES`
* Requirements section to document the system requirements to use this package
* Timeout of 3000ms for calls `InitializeAsync` and `StartGameAsync` in auto-bootstrapping

### Changed

* C# API member names (methods, properties) are PascalCase instead of CamelCase

### Fixed

* Build hanging in a general Web build when package is added to a project [UUM-90542](https://jira.unity3d.com/browse/UUM-90542)

## [0.0.1-exp.2] - 2024-12-02

### Added

* Monetization APIs:
  * FBInstant.getInterstitialAdAsync
  * FBInstant.loadBannerAdAsync
  * FBInstant.hideBannerAdAsync
  * FBInstant.getRewardedVideoAsync
  * FBInstant.getRewardedInterstitialAsync
  * AdInstance.getPlacementID
  * AdInstance.loadAsync
  * AdInstance.showAsync
* `init.jspre` file that will download and initialize the JavaScript SDK

### Changed

* Namespace for the C# bindings has changed from `Internal.Bindings` to `Meta.InstantGames`.
* Top level class for the C# bindings has changed from `FacebookInstantGamesSDK` to `Sdk`

## [0.0.1-exp.1] - 2024-10-16

### This is the first (experimental) release of *Unity Package com.unity.meta-instant-games-sdk*.

### Added

* Added initial package contents.
