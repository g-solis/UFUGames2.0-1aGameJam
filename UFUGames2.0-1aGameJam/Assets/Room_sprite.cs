using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_sprite : MonoBehaviour {

	public Camera cam;
	public Transform transf;
	public BoxCollider2D boxc;
	public GameObject stage;
	public int x, y;
	public Vector3 nextlocation;

	void Start () {
		cam = Camera.main;
		nextlocation = transf.position;
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			MoveLeft ();
		}
	}

	public void MoveLeft() {
		if (x - 1 >= 0) {
			if (stage_script.room_matrix[x-1,y] == false) {
				stage_script.room_matrix[x-1,y] = true;
				stage_script.room_matrix[x,y] = false;
				x -= 1;
				nextlocation.x -= 6.6f;
				StartCoroutine (MoveCoroutine(nextlocation,1f));
			}
		}
			

	}
	public void MoveRight() {
		if (x + 1 < stage_script.room_size_x) {
			if (stage_script.room_matrix[x+1,y] == false) {
				stage_script.room_matrix[x+1,y] = true;
				stage_script.room_matrix[x,y] = false;
				x += 1;
				nextlocation.x += 6.6f;
				StartCoroutine (MoveCoroutine(nextlocation,1f));
			}
		}


	}
	public void MoveUp() {
		if (y - 1 >= 0) {
			if (stage_script.room_matrix[x,y-1] == false) {
				stage_script.room_matrix[x,y-1] = true;
				stage_script.room_matrix[x,y] = false;
				y -= 1;
				nextlocation.y -= 6.6f;
				StartCoroutine (MoveCoroutine(nextlocation,1f));
			}
		}


	}
	public void MoveDown() {
		if (y + 1 < stage_script.room_size_y) {
			if (stage_script.room_matrix[x,y+1] == false) {
				stage_script.room_matrix[x,y+1] = true;
				stage_script.room_matrix[x,y] = false;
				y += 1;
				nextlocation.y += 6.6f;
				StartCoroutine (MoveCoroutine(nextlocation,1f));
			}
		}


	}

	public IEnumerator MoveCoroutine(Vector3 nextlocation,float duration){
		float alfa = 0;
		while(alfa < 1){
			transf.position = Vector3.Lerp (transf.position, nextlocation, alfa);
			alfa += Time.deltaTime*duration;
			yield return null;
		}
	}

}
