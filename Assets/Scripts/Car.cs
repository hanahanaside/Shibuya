using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour
{

	private Vector3 mStartPosition;

	// Use this for initialization
	void Start ()
	{
		mStartPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (-0.1f, 0, 0);
		if(transform.position.x < -10){
			transform.position = mStartPosition;
		}
	}
}
