using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class VungleEventListener : MonoBehaviour
{
#if UNITY_IPHONE
	void OnEnable()
	{
		// Listen to all events for illustration purposes
		VungleManager.vungleSDKwillCloseAdEvent += vungleSDKwillCloseAdEvent;
		VungleManager.vungleSDKwillShowAdEvent += vungleSDKwillShowAdEvent;
		VungleManager.vungleSDKwillCloseProductSheetEvent += vungleSDKwillCloseProductSheetEvent;
		VungleManager.vungleSDKhasCachedAdAvailableEvent += vungleSDKhasCachedAdAvailableEvent;
	}


	void OnDisable()
	{
		// Remove all event handlers
		VungleManager.vungleSDKwillCloseAdEvent -= vungleSDKwillCloseAdEvent;
		VungleManager.vungleSDKwillShowAdEvent -= vungleSDKwillShowAdEvent;
		VungleManager.vungleSDKwillCloseProductSheetEvent -= vungleSDKwillCloseProductSheetEvent;
		VungleManager.vungleSDKhasCachedAdAvailableEvent -= vungleSDKhasCachedAdAvailableEvent;
	}



	void vungleSDKwillCloseAdEvent( Dictionary<string,object> data )
	{
		Debug.Log( "vungleSDKwillCloseAdEvent" );
		Prime31.Utils.logObject( data );
	}


	void vungleSDKwillShowAdEvent()
	{
		Debug.Log( "vungleSDKwillShowAdEvent" );
	}


	void vungleSDKwillCloseProductSheetEvent()
	{
		Debug.Log( "vungleSDKwillCloseProductSheetEvent" );
	}


	void vungleSDKhasCachedAdAvailableEvent()
	{
		Debug.Log( "vungleSDKhasCachedAdAvailableEvent" );
	}

#endif
}


