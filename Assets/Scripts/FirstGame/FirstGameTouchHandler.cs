using UnityEngine;
using System.Collections;

public class FirstGameTouchHandler : MonoBehaviour
{	
	float i, j = 0;

	Rect leftRect;
	Rect rightRect;

	void Start ()
	{
		leftRect = new Rect (0f,
		                     Camera.main.pixelHeight / 2f,
		                     Camera.main.pixelWidth / 4,
		                     Camera.main.pixelHeight / 2);
		rightRect = new Rect (Camera.main.pixelWidth / 4,
		                      Camera.main.pixelHeight / 2,
		                      Camera.main.pixelWidth / 4,
		                      Camera.main.pixelHeight / 2);
	}

	void Update ()
	{
		if (Input.GetMouseButton (0)) 
		{

			if(leftRect.Contains(Input.mousePosition))
			{
				LeftMotion();
			}
			if(rightRect.Contains (Input.mousePosition))
			{
				RightMotion ();
			}
		} 

		if (Input.GetMouseButtonUp (0)) 
		{
			j = 0;
			i = 0;
		}

	}

		//Check mouse/finger touch
		void LeftMotion ()
		{
			i += 0.01f;
			
			transform.Rotate (new Vector3 (0f, 0f, i));

		}

		void RightMotion ()
		{
			j += 0.01f;	
			transform.Rotate (new Vector3 (0f, 0f, -j));
			
		}

}
