# Changelog
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

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
