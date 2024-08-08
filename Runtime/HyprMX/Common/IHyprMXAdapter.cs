using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.HyprMX.Common
{
    /// <summary>
    /// The Chartboost Mediation HyprMX adapter.
    /// </summary>
    // ReSharper disable once InconsistentNaming
    internal interface IHyprMXAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// Enable HyprMX verbose logging.
        /// </summary>
        public bool VerboseLogging { get; set; }

        /// <summary>
        /// Use to manually set the consent status on the HyprMX SDK.
        /// This is generally unnecessary as the Mediation SDK will set the consent status automatically based on the latest consent info.
        /// </summary>
        public void SetConsentStatusOverride(HyprMXConsentStatus consentStatus);
    }
}
