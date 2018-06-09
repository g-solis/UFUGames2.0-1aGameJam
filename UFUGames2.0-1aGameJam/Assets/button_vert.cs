using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_vert : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown(){
		if (this.gameObject.GetComponentInParent<Room_sprite>().y == 0)
			this.gameObject.GetComponentInParent<Room_sprite>().MoveDown();
		else
			this.gameObject.GetComponentInParent<Room_sprite>().MoveUp();
	}
}
