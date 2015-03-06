using UnityEngine;
using System.Collections;

public class PlayerTestController : MonoBehaviour {

	public Player player;

	void OnTap(){
		player.Jump ();
	}
}
