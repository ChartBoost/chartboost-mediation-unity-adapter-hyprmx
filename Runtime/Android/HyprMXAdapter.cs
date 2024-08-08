using Chartboost.Constants;
using Chartboost.Mediation.HyprMX.Common;
using UnityEngine;
// ReSharper disable InconsistentNaming

namespace Chartboost.Mediation.HyprMX.Android
{
    internal partial class HyprMXAdapter : IHyprMXAdapter
    {
        private const string HyprMXAdapterConfiguration = "com.chartboost.mediation.hyprmxadapter.HyprMXAdapterConfiguration";
        private const string FunctionGetIsDebugLoggingEnabled = "isDebugLoggingEnabled";
        private const string FunctionSetDebugLoggingEnabled = "setDebugLoggingEnabled";
        private const string FunctionSetConsentStatusOverride = "setConsentStatusOverride";

        private const string EnumHyprMXConsentStatus = "com.hyprmx.android.sdk.consent.ConsentStatus";
        private const string EnumHyprMXConsentUnknown = "CONSENT_STATUS_UNKNOWN";
        private const string EnumHyprMXConsentGiven = "CONSENT_GIVEN";
        private const string EnumHyprMXConsentDeclined = "CONSENT_DECLINED";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            HyprMX.HyprMXAdapter.Instance = new HyprMXAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(HyprMXAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(HyprMXAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(HyprMXAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(HyprMXAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }

        /// <inheritdoc/>
        public bool VerboseLogging
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(HyprMXAdapterConfiguration);
                return adapterConfiguration.Call<bool>(FunctionGetIsDebugLoggingEnabled);
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(HyprMXAdapterConfiguration);
                adapterConfiguration.Call(FunctionSetDebugLoggingEnabled, value);
            }
        }
        
        /// <inheritdoc/>
        public void SetConsentStatusOverride(HyprMXConsentStatus consentStatus)
        {
            using var enumClass = new AndroidJavaClass(EnumHyprMXConsentStatus);
            using var consentValue = consentStatus switch
            {
                HyprMXConsentStatus.ConsentStatusUnknown => enumClass.GetStatic<AndroidJavaObject>(EnumHyprMXConsentUnknown),
                HyprMXConsentStatus.ConsentGiven => enumClass.GetStatic<AndroidJavaObject>(EnumHyprMXConsentGiven),
                HyprMXConsentStatus.ConsentDeclined => enumClass.GetStatic<AndroidJavaObject>(EnumHyprMXConsentDeclined),
                _ => enumClass.GetStatic<AndroidJavaObject>(EnumHyprMXConsentUnknown)
            };
            
            using var currentActivity = SharedAndroidConstants.UnityPlayerCurrentActivity();
            using var adapterConfiguration = new AndroidJavaObject(HyprMXAdapterConfiguration);
            adapterConfiguration.Call(FunctionSetConsentStatusOverride, currentActivity, consentValue);
        }
    }
}
