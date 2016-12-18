using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public float moveSpeed = 10;
	public float jumpForce = 100;


	private int grounded = 0;
	private Rigidbody2D body;


	// Use this for initialization
	void Start () {
		this.body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");

		if (moveY > 0 && grounded > 0) {
			jump ();
		}

		if (moveY < 0)
			moveDown (moveY);

		move (moveX);
	}

	void moveDown (float moveY)
	{
		body.AddForce (new Vector2 (0, moveY * 10));
	}

	void move (float moveX)
	{
		body.AddForce (new Vector2 (moveX * moveSpeed, 0));
	}

	void jump ()
	{
		SoundEffectsHelper.Instance.MakeJumpSound ();
		body.AddForce (new Vector2 (0, jumpForce));
	}

	public void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "ground")
			grounded++;
	}
	
	public void OnCollisionExit2D(Collision2D collision) {
		if (collision.gameObject.tag == "ground")
			grounded--;
	}
}
