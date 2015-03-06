using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float gravityForce;
	public float moveForce;
	public float jumpForce;
	private iTweenEvent mScaleEvent;
	private bool isJumping;

	void Start(){
		mScaleEvent = iTweenEvent.GetEvent (gameObject,"ScaleEvent");
		Physics.gravity = new Vector3(0, -gravityForce, 0);
	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Ground"){
			isJumping = false;
		}
	}
		
	public void Jump(){
		if(isJumping){
			return;
		}
		isJumping = true;
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		rigidbody.AddForce (-moveForce,jumpForce,0,ForceMode.Impulse);
		mScaleEvent.Play ();
	}
}
