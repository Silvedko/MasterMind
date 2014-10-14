using UnityEngine;
using System.Collections;

public class FourthGameObjectController : MonoBehaviour 
{
	Rect rect;

	void Start () 
	{
		rect = new Rect (0f, 0f, Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
	}
	
	void Update () 
	{
		if (Input.GetMouseButton (0)) 
		{			
			if (rect.Contains (Input.mousePosition)) 
			{
				gameObject.rigidbody2D.AddForce (Vector3.up * 100f);
			}
		}
	}
}
