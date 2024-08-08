using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.HyprMX.Common;
using Chartboost.Mediation.HyprMX.Default;

namespace Chartboost.Mediation.HyprMX
{
    /// <inheritdoc cref="IHyprMXAdapter"/>
    public static class HyprMXAdapter 
    {
        internal static IHyprMXAdapter Instance = new HyprMXDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.0";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IHyprMXAdapter.VerboseLogging"/>
        public static bool VerboseLogging {
            get => Instance.VerboseLogging;
            set => Instance.VerboseLogging = value;
        }

        /// <inheritdoc cref="IHyprMXAdapter.SetConsentStatusOverride"/>
        public static void SetConsentStatusOverride(HyprMXConsentStatus consentStatus) 
            => Instance.SetConsentStatusOverride(consentStatus);
    }
}
