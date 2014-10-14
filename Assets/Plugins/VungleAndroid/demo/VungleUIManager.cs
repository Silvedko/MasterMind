using UnityEngine;
using System.Collections.Generic;
using Prime31;


public class VungleUIManager : MonoBehaviourGUI
{
#if UNITY_ANDROID
	void OnGUI()
	{
		beginColumn();


		if( GUILayout.Button( "Init" ) )
		{
			// replace with your app ID!!!
			VungleAndroid.init( "com.prime31.Vungle" );
		}


		if( GUILayout.Button( "Is Sound Enabled?" ) )
		{
			Debug.Log( "is sound enabled? " + VungleAndroid.isSoundEnabled() );
		}
		

		if( GUILayout.Button( "Set Sound Enabled" ) )
		{
			VungleAndroid.setSoundEnabled( true );
		}
		

		if( GUILayout.Button( "Is Video Available?" ) )
		{
			Debug.Log( "is video available? " + VungleAndroid.isVideoAvailable() );
		}
		
		
		if( GUILayout.Button( "Set Ad Orientation to AutoRotate" ) )
		{
			VungleAndroid.setAdOrientation( VungleAdOrientation.AutoRotate );
		}



		endColumn( true );

		if( GUILayout.Button( "Play Ad" ) )
		{
			VungleAndroid.playModalAd();
		}
		
		
		if( GUILayout.Button( "Play Insentivised Ad" ) )
		{
			VungleAndroid.playIncentivizedAd( "some-user" );
		}

		endColumn();
	}
#endif
}
