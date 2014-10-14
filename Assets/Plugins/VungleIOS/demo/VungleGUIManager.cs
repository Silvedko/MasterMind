using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Prime31;


public class VungleGUIManager : MonoBehaviourGUI
{
#if UNITY_IPHONE
	void OnGUI()
	{
		beginColumn();


		if( GUILayout.Button( "Start" ) )
		{
			// replace with your app ID!!!
			VungleBinding.startWithAppId( "vungleTest" );
		}


		if( GUILayout.Button( "Is Ad Available" ) )
		{
			Debug.Log( "is ad available: " + VungleBinding.isAdAvailable() );
		}


		if( GUILayout.Button( "Play Ad" ) )
		{
			VungleBinding.playAd( true );
		}


		endColumn( true );


		if( GUILayout.Button( "Enable Logging" ) )
		{
			VungleBinding.enableLogging( true );
		}
		
		
		if( GUILayout.Button( "Disable Sound" ) )
		{
			VungleBinding.setSoundEnabled( false );
		}


		if( GUILayout.Button( "Play Insentivised Ad" ) )
		{
			VungleBinding.playIncentivizedAd( "some-user", true );
		}

		endColumn();
	}
#endif
}
