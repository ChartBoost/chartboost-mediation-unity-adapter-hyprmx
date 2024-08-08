# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - HyprMX Adapter.

#Added
- Support for the following `HyprMX` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-hyprmx:5.6.4.+`
    * iOS: `ChartboostMediationAdapterHyprMX ~> 5.6.4.0`
    
- `HyprMXAdapter.cs` with Configuration Properties for `HyprMX`.
- The following properties have been added in `HyprMXAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `bool VerboseLogging`
- The following methods have been added in `HyprMXAdapter.cs`
    * `void SetConsentStatusOverride(HyprMXConsentStatus consentStatus)`