using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Prime31;



#if UNITY_IPHONE
public enum VungleAdOrientation
{
	Portrait,
    LandscapeLeft,
    LandscapeRight,
    PortraitUpsideDown,
    Landscape,
    All,
    AllButUpsideDown
}

public class VungleBinding
{
	[DllImport("__Internal")]
	private static extern void _vungleStartWithAppId( string appId );

	// Starts up the SDK with the given appId
	public static void startWithAppId( string appId )
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
			_vungleStartWithAppId( appId );
	}


	[DllImport("__Internal")]
	private static extern void _vungleSetSoundEnabled( bool enabled );

	// Enables/disables sound
	public static void setSoundEnabled( bool enabled )
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
			_vungleSetSoundEnabled( enabled );
	}


	[DllImport("__Internal")]
	private static extern void _vungleEnableLogging( bool shouldEnable );

	// Enables/disables verbose logging
	public static void enableLogging( bool shouldEnable )
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
			_vungleEnableLogging( shouldEnable );
	}


	[DllImport("__Internal")]
	private static extern bool _vungleIsAdAvailable();

	// Checks to see if a video ad is available
	public static bool isAdAvailable()
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
			return _vungleIsAdAvailable();
		return false;
	}
	
	
	[DllImport("__Internal")]
	private static extern void _vunglePlayAdWithOptions( bool showCloseButton, bool incentivized, int orientation, string user );

	// Plays an ad with the given options. The user option is only supported for incentivized ads.
	public static void playAd( bool showCloseButton, bool incentivized = false, VungleAdOrientation orientation = VungleAdOrientation.All, string user = null )
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
			_vunglePlayAdWithOptions( showCloseButton, incentivized, (int)orientation, user );
	}


	// Plays a non-incentivized ad optionally showing the close button
	public static void playModalAd( bool showCloseButton )
	{
		playAd( showCloseButton, false, VungleAdOrientation.All, null );
	}


	// Plays an incentivized ad for the user passed in via the user string parameter
	public static void playIncentivizedAd( string user, bool showCloseButton )
	{
		playAd( showCloseButton, true, VungleAdOrientation.All, user );
	}

}
#endif
