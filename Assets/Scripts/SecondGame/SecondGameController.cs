using UnityEngine;
using System.Collections;

public class SecondGameController : MonoBehaviour {

	void Start () 
	{
		Vector3 gamePosition = new Vector3 (Camera.main.pixelWidth * 3 / 4, Camera.main.pixelHeight * 3 / 4, 0f);
		transform.localPosition = Camera.main.ScreenToWorldPoint (gamePosition);
	}
}
