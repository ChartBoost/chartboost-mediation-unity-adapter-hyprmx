using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.HyprMX.Common;
using UnityEngine;

namespace Chartboost.Mediation.HyprMX.IOS
{
    internal sealed class HyprMXAdapter : IHyprMXAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            HyprMX.HyprMXAdapter.Instance = new HyprMXAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMHyprMXAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMHyprMXAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMHyprMXAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMHyprMXAdapterPartnerDisplayName();
        
        /// <inheritdoc/>
        public bool VerboseLogging
        {
            get => _CBMHyprMXAdapterGetVerboseLogging();
            set => _CBMHyprMXAdapterSetVerboseLogging(value);
        }

        /// <inheritdoc/>
        public void SetConsentStatusOverride(HyprMXConsentStatus consentStatus) 
            => _CBMHyprMXAdapterSetConsentStatusOverride((int)consentStatus);

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMHyprMXAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMHyprMXAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMHyprMXAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMHyprMXAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern bool _CBMHyprMXAdapterGetVerboseLogging();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMHyprMXAdapterSetVerboseLogging(bool verboseLogging);
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMHyprMXAdapterSetConsentStatusOverride(int consentStatus);
    }
}
