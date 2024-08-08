using System.Runtime.CompilerServices;
using Chartboost.Mediation.HyprMX;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.HyprMXAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.HyprMXAssemblyInfoIOS)]

namespace Chartboost.Mediation.HyprMX
{
    internal class AssemblyInfo
    {
        public const string HyprMXAssemblyInfoAndroid = "Chartboost.Mediation.HyprMX.Android";
        public const string HyprMXAssemblyInfoIOS = "Chartboost.Mediation.HyprMX.IOS";
    }
}
