#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <HyprMX/HyprMX-Swift.h>
#import <ChartboostMediationAdapterHyprMX/ChartboostMediationAdapterHyprMX-Swift.h>

extern "C" {

    const char * _CBMHyprMXAdapterAdapterVersion(){
        return toCStringOrNull([HyprMXAdapterConfiguration adapterVersion]);
    }

    const char * _CBMHyprMXAdapterPartnerSDKVersion(){
        return toCStringOrNull([HyprMXAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMHyprMXAdapterPartnerId(){
        return toCStringOrNull([HyprMXAdapterConfiguration partnerID]);
    }

    const char * _CBMHyprMXAdapterPartnerDisplayName(){
        return toCStringOrNull([HyprMXAdapterConfiguration partnerDisplayName]);
    }

    BOOL _CBMHyprMXAdapterGetVerboseLogging(){
        return [HyprMXAdapterConfiguration logLevel] == HYPRLogLevelDebug;
    }

    void _CBMHyprMXAdapterSetVerboseLogging(BOOL verboseLogging){
        if (verboseLogging)
            [HyprMXAdapterConfiguration setLogLevel:HYPRLogLevelDebug];
        else
            [HyprMXAdapterConfiguration setLogLevel:HYPRLogLevelError];
    }

    void _CBMHyprMXAdapterSetConsentStatusOverride(int consentStatus){
        HyprConsentStatus nativeConsentStatus = (HyprConsentStatus)consentStatus;
        [HyprMXAdapterConfiguration setConsentStatusOverride:nativeConsentStatus];
    }
}
