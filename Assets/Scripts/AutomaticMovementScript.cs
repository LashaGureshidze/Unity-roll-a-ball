using UnityEngine;
using System.Collections;

public class AutomaticMovementScript : MonoBehaviour {

	public Vector2 direction;
	public float speed = 2;


	private Rigidbody2D rigidbody2d;
	private int dir = 1;

	// Use this for initialization
	void Start () {
		rigidbody2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2d.velocity = new Vector2(dir * speed * direction.x, dir * speed * direction.y); 
	}

	public void OnCollisionEnter2D(Collision2D collision) {

		if (collision.gameObject.tag == "ground") {
			dir *= -1;
		}
	}
}
