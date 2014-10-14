using UnityEngine;
using System.Collections;

public class SecondGameQuadController : MonoBehaviour 
{
	int count = 0;
	Vector3 newPos;
	Rect topGameRect;
	Rect botGameRect;

	void Start () 
	{
		topGameRect = new Rect (Camera.main.pixelWidth / 2, 
		                        Camera.main.pixelHeight * 3 / 4,
		                        Camera.main.pixelWidth / 4,
		                        Camera.main.pixelHeight / 4);
		botGameRect = new Rect (Camera.main.pixelWidth / 2, 
		                        Camera.main.pixelHeight / 2,
		                        Camera.main.pixelWidth / 4,
		                        Camera.main.pixelHeight / 4);
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetMouseButton (0)) 
		{			
			if(topGameRect.Contains(Input.mousePosition))
			{
				TopMove ();
			}
			if(botGameRect.Contains (Input.mousePosition))
			{
				BotMove ();
			}
		} 

//		if(Input.GetKeyDown("up") && count < 2)
//		{
//			count ++;
//			newPos = new Vector3 (transform.localPosition.x + 0.065f, transform.localPosition.y , transform.localPosition.z);
//			transform.localPosition = newPos;
//		}
//		if(Input.GetKeyDown("down") && count > -2)
//		{
//			count--;
//			newPos = new Vector3 (transform.localPosition.x - 0.065f, transform.localPosition.y, transform.localPosition.z);
//			transform.localPosition = newPos;
//		}

	}

	void TopMove ()
	{
		if (Input.GetKeyDown ("up") && count < 2) 
		{
			count ++;
			newPos = new Vector3 (transform.localPosition.x + 0.065f, transform.localPosition.y, transform.localPosition.z);
			transform.localPosition = newPos;
		}
	}

	void BotMove ()
	{
		if (Input.GetKeyDown ("up") && count > -2) 
		{
			count --;
			newPos = new Vector3 (transform.localPosition.x - 0.065f, transform.localPosition.y, transform.localPosition.z);
			transform.localPosition = newPos;
		}
	}
}
