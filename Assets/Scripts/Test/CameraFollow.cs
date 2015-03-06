using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;
		transform.position = new Vector3 (player.transform.position.x-17 ,currentPosition.y,currentPosition.z);
	}
}
