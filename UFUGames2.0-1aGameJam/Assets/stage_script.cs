using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage_script : MonoBehaviour {

	public static int room_size_x = 2;
	public static int room_size_y = 2;
	public static bool[,] room_matrix = new bool[2,2];
	void Start () {
		for (int i = 0; i < room_size_x; i++) {
			for (int j = 0; j < room_size_y; j++) {
				room_matrix [i,j] = false; 
			}
		}
		room_matrix [0,0] = true;
		room_matrix [1,0] = true;
		room_matrix [1,1] = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
