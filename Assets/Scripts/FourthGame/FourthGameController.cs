using UnityEngine;
using System.Collections;

public class FourthGameController : MonoBehaviour {

	void Start () 
	{
		Vector3 gamePosition = new Vector3 (Camera.main.pixelWidth * 1 / 4, Camera.main.pixelHeight * 1 / 4, 0f);
		transform.localPosition = Camera.main.ScreenToWorldPoint (gamePosition);
	}

}
