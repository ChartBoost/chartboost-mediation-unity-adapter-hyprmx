using Chartboost.Logging;
using Chartboost.Mediation.HyprMX.Common;

namespace Chartboost.Mediation.HyprMX.Default
{
    internal class HyprMXDefault : IHyprMXAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => HyprMXAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => HyprMXAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "hyprmx";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "HyprMX";

        /// <inheritdoc/>
        public bool VerboseLogging { get; set; }

        /// <inheritdoc/>
        public void SetConsentStatusOverride(HyprMXConsentStatus consentStatus) 
            => LogController.Log($"SetConsentStatusOverride does nothing on {nameof(HyprMXDefault)}", LogLevel.Info);
    }
}
