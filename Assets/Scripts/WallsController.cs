using UnityEngine;
using System.Collections;

public class WallsController : MonoBehaviour {

	public Transform leftWall;
	public Transform rightWall;
	public Transform topWall;
	public Transform botWall;

	// Use this for initialization
	void Start () 
	{
		Vector3 leftPosition = new Vector3 (0, 0f, 0f);
		Vector3 rightPosition = new Vector3 (Camera.main.pixelWidth, 0f, 0f);
		Vector3 topPosition = new Vector3 (Camera.main.pixelWidth / 2, Camera.main.pixelHeight, 0f);
		Vector3 botPosition = new Vector3 (Camera.main.pixelWidth / 2, 0f, 0f);


		leftWall.localPosition = Camera.main.ScreenToWorldPoint (leftPosition);
		rightWall.localPosition = Camera.main.ScreenToWorldPoint (rightPosition);
		topWall.localPosition = Camera.main.ScreenToWorldPoint (topPosition);
		botWall.localPosition = Camera.main.ScreenToWorldPoint (botPosition);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
