using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public int totalStars;
	public int level;

	private int earnedStars = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onMainMenu() {
		SoundEffectsHelper.Instance.MakeButtonSound ();
		Application.LoadLevel("Menu");
	}

	public void OnCollisionEnter2D(Collision2D collision) {
		if (collision.collider.gameObject.tag == "nail") {
			SoundEffectsHelper.Instance.MakeYellSound();

			Application.LoadLevel("Level" + level);
			//Application.LoadLevel("Level" + level);
		}
	}


	public void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "star") {
			earnedStars ++;

			Destroy (collider.gameObject);

			SoundEffectsHelper.Instance.MakePointSound ();
		} else if (collider.gameObject.tag == "flag") {
			if (earnedStars < totalStars) {
				//TODO
				return;
			}

			if (level == 4) {
				Application.LoadLevel("ChooseLevel");
			} else {
				Application.LoadLevel("Level" + (level+1));
			}
		}
	}
}
