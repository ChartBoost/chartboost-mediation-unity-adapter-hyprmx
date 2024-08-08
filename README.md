# Chartboost Mediation Unity SDK - HyprMX Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.hyprmx/Editor/HyprMXAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.hyprmx)

In order to add the Chartboost Mediation Unity SDK - HyprMX Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.hyprmx": "5.0.0",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.HyprMX)

To add the Chartboost Mediation Unity SDK - HyprMX Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.HyprMX` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.HyprMX` package. Choose the appropriate version and install.

# Application Transport Security
HprMX recommends that [ATS](https://developer.apple.com/library/archive/documentation/General/Reference/InfoPlistKeyReference/Articles/CocoaKeys.html#//apple_ref/doc/uid/TP40009251-SW60) (App Transport Security) settings are turned off as Apple has put on hold their efforts to enforce the policy. In order to do so, add the App Transport Security dictionary key below to your `Info.plist`.

```xml
<key>NSAppTransportSecurity</key>
<dict>
    <key>NSAllowsArbitraryLoads</key>
    <true/>
</dict>   
```

If you prefer to enable ATS, you must add the three App Transport Security dictionary keys below to your Info.plist to ensure that HyprMX operates properly.

```xml
<key>NSAppTransportSecurity</key>
<dict>
    <key>NSAllowsArbitraryLoads</key>
    <true/>
    <key>NSAllowsArbitraryLoadsForMedia</key>
    <true/>
    <key>NSAllowsArbitraryLoadsInWebContent</key>
    <true/>
</dict> 
```

# Usage
The following code block exemplifies usage of the `HyprMXAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {HyprMXAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.6.4.1.0
Debug.Log($"Adapter Native Version: {HyprMXAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 6.4.1
Debug.Log($"Partner SDK Version: {HyprMXAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: hyprmx
Debug.Log($"Partner Identifier: {HyprMXAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: HyprMX
Debug.Log($"Partner Display Name: {HyprMXAdapter.PartnerDisplayName}");
```

## Verbose Logging
To enable verbose logging for the HyprMX adapter, the following property has been made available:

```csharp
HyprMXAdapter.VerboseLogging = true;
```

## Set Consent Status Override
Use to manually set the consent status on the HyprMX SDK. This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.


```csharp
// Given
HyprMXAdapter.SetConsentStatusOverride(HyprMXConsentStatus.ConsentGiven);

// Declined
HyprMXAdapter.SetConsentStatusOverride(HyprMXConsentStatus.ConsentDeclined);

// Unknown
HyprMXAdapter.SetConsentStatusOverride(HyprMXConsentStatus.ConsentDeclined);
```