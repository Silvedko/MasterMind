using UnityEngine;
using System.Collections;

public class ThirdGameObjectController : MonoBehaviour {

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
			CheckTouch ();
	}
	
	//Check mouse/finger touch
	void CheckTouch()
	{
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		
		if(hit.collider != null)
		{
			Debug.Log("Clicked!");
		}
	}


}
