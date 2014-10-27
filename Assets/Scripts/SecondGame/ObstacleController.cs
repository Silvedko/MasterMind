using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstacleController : MonoBehaviour 
{
	public GameObject obstaclePrefab;

	private bool isRightPosition = false;
	List<GameObject> poolObject;

	public void StartMove ()
	{

	}

	Vector3 SetObstaclePosition ()
	{
		Vector3 pos;
		if(isRightPosition)
			pos = new Vector3 (SecondGameConstants.MaxObstaclePosition, 0f, 0f);
		else 
			pos = new Vector3 (-SecondGameConstants.MaxObstaclePosition, 0f, 0f);
		isRightPosition = !isRightPosition;

		return pos;
	}

	void Start () 
	{
		poolObject = new List<GameObject> (2);

		GameObject obstacle1 = (GameObject) Instantiate (obstaclePrefab, SetObstaclePosition(), Quaternion.identity);
//		poolObject.Add
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
