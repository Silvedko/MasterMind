using UnityEngine;
using System.Collections;

public class FirstGameCircleController : MonoBehaviour 
{
		
	void Update ()
	{
		if (Mathf.Abs (transform.localPosition.x) > 3.5f || transform.localPosition.y < -4.2f )
						Debug.Break ();
	}

}
