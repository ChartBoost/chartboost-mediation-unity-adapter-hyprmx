using Chartboost.Logging;
using Chartboost.Mediation.HyprMX;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class HyprMXAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => HyprMXAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => HyprMXAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => HyprMXAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => HyprMXAdapter.PartnerDisplayName);

        [Test]
        public void VerboseLogging() 
            => TestUtilities.TestBooleanAccessor(() => HyprMXAdapter.VerboseLogging, value => HyprMXAdapter.VerboseLogging = value);

        [Test, Order(0)]
        public void SetConsentStatusGiven()
            => HyprMXAdapter.SetConsentStatusOverride(HyprMXConsentStatus.ConsentGiven);
        
        [Test, Order(1)]
        public void SetConsentStatusDeclined()
            => HyprMXAdapter.SetConsentStatusOverride(HyprMXConsentStatus.ConsentDeclined);
        
        [Test, Order(2)]
        public void SetConsentStatusUnknown()
            => HyprMXAdapter.SetConsentStatusOverride(HyprMXConsentStatus.ConsentStatusUnknown);
    }
}
