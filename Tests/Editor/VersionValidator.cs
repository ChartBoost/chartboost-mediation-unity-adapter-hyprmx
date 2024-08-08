using Chartboost.Editor;
using Chartboost.Logging;
using Chartboost.Mediation.HyprMX;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.hyprmx";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.HyprMX";
        
        [SetUp]
        public void SetUp() 
            => LogController.LoggingLevel = LogLevel.Debug;
            
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, HyprMXAdapter.AdapterUnityVersion);
    }
}
