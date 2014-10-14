using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Prime31;


#if UNITY_IPHONE
public class VungleManager : AbstractManager
{
	// Fired when a video has finished playing. Includes the following keys: completedView (bool), playTime (double),
	// didDownload (bool) and willPresentProductSheet (bool).
	public static event Action<Dictionary<string,object>> vungleSDKwillCloseAdEvent;

	// Fired when the product sheet is dismissed
	public static event Action vungleSDKwillCloseProductSheetEvent;

	// Fired when the video is shown
	public static event Action vungleSDKwillShowAdEvent;

	// Fired when a Vungle ad is cached and ready to be displayed
	public static event Action vungleSDKhasCachedAdAvailableEvent;


	static VungleManager()
	{
		AbstractManager.initialize( typeof( VungleManager ) );
	}


	void vungleSDKwillCloseAd( string json )
	{
		if( vungleSDKwillCloseAdEvent != null )
			vungleSDKwillCloseAdEvent( json.dictionaryFromJson() );
	}


	void vungleSDKwillCloseProductSheet( string empty )
	{
		if( vungleSDKwillCloseProductSheetEvent != null )
			vungleSDKwillCloseProductSheetEvent();
	}


	void vungleSDKwillShowAd( string empty )
	{
		if( vungleSDKwillShowAdEvent != null )
			vungleSDKwillShowAdEvent();
	}


	void vungleSDKhasCachedAdAvailable()
	{
		if( vungleSDKhasCachedAdAvailableEvent != null )
			vungleSDKhasCachedAdAvailableEvent();
	}
}
#endif

