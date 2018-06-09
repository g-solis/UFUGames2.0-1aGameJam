using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int velocidade;
	private Rigidbody2D rgdb;
	private bool emEscada = false;
	

	// Use this for initialization
	void Start () {
		rgdb = gameObject.GetComponent<Rigidbody2D> ();		
	}
	
	// Update is called once per frame
	void Update () {
		float moveX = Input.GetAxisRaw ("Horizontal");
		float moveY = Input.GetAxisRaw ("Vertical");;

		this.rgdb.velocity = new Vector2 (velocidade * moveX, this.rgdb.velocity.y);

		
		if (emEscada)
		{
			this.rgdb.gravityScale = 0;
			this.rgdb.velocity = new Vector2 (this.rgdb.velocity.x, moveY*5);
		}
	}

	void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag ("Alavanca"))
		{
			//if(Input.GetKeyDown("e"))	
		}

		if (other.gameObject.CompareTag ("Escada"))
		{
			emEscada = true;	
		}
    }

	void OnTriggerExit2D(Collider2D other)
	{
		emEscada = false;
		if (other.gameObject.CompareTag ("Escada"))
		{
			this.rgdb.gravityScale = 2;
		}
	}
}
