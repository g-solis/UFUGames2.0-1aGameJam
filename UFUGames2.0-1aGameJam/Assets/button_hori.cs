using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_hori : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		if (this.gameObject.GetComponentInParent<Room_sprite>().x == 0)
			this.gameObject.GetComponentInParent<Room_sprite>().MoveRight();
		else
			this.gameObject.GetComponentInParent<Room_sprite>().MoveLeft();
	}
}
